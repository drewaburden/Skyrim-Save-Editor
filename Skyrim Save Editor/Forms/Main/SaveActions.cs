using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Skyrim_Save_Editor.Saves;

namespace Skyrim_Save_Editor.Forms.Main {
	public partial class MainForm {
		void createSave(Object sender, EventArgs e) {
			resetControls();

			activeSave = saveManager.createSave();

			saveMenuItem.Enabled = true;
			closeMenuItem.Enabled = true;
			saveToolButton.Enabled = true;
			closeToolButton.Enabled = true;
			tabControl.Visible = true;
			tabControl.SelectedTab = generalTab;

			populateControls();
		}

		void openSave(Object sender, EventArgs e) {
			if (openFileDialog.ShowDialog() == DialogResult.OK) {
				SaveFile saveFile = saveManager.load(openFileDialog.FileName);

				if (saveFile != null) {
					activeSave = saveFile;

					resetControls();
					saveMenuItem.Enabled = true;
					closeMenuItem.Enabled = true;
					saveToolButton.Enabled = true;
					closeToolButton.Enabled = true;
					tabControl.Visible = true;
					tabControl.SelectedTab = generalTab;
					labelScreenshot.Visible = false;

					populateControls();
				}
				else {
					//MainForm.closeToolStripMenuItem_Click(nullptr, nullptr);
				}

				openFileDialog.FileName = "";
			}
		}
		
		private void closeSave(Object sender, EventArgs e) {
			saveMenuItem.Enabled = false;
			closeMenuItem.Enabled = false;
			saveToolButton.Enabled = false;
			closeToolButton.Enabled = false;
			tabControl.Visible = false;

			resetControls();
		}
	}
}
