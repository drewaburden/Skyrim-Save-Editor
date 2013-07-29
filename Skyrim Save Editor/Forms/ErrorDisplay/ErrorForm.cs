using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skyrim_Save_Editor.Forms.ErrorDisplay {
	public partial class ErrorForm : Form {
		bool detailsShowing = false;
		Error error;

		public ErrorForm(int errNum) : this(errNum, null) { }
		public ErrorForm(int errNum, Exception exception) {
			InitializeComponent();

			if (!Errors.ErrorNumbers.TryGetValue(errNum, out error)) {
				error = Errors.ErrorNumbers[10201];
				error.Details = "Attempted error code: " + errNum;
				errNum = 10201;
			}

			if (error.Fatal) {
				this.continueButton.Enabled = false;
				this.AcceptButton = quitButton;
				this.Text = "Fatal Error";
				error.Text += "\nUnfortunately, the editor cannot recover from this error and must close.";
			}
			else {
				error.Text += "\nThe editor can try to continue with normal operation; however, this may cause instability problems. Continue at your own risk.";
			}

			if (error.Details != null) {
				this.detailsButton.Visible = true;
				this.errorDetails.Text = error.Details + "\n\n";
			}
			if (exception != null) {
				this.detailsButton.Visible = true;
				this.errorDetails.Text = exception.ToString();
			}

			this.errorText.Text = error.Text + "\n(Code: " + errNum + ")";
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

		private void continueButton_Click(object sender, EventArgs e) {
			this.Close();
		}
	}
}
