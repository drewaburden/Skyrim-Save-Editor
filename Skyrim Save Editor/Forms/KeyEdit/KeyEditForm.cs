using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skyrim_Save_Editor.Forms.KeyEdit {
	public partial class KeyEditForm : Form {
		public KeyEditForm(ListViewItem selectedItem) {
			InitializeComponent();

			this.selectedItem = selectedItem;
			key.Text = selectedItem.Text;
			value.Text = selectedItem.SubItems[1].Text;
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
	}
}
