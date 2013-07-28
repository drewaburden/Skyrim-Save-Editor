using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skyrim_Save_Editor.Forms.Error {
	public partial class ErrorForm : Form {
		bool detailsShowing = false;
		int errorNumber = 0;
		bool isFatalError = false;
		public ErrorForm(int errNum, bool fatal) {
			InitializeComponent();
			errorNumber = errNum;
			isFatalError = fatal;

			if (isFatalError) {
				continueButton.Enabled = false;
				this.AcceptButton = quitButton;
			}
		}

		private void detailsButton_Click(object sender, EventArgs e) {
			if (!detailsShowing) {
				this.Size = new System.Drawing.Size(this.Width, 320);
				detailsButton.ImageIndex = 1;
				detailsShowing = true;
			}
			else {
				this.Size = new System.Drawing.Size(this.Width, 168);
				detailsButton.ImageIndex = 0;
				detailsShowing = false;
			}
		}

		private void quitButton_Click(object sender, EventArgs e) {
			Environment.Exit(0);
		}
	}
}
