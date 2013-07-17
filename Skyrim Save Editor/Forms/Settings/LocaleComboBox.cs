using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Skyrim_Save_Editor.Forms.Settings {
	public partial class LocaleComboBox : ComboBox {
		public LocaleComboBox() {
			InitializeComponent();
		}

		public LocaleComboBox(IContainer container) {
			container.Add(this);

			InitializeComponent();
		}

		private void LocaleComboBox_DrawItem(object sender, DrawItemEventArgs e) {
			e.DrawBackground();
			if (e.Index >= 0) {
				LocaleComboBoxItem currentItem = null;
				try {
					currentItem = (LocaleComboBoxItem) this.Items[e.Index];
				}
				catch (InvalidCastException) {
					//If the item in the combo box is not of type LegendItem,
					//then we just draw the item without the legend colour.
					e.Graphics.DrawString(this.Items[e.Index].ToString(), this.Font,
						new SolidBrush(this.ForeColor), e.Bounds);

					return;
				}

				//Draw rectangle with legend colour.
				e.Graphics.DrawImage(currentItem.Image, new Point(e.Bounds.X + 1, e.Bounds.Y-1));
				e.Graphics.DrawString(currentItem.Data.ToString(), this.Font,
				   new SolidBrush(this.ForeColor),
				   new Rectangle(e.Bounds.X + 19,
								   e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
			}
		}
	}
}
