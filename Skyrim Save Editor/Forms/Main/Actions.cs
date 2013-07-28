using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Skyrim_Save_Editor.Saves;
using Skyrim_Save_Editor.Forms.About;
using Skyrim_Save_Editor.Forms.ErrorDisplay;

namespace Skyrim_Save_Editor.Forms.Main {
	public partial class MainForm {
		void createSave(Object sender, EventArgs e) {
			resetControls();

			activeSave = new SaveFile().CreateNew();
			if (activeSave == null) {
				return;
			}

			saveMenuItem.Enabled = true;
			closeMenuItem.Enabled = true;
			saveToolButton.Enabled = true;
			closeToolButton.Enabled = true;
			panel.Visible = true;

			populateControls();
		}

		void openSave(Object sender, EventArgs e) {
			if (openFileDialog.ShowDialog() == DialogResult.OK) {
				try {
					SaveFile saveFile = new SaveFile().LoadFromFile(openFileDialog.FileName);
					if (saveFile == null) {
						return;
					}
					activeSave = saveFile;

					resetControls();
					saveMenuItem.Enabled = true;
					closeMenuItem.Enabled = true;
					saveToolButton.Enabled = true;
					closeToolButton.Enabled = true;
					panel.Visible = true;

					populateControls();
				}
				catch (Exception exception) {
					new ErrorForm(2000, exception).ShowDialog();
				}

				openFileDialog.FileName = "";
			}
		}

		private void closeSave(Object sender, EventArgs e) {
			saveMenuItem.Enabled = false;
			closeMenuItem.Enabled = false;
			saveToolButton.Enabled = false;
			closeToolButton.Enabled = false;
			panel.Visible = false;

			resetControls();
		}


	}
}
