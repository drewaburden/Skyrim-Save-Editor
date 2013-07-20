using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Skyrim_Save_Editor.Saves;
using Skyrim_Save_Editor.Saves.SaveFields;
using Skyrim_Save_Editor.Saves.SaveSections;
using Skyrim_Save_Editor.Forms.Settings;
using Skyrim_Save_Editor.Forms.About;
using Skyrim_Save_Editor.Forms.KeyEdit;
using Skyrim_Save_Editor.Forms.Main.Advanced;
using BrightIdeasSoftware;

namespace Skyrim_Save_Editor.Forms.Main {
	public partial class MainForm : Form {
		private SaveFile activeSave;
		private SaveFile saveDiff; // Changes made that are different from the originally loaded save will be stored here

		#region Constructor/Destructor
		public MainForm() {
			InitializeComponent();

			this.treeListView.CanExpandGetter = delegate(object x) {
				return (x as TreeItem).Children != null && (x as TreeItem).Children.Count > 0;
			};
			this.treeListView.ChildrenGetter = delegate(object x) {
				return new ArrayList((x as TreeItem).Children);
			};
			this.treeColumn.AspectGetter = delegate(object x) {
				return ((x as TreeItem).NodeData as SaveSection).blockName;
			};
			this.typeImageColumn.AspectToStringConverter = delegate(object x) {
				return String.Empty;
			};

			this.treeListView.TreeColumnRenderer = new LineRenderer();
			Pen pen = new Pen(Color.Gray, 1.0f);
			pen.DashStyle = DashStyle.Dot;
			this.treeListView.TreeColumnRenderer.LinePen = pen;

			HotItemStyle style = new HotItemStyle();
			style.BackColor = SystemColors.Control;
			this.fieldListView.HotItemStyle = style;

			this.typeColumn.AspectGetter = delegate(object x) {
				return (x as SaveField).Type;
			};
			this.typeImageColumn.AspectGetter = delegate(object x) {
				return (x as SaveField).Type;
			};
			this.typeImageColumn.AspectToStringConverter = delegate(object x) {
				return String.Empty;
			};
			this.typeImageColumn.ImageGetter = delegate(object x) {
				String type = (x as SaveField).Type;
				switch (type) {
					case "String":
					case "Byte":
					case "Single":
					case "Double":
					case "DateTime":
					case "RefID":
						return type;

					case "UInt16":
					case "UInt32":
					case "UInt64":
					case "Int16":
					case "Int32":
					case "Int64":
						return "Int";

					case "ScreenshotData":
						return "Image";

					default:
						return "Unknown";
				}
			};

			this.valueColumn.AspectToStringConverter = delegate(object x) {
				if (x is DateTime) {
					return ((DateTime) x).ToString("ddd, MMM dd, yyyy h:mmtt");
				}
				else if (x is ScreenshotData) {
					return "[RGB Data]";
				}

				return String.Format("{0}", x);
			};
			fieldListView.CellEditStarting += delegate(object sender, CellEditEventArgs e) {
				if (e.Value is DateTime) {
					DateTimePicker picker = new DateTimePicker();
					picker.CustomFormat = "ddd, MMM dd, yyyy h:mmtt";
					picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
					picker.Bounds = e.CellBounds;
					picker.Value = (DateTime) e.Value;
					e.Control = picker;
				}
				else if (e.Value is ScreenshotData || e.Value is Byte) {
					Label label = new Label();
					label.Text = "Value not editable.";
					label.TextAlign = ContentAlignment.MiddleLeft;
					label.Bounds = e.CellBounds;
					e.Control = label;
				}
				else if (e.Value is String && (e.RowObject as SaveField<String>).Key == "gameDate") {
					MaskedTextBox masked = new MaskedTextBox();
					masked.Mask = "000.00.00";
					masked.BeepOnError = true;
					masked.Text = (String) e.Value;
					masked.Bounds = e.CellBounds;
					e.Control = masked;
				}
				else if (e.Value is String && (e.RowObject as SaveField<String>).Key == "playerRace") {
					ComboBox race = new ComboBox();
					race.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
					race.FormattingEnabled = true;
					int position;
					for (position = 0; position < 10; ++position) {
						String raceString = ((Race) position).ToString("g");
						race.Items.Add(raceString);
						if ((e.Value as String) == raceString) {
							race.SelectedIndex = position;
						}
					}
					race.Bounds = e.CellBounds;
					e.Control = race;
				}
			};
			fieldListView.CellEditFinishing += delegate(object x, CellEditEventArgs e) {
				if (!e.Cancel && e.Value is String &&
					(e.RowObject as SaveField<String>).Key == "gameDate") {
					String value = e.NewValue as String;
					value = value.Replace(' ', '0');
					value = value.PadRight(9, '0');
					e.NewValue = (Object) value;
				}
				else if (!e.Cancel && e.Value is String &&
					(e.RowObject as SaveField<String>).Key == "playerRace") {
					String value = e.NewValue as String;
					value = ((Race) ((ComboBox) e.Control).SelectedIndex).ToString("g");
					e.NewValue = (Object) value;
				}
			};
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}
		#endregion

