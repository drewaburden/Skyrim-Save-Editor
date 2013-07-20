using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using Skyrim_Save_Editor.Forms.KeyEdit;

namespace Skyrim_Save_Editor.Forms.Main {
	partial class MainForm {
		void advancedKeyValues_MouseDoubleClick(Object sender, MouseEventArgs  e) {
			KeyEditForm keyEditForm = new KeyEditForm(advancedKeyValues.SelectedItems[0]);
			keyEditForm.ShowDialog(this);
		}
		void advancedFilter_Enter(Object  sender, EventArgs  e) {
			if (advancedFilter.ForeColor == SystemColors.InactiveCaptionText) {
				advancedFilter.Text = "";
				advancedFilter.ForeColor = SystemColors.WindowText;
				advancedFilterClear.Enabled = true;
			}
		}
		void advancedFilter_Leave(Object  sender, EventArgs  e) {
			if (advancedFilter.Text == "") {
				advancedFilter.ForeColor = SystemColors.InactiveCaptionText;
				advancedFilter.Text = "Filter...";
				advancedFilterClear.Enabled = false;
			}
		}
		void buttonAdvancedClear_Click(Object  sender, EventArgs  e) {
			advancedFilter.ForeColor = SystemColors.InactiveCaptionText;
			advancedFilter.Text = "Filter...";
			/*foreach (ListViewItem item in removedListViewItems) {
				advancedKeyValues.Items.Add((ListViewItem)item.Clone());
			}
			removedListViewItems.Clear();*/
			advancedFilterClear.Enabled = false;
		}
	}
}
