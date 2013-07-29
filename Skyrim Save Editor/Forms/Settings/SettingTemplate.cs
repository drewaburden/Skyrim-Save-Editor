using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skyrim_Save_Editor.Forms.Settings {
	public partial class SettingTemplate : UserControl {
		public Control Control { get; set; }

		public SettingTemplate() {
			InitializeComponent();
		}
		public void SetInformation(String header, String description, String controlText, Control control, Image image) {
			headingLabel.Text = header;
			settingImage.Image = image;
			Control = control;

			// Scale/position controls based on description length.
			descriptionLabel.Text = description;
			SizeF descriptionSize = this.CreateGraphics().MeasureString(descriptionLabel.Text, descriptionLabel.Font, descriptionLabel.Width);
			int descriptionHeight = (int) Math.Ceiling(descriptionSize.Height) + 5;
			descriptionLabel.Height = descriptionHeight;
			this.Height = descriptionHeight + 58;
			controlLabel.Location = new Point(controlLabel.Location.X, descriptionHeight + 33);
			settingsControl.Location = new Point(settingsControl.Location.X, descriptionHeight + 30);

			// Scale/position controls based on control text length
			controlLabel.Text = controlText;
			SizeF controlTextSize = this.CreateGraphics().MeasureString(controlLabel.Text, controlLabel.Font);
			int controlTextWidth = (int) Math.Ceiling(controlTextSize.Width);
			settingsControl.Location = new Point(controlTextWidth + 56, settingsControl.Location.Y);
			settingsControl.Width = this.Width - settingsControl.Location.X - 6;
		}
	}
}