		#region Form Lifetime Actions
		private void closeForm(System.Object sender, System.EventArgs e) {
			this.Close();
		}

		private void showSettingsForm(Object sender, EventArgs e) {
			SettingsForm settingsForm = new SettingsForm();
			settingsForm.ShowDialog(this);
		}
		private void showAboutForm(object sender, EventArgs e) {
			AboutForm aboutForm = new AboutForm();
			aboutForm.ShowDialog(this);
		}
		#endregion

		#region Component Lifetime Actions
		private void resetControls() {
			fieldListView.ClearObjects();
			saveName.ResetText();
			ingameDate.ResetText();
			saveTime.ResetText();
			playerName.ResetText();
			playerLevel.Value = 0;
			playerExperienceBar.Maximum = 100;
			playerExperienceBox.Maximum = 100;
			playerExperienceBox.Value = 0;
			playerRace.SelectedIndex = -1;
			maleSex.Checked = false;
			femaleSex.Checked = false;
			Bitmap image = new Bitmap(320, 192);
			screenshot.Image = (Image) image.Clone();
			labelScreenshot.Visible = true;
			pluginsList.Items.Clear();
			saveDiff = new SaveFile();
		}
		#endregion

		#region Key Handling
		// Todo: Separate all Advanced tab filtering methods into their own custom component class.
		void advancedFilter_KeyUp(Object sender, KeyEventArgs e) {
			/*foreach (ListViewItem item in advancedKeyValues.Items) {
				if (!item.Text.ToLower().Contains(advancedFilter.Text.ToLower())) {
					removedListViewItems.Add(item.Clone());
					item.Remove();
				}
			}
			for (int itemIndex = 0; itemIndex < removedListViewItems.Count; ++itemIndex) {
				ListViewItem item = (ListViewItem) removedListViewItems[itemIndex];
				if (item.Text.ToLower().Contains(advancedFilter.Text.ToLower())) {
					advancedKeyValues.Items.Add((ListViewItem) item.Clone());
					removedListViewItems.Remove(item);
					--itemIndex;
				}
			}*/
		}

		private void MainForm_KeyDown(Object sender, System.Windows.Forms.KeyEventArgs e) {
			if (e.KeyCode == Keys.O && e.Modifiers == Keys.Control && openMenuItem.Enabled) {
				openSave(sender, e);
			}
			else if (e.KeyCode == Keys.S && e.Modifiers == Keys.Control && saveMenuItem.Enabled) {

			}
			else if (e.KeyCode == Keys.S && e.Modifiers == (Keys.Control | Keys.Shift) && saveMenuItem.Enabled) {

			}
			else if (e.KeyCode == Keys.N && e.Modifiers == Keys.Control && newMenuItem.Enabled) {
				createSave(sender, e);
			}
			else if (e.KeyCode == Keys.W && e.Modifiers == Keys.Control && closeMenuItem.Enabled) {
				closeSave(sender, e);
			}
			else if (e.KeyCode == Keys.P && e.Modifiers == Keys.Control && settingsMenuItem.Enabled) {
				showSettingsForm(sender, e);
			}
			else if (e.KeyCode == Keys.Z && e.Modifiers == Keys.Control && undoMenuItem.Enabled) {

			}
			else if (e.KeyCode == Keys.Y && e.Modifiers == Keys.Control && redoMenuItem.Enabled) {

			}
		}
		#endregion

