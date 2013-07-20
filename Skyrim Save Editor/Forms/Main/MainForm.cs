using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Skyrim_Save_Editor.Saves;
using Skyrim_Save_Editor.Forms.Settings;
using Skyrim_Save_Editor.Forms.About;
using Skyrim_Save_Editor.Forms.KeyEdit;

namespace Skyrim_Save_Editor.Forms.Main {
	public partial class MainForm : Form {
		private SaveFile activeSave;
		private SaveFile saveDiff; // Changes made that are different from the originally loaded save will be stored here
		private ArrayList listViewItems;
		private ArrayList removedListViewItems;

		#region Constructor/Destructor
		public MainForm() {
			InitializeComponent();

			this.typeColumn.AspectGetter = delegate(object x) {
				return ((SaveField) x).Type;
			};
			this.typeColumn.AspectToStringConverter = delegate(object x) {
				return String.Empty;
			};
			this.typeColumn.ImageGetter = delegate(object x) {
				String type = ((SaveField) x).Type;
				switch (type) {
					case "String":
					case "Byte":
					case "Single":
					case "Double":
					case "DateTime":
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
			KeyEditForm keyEditForm = new KeyEditForm(advancedKeyValues.SelectedItems[0]);
			keyEditForm.ShowDialog(this);
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
	}
}
