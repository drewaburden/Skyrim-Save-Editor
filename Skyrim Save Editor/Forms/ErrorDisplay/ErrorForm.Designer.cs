namespace Skyrim_Save_Editor.Forms.ErrorDisplay {
	partial class ErrorForm {
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorForm));
			this.quitButton = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.errorDetails = new System.Windows.Forms.TextBox();
			this.errorImage = new System.Windows.Forms.PictureBox();
			this.errorText = new System.Windows.Forms.Label();
			this.detailsButton = new System.Windows.Forms.Button();
			this.arrowImages = new System.Windows.Forms.ImageList(this.components);
			this.continueButton = new System.Windows.Forms.Button();
			this.errorImages = new System.Windows.Forms.ImageList(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.errorImage)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// quitButton
			// 
			this.quitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.quitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.quitButton.Location = new System.Drawing.Point(347, 113);
			this.quitButton.Name = "quitButton";
			this.quitButton.Size = new System.Drawing.Size(75, 23);
			this.quitButton.TabIndex = 0;
			this.quitButton.Text = "Quit";
			this.quitButton.UseVisualStyleBackColor = true;
			this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.Location = new System.Drawing.Point(185, 113);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "Help";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// errorDetails
			// 
			this.errorDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.errorDetails.Location = new System.Drawing.Point(12, 147);
			this.errorDetails.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
			this.errorDetails.Multiline = true;
			this.errorDetails.Name = "errorDetails";
			this.errorDetails.ReadOnly = true;
			this.errorDetails.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.errorDetails.Size = new System.Drawing.Size(410, 128);
			this.errorDetails.TabIndex = 2;
			this.errorDetails.Visible = false;
			// 
			// errorImage
			// 
			this.errorImage.Location = new System.Drawing.Point(17, 17);
			this.errorImage.Margin = new System.Windows.Forms.Padding(8);
			this.errorImage.Name = "errorImage";
			this.errorImage.Size = new System.Drawing.Size(32, 32);
			this.errorImage.TabIndex = 4;
			this.errorImage.TabStop = false;
			// 
			// errorText
			// 
			this.errorText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.errorText.Location = new System.Drawing.Point(69, 17);
			this.errorText.Margin = new System.Windows.Forms.Padding(12, 8, 8, 16);
			this.errorText.Name = "errorText";
			this.errorText.Size = new System.Drawing.Size(351, 70);
			this.errorText.TabIndex = 5;
			this.errorText.Text = "Error text";
			// 
			// detailsButton
			// 
			this.detailsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.detailsButton.ImageIndex = 0;
			this.detailsButton.ImageList = this.arrowImages;
			this.detailsButton.Location = new System.Drawing.Point(12, 113);
			this.detailsButton.Name = "detailsButton";
			this.detailsButton.Size = new System.Drawing.Size(75, 23);
			this.detailsButton.TabIndex = 6;
			this.detailsButton.Text = "Details";
			this.detailsButton.UseVisualStyleBackColor = true;
			this.detailsButton.Visible = false;
			this.detailsButton.Click += new System.EventHandler(this.detailsButton_Click);
			// 
			// arrowImages
			// 
			this.arrowImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("arrowImages.ImageStream")));
			this.arrowImages.TransparentColor = System.Drawing.Color.Transparent;
			this.arrowImages.Images.SetKeyName(0, "arrowdown.png");
			this.arrowImages.Images.SetKeyName(1, "arrowup.png");
			// 
			// continueButton
			// 
			this.continueButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.continueButton.Location = new System.Drawing.Point(266, 113);
			this.continueButton.Name = "continueButton";
			this.continueButton.Size = new System.Drawing.Size(75, 23);
			this.continueButton.TabIndex = 7;
			this.continueButton.Text = "Continue";
			this.continueButton.UseVisualStyleBackColor = true;
			this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
			// 
			// errorImages
			// 
			this.errorImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("errorImages.ImageStream")));
			this.errorImages.TransparentColor = System.Drawing.Color.Transparent;
			this.errorImages.Images.SetKeyName(0, "error.png");
			this.errorImages.Images.SetKeyName(1, "exclamation.png");
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.panel1.Controls.Add(this.errorText);
			this.panel1.Controls.Add(this.errorImage);
			this.panel1.Location = new System.Drawing.Point(-1, -1);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(440, 103);
			this.panel1.TabIndex = 15;
			// 
			// ErrorForm
			// 
			this.AcceptButton = this.continueButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.quitButton;
			this.ClientSize = new System.Drawing.Size(434, 147);
			this.Controls.Add(this.continueButton);
			this.Controls.Add(this.detailsButton);
			this.Controls.Add(this.errorDetails);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.quitButton);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ErrorForm";
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Error";
			((System.ComponentModel.ISupportInitialize)(this.errorImage)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button quitButton;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox errorDetails;
		private System.Windows.Forms.PictureBox errorImage;
		private System.Windows.Forms.Label errorText;
		private System.Windows.Forms.Button detailsButton;
		private System.Windows.Forms.Button continueButton;
		private System.Windows.Forms.ImageList arrowImages;
		private System.Windows.Forms.ImageList errorImages;
		private System.Windows.Forms.Panel panel1;
	}
}