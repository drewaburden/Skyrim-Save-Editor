namespace Skyrim_Save_Editor.Forms.Settings {
	partial class SettingTemplate {
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.controlLabel = new System.Windows.Forms.Label();
			this.descriptionLabel = new System.Windows.Forms.Label();
			this.settingImage = new System.Windows.Forms.PictureBox();
			this.headingLabel = new System.Windows.Forms.Label();
			this.settingsControl = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.settingImage)).BeginInit();
			this.SuspendLayout();
			// 
			// controlLabel
			// 
			this.controlLabel.AutoSize = true;
			this.controlLabel.Location = new System.Drawing.Point(50, 65);
			this.controlLabel.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
			this.controlLabel.Name = "controlLabel";
			this.controlLabel.Size = new System.Drawing.Size(60, 13);
			this.controlLabel.TabIndex = 12;
			this.controlLabel.Text = "Control text";
			// 
			// descriptionLabel
			// 
			this.descriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.descriptionLabel.Location = new System.Drawing.Point(50, 27);
			this.descriptionLabel.Margin = new System.Windows.Forms.Padding(3, 0, 6, 0);
			this.descriptionLabel.Name = "descriptionLabel";
			this.descriptionLabel.Padding = new System.Windows.Forms.Padding(3, 3, 0, 0);
			this.descriptionLabel.Size = new System.Drawing.Size(244, 32);
			this.descriptionLabel.TabIndex = 11;
			this.descriptionLabel.Text = "Description";
			// 
			// settingImage
			// 
			this.settingImage.Location = new System.Drawing.Point(12, 27);
			this.settingImage.Margin = new System.Windows.Forms.Padding(12, 3, 3, 3);
			this.settingImage.Name = "settingImage";
			this.settingImage.Size = new System.Drawing.Size(32, 32);
			this.settingImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.settingImage.TabIndex = 10;
			this.settingImage.TabStop = false;
			// 
			// headingLabel
			// 
			this.headingLabel.AutoSize = true;
			this.headingLabel.Location = new System.Drawing.Point(3, 8);
			this.headingLabel.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
			this.headingLabel.Name = "headingLabel";
			this.headingLabel.Size = new System.Drawing.Size(47, 13);
			this.headingLabel.TabIndex = 9;
			this.headingLabel.Text = "Heading";
			// 
			// settingsControl
			// 
			this.settingsControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.settingsControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.settingsControl.FormattingEnabled = true;
			this.settingsControl.Items.AddRange(new object[] {
            "UTC+0",
            "Local time"});
			this.settingsControl.Location = new System.Drawing.Point(118, 62);
			this.settingsControl.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
			this.settingsControl.Name = "settingsControl";
			this.settingsControl.Size = new System.Drawing.Size(176, 21);
			this.settingsControl.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Location = new System.Drawing.Point(3, 16);
			this.label1.Margin = new System.Windows.Forms.Padding(0, 16, 6, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(291, 2);
			this.label1.TabIndex = 8;
			// 
			// SettingTemplate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.controlLabel);
			this.Controls.Add(this.descriptionLabel);
			this.Controls.Add(this.settingImage);
			this.Controls.Add(this.headingLabel);
			this.Controls.Add(this.settingsControl);
			this.Controls.Add(this.label1);
			this.Name = "SettingTemplate";
			this.Size = new System.Drawing.Size(300, 90);
			((System.ComponentModel.ISupportInitialize)(this.settingImage)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label controlLabel;
		private System.Windows.Forms.Label descriptionLabel;
		private System.Windows.Forms.PictureBox settingImage;
		private System.Windows.Forms.Label headingLabel;
		private System.Windows.Forms.ComboBox settingsControl;
		private System.Windows.Forms.Label label1;
	}
}
