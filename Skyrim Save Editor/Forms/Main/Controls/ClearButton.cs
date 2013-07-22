using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skyrim_Save_Editor.Forms.Main.Controls {
	public partial class ClearButton : UserControl {
		private bool buttonEnabled;
		public bool ButtonEnabled {
			get { return buttonEnabled; }
			set {
				if (value == true) {
					clearImage.Image = clearButtonImageList.Images[1];
				}
				else {
					clearImage.Image = clearButtonImageList.Images[0];
				}
				buttonEnabled = value;
			}
		}

		public ClearButton() {
			InitializeComponent();
			ButtonEnabled = false;
			clearImage.Image = clearButtonImageList.Images[0];
		}

		private void clearImage_MouseDown(object sender, MouseEventArgs e) {
			if (ButtonEnabled) {
				clearImage.Image = clearButtonImageList.Images[3];
			}
		}

		private void clearImage_MouseEnter(object sender, EventArgs e) {
			if (ButtonEnabled) {
				clearImage.Image = clearButtonImageList.Images[2];
			}
		}

		private void clearImage_MouseLeave(object sender, EventArgs e) {
			if (ButtonEnabled) {
				clearImage.Image = clearButtonImageList.Images[1];
			}
		}

		private void clearImage_MouseUp(object sender, MouseEventArgs e) {
			if (ButtonEnabled) {
				clearImage.Image = clearButtonImageList.Images[1];
			}
		}

		private void clearImage_Click(object sender, EventArgs e) {
			this.OnClick(e);
		}
	}
}
