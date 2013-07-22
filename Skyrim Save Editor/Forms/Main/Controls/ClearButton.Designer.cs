namespace Skyrim_Save_Editor.Forms.Main.Controls {
	partial class ClearButton {
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClearButton));
			this.clearButtonImageList = new System.Windows.Forms.ImageList(this.components);
			this.clearImage = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.clearImage)).BeginInit();
			this.SuspendLayout();
			// 
			// clearButtonImageList
			// 
			this.clearButtonImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("clearButtonImageList.ImageStream")));
			this.clearButtonImageList.TransparentColor = System.Drawing.Color.Transparent;
			this.clearButtonImageList.Images.SetKeyName(0, "cross8-disabled.png");
			this.clearButtonImageList.Images.SetKeyName(1, "cross8.png");
			this.clearButtonImageList.Images.SetKeyName(2, "cross8-over.png");
			this.clearButtonImageList.Images.SetKeyName(3, "cross8-down.png");
			// 
			// clearImage
			// 
			this.clearImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.clearImage.Location = new System.Drawing.Point(0, 0);
			this.clearImage.Name = "clearImage";
			this.clearImage.Size = new System.Drawing.Size(150, 150);
			this.clearImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.clearImage.TabIndex = 0;
			this.clearImage.TabStop = false;
			this.clearImage.Click += new System.EventHandler(this.clearImage_Click);
			this.clearImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.clearImage_MouseDown);
			this.clearImage.MouseEnter += new System.EventHandler(this.clearImage_MouseEnter);
			this.clearImage.MouseLeave += new System.EventHandler(this.clearImage_MouseLeave);
			this.clearImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.clearImage_MouseUp);
			// 
			// ClearButton
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.clearImage);
			this.Name = "ClearButton";
			((System.ComponentModel.ISupportInitialize)(this.clearImage)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ImageList clearButtonImageList;
		private System.Windows.Forms.PictureBox clearImage;
	}
}
