using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skyrim_Save_Editor.Forms.About {
	public partial class AboutForm : Form {
		public AboutForm() {
			InitializeComponent();
		}

		private void pictureBox2_Click(object sender, EventArgs e) {
			try {
				System.Diagnostics.Process.Start("http://creativecommons.org/licenses/by/3.0/us/");
			}
			catch (System.ComponentModel.Win32Exception noBrowser) {
				if (noBrowser.ErrorCode == -2147467259) {
					MessageBox.Show(noBrowser.Message);
				}
			}
			catch (System.Exception other) {
				MessageBox.Show(other.Message);
			}
		}

		private void pictureBox1_Click(object sender, EventArgs e) {
			try {
				System.Diagnostics.Process.Start("http://www.gnu.org/licenses/gpl.html");
			}
			catch (System.ComponentModel.Win32Exception noBrowser) {
				if (noBrowser.ErrorCode == -2147467259) {
					MessageBox.Show(noBrowser.Message);
				}
			}
			catch (System.Exception other) {
				MessageBox.Show(other.Message);
			}
		}

		private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e) {
			try {
				System.Diagnostics.Process.Start(e.LinkText);
			}
			catch (System.ComponentModel.Win32Exception noBrowser) {
				if (noBrowser.ErrorCode == -2147467259) {
					MessageBox.Show(noBrowser.Message);
				}
			}
			catch (System.Exception other) {
				MessageBox.Show(other.Message);
			}
		}
	}
}