		#region Mouse Handling
		// Todo: Separate all Advanced tab filtering methods into their own custom component class.
		void advancedKeyValues_MouseDoubleClick(Object sender, MouseEventArgs e) {
			/*KeyEditForm keyEditForm = new KeyEditForm(advancedKeyValues.SelectedItems[0]);
			keyEditForm.ShowDialog(this);*/
		}
		void advancedFilter_Enter(Object sender, EventArgs e) {
			if (advancedFilter.ForeColor == SystemColors.InactiveCaptionText) {
				advancedFilter.Text = "";
				advancedFilter.ForeColor = SystemColors.WindowText;
				advancedFilterClear.Enabled = true;
			}
		}
		void advancedFilter_Leave(Object sender, EventArgs e) {
			if (advancedFilter.Text == "") {
				advancedFilter.ForeColor = SystemColors.InactiveCaptionText;
				advancedFilter.Text = "Filter...";
				advancedFilterClear.Enabled = false;
			}
		}
		void buttonAdvancedClear_Click(Object sender, EventArgs e) {
			advancedFilter.ForeColor = SystemColors.InactiveCaptionText;
			advancedFilter.Text = "Filter...";
			/*foreach (ListViewItem item in removedListViewItems) {
				advancedKeyValues.Items.Add((ListViewItem)item.Clone());
			}
			removedListViewItems.Clear();*/
			advancedFilterClear.Enabled = false;
		}

		private void treeListView_SelectedIndexChanged(object sender, EventArgs e) {
			fieldListView.ClearObjects();
			if (treeListView.SelectedObject is TreeItem) {
				TreeItem treeItem = (TreeItem) treeListView.SelectedObject;
				SaveSection section = (SaveSection) treeItem.NodeData;
				List<Object> fields = new List<Object>();
				foreach (SaveField field in section.GetFields()) {
					fields.Add(field);
				}
				fieldListView.AddObjects(fields);
			}
		}
		#endregion

		#region Value Change Handling
		void playerExperience_ValueChanged(Object sender, EventArgs e) {
			playerExperienceBar.Value = Convert.ToInt32(playerExperienceBox.Value);
			(activeSave.header as Header).playerCurExp.Value = (float) Convert.ToDouble(playerExperienceBox.Value);
		}
		void playerName_TextChanged(Object sender, EventArgs e) {
			if ((activeSave.header as Header).playerName.Value != playerName.Text) {
				(saveDiff.header as Header).playerName.Value = playerName.Text;
			}
		}
		void playerLevel_ValueChanged(Object sender, EventArgs e) {
			if ((activeSave.header as Header).playerLevel.Value != playerLevel.Value) {
				(saveDiff.header as Header).playerLevel.Value = Convert.ToUInt32(playerLevel.Value);
			}
		}
		void playerRace_SelectedIndexChanged(Object sender, EventArgs e) {
			/*String selectedRace = static_cast<Race>(playerRace.SelectedIndex).ToString("g");
			if (activeSave.header.playerRace != selectedRace) {
				saveDiff.header.playerRace = selectedRace;
			}*/
		}
		#endregion

		#region Minor Component Tweaks
		private void splitContainer_Paint(System.Object sender, System.Windows.Forms.PaintEventArgs e) {
			SplitContainer s = sender as SplitContainer;
			if (s != null) {
				int top = 0;
				int bottom = s.Height;
				int left = s.SplitterDistance;
				int right = left + s.SplitterWidth - 1;
				e.Graphics.DrawLine(Pens.Silver, left, top, left, bottom);
				e.Graphics.DrawLine(Pens.Silver, right, top, right, bottom);
			}
		}
		#endregion

		private void contextMenuStrip1_Opening(object sender, CancelEventArgs e) {
			if (fieldListView.GetItemCount() <= 0) {
				e.Cancel = true;
			}
		}

		private void contextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {
			if (e.ClickedItem == editToolStripMenuItem) {
				// Somehow programmatically start the cell editing. None of the ObjectListView's functions seem to work.
			}
		}

		private void buttonAdvancedClear_Click(object sender, MouseEventArgs e) {

		}
	}
}
