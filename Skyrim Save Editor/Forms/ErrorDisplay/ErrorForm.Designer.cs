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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.errorText = new System.Windows.Forms.Label();
			this.detailsButton = new System.Windows.Forms.Button();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.continueButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// quitButton
			// 
			this.quitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.quitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.quitButton.Location = new System.Drawing.Point(360, 98);
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
			this.button2.Location = new System.Drawing.Point(198, 98);
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
			this.errorDetails.Location = new System.Drawing.Point(12, 132);
			this.errorDetails.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
			this.errorDetails.Multiline = true;
			this.errorDetails.Name = "errorDetails";
			this.errorDetails.ReadOnly = true;
			this.errorDetails.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.errorDetails.Size = new System.Drawing.Size(423, 137);
			this.errorDetails.TabIndex = 2;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(25, 17);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(16, 8, 3, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(32, 32);
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// errorText
			// 
			this.errorText.Location = new System.Drawing.Point(76, 17);
			this.errorText.Margin = new System.Windows.Forms.Padding(16, 0, 16, 16);
			this.errorText.Name = "errorText";
			this.errorText.Size = new System.Drawing.Size(346, 62);
			this.errorText.TabIndex = 5;
			this.errorText.Text = "Error text";
			// 
			// detailsButton
			// 
			this.detailsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.detailsButton.ImageIndex = 0;
			this.detailsButton.ImageList = this.imageList1;
			this.detailsButton.Location = new System.Drawing.Point(12, 98);
			this.detailsButton.Name = "detailsButton";
			this.detailsButton.Size = new System.Drawing.Size(75, 23);
			this.detailsButton.TabIndex = 6;
			this.detailsButton.Text = "Details";
			this.detailsButton.UseVisualStyleBackColor = true;
			this.detailsButton.Visible = false;
			this.detailsButton.Click += new System.EventHandler(this.detailsButton_Click);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "arrowdown.png");
			this.imageList1.Images.SetKeyName(1, "arrowup.png");
			// 
			// continueButton
			// 
			this.continueButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.continueButton.Location = new System.Drawing.Point(279, 98);
			this.continueButton.Name = "continueButton";
			this.continueButton.Size = new System.Drawing.Size(75, 23);
			this.continueButton.TabIndex = 7;
			this.continueButton.Text = "Continue";
			this.continueButton.UseVisualStyleBackColor = true;
			this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
			// 
			// ErrorForm
			// 
			this.AcceptButton = this.continueButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.quitButton;
			this.ClientSize = new System.Drawing.Size(447, 129);
			this.Controls.Add(this.continueButton);
			this.Controls.Add(this.detailsButton);
			this.Controls.Add(this.errorText);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.errorDetails);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.quitButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ErrorForm";
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Error";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button quitButton;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox errorDetails;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label errorText;
		private System.Windows.Forms.Button detailsButton;
		private System.Windows.Forms.Button continueButton;
		private System.Windows.Forms.ImageList imageList1;
	}
}