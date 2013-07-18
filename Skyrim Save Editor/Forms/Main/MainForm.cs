using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Skyrim_Save_Editor.Saves;
using Skyrim_Save_Editor.Forms.Settings;

namespace Skyrim_Save_Editor.Forms.Main {
	public partial class MainForm : Form {
		private SaveFile activeSave;
		private SaveFile saveDiff; // Changes made that are different from the originally loaded save will be stored here
		
		public MainForm() {
			InitializeComponent();

			this.typeColumn.AspectGetter = delegate(object x) {
				return ((SaveFile.SaveFieldType) x).Type;
			};
			this.typeColumn.AspectToStringConverter = delegate(object x) {
				return String.Empty;
			};
			this.typeColumn.ImageGetter = delegate(object x) {
				String type = ((SaveFile.SaveFieldType) x).Type;
				switch (type) {
					case "String":
					case "Byte":
					case "Single":
					case "Double":
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

					case "FILETIME":
						return "Filetime";

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

		private void closeForm(System.Object sender, System.EventArgs e) {
			this.Close();
		}

		private void openSettings(Object sender, EventArgs e) {
			SettingsForm settingsForm = new SettingsForm();
			settingsForm.ShowDialog(this);
		}

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
	}
}
