using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skyrim_Save_Editor.Forms.Main {
	partial class MainForm {
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
				openSettings(sender, e);
			}
			else if (e.KeyCode == Keys.Z && e.Modifiers == Keys.Control && undoMenuItem.Enabled) {

			}
			else if (e.KeyCode == Keys.Y && e.Modifiers == Keys.Control && redoMenuItem.Enabled) {

			}
		}
	}
}
