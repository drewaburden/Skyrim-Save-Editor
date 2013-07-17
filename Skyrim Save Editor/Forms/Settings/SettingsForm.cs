using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Resources;

namespace Skyrim_Save_Editor.Forms.Settings {
	/// <summary>
	/// Summary for SettingsForm
	/// </summary>
	public class SettingsForm : System.Windows.Forms.Form {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private IContainer components = null;

		public SettingsForm() {
			InitializeComponent();

			ResourceManager resourceManager = new ResourceManager("Skyrim_Save_Editor.Resources.Resource", Assembly.GetExecutingAssembly());
			localeStrings = new String[numLocales] { "English (USA)", "English (UK)", "Español", "Italia", "Deutsch", "русский", "日本語" };
			localeImages = new Image[numLocales] { 
				(System.Drawing.Image) (resourceManager.GetObject("USA")),
				(System.Drawing.Image) (resourceManager.GetObject("UK")),
				(System.Drawing.Image) (resourceManager.GetObject("Spain")),
				(System.Drawing.Image) (resourceManager.GetObject("Italy")),
				(System.Drawing.Image) (resourceManager.GetObject("Germany")),
				(System.Drawing.Image) (resourceManager.GetObject("Russia")),
				(System.Drawing.Image) (resourceManager.GetObject("Japan"))
			};

			for (int index = 0; index < numLocales; ++index) {
				this.languageWithImages.Items.Add(new LocaleComboBoxItem(
					(String) localeStrings[index].Clone(),
					(Image) localeImages[index].Clone()));
			}

			this.timeZone.SelectedIndex = 1;
			this.languageWithImages.SelectedIndex = 0;
			this.language.SelectedIndex = 0;

			this.buttonApply.Enabled = false; // Do this after loading current settings
		}

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


		private System.Windows.Forms.Button buttonApply;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonOK;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox timeZone;
		private System.Windows.Forms.ComboBox language;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label9;
		private PictureBox pictureBox3;
		private System.Windows.Forms.Label label10;
		private LocaleComboBox languageWithImages;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.CheckBox advancedMode;

		String[] localeStrings;
		Image[] localeImages;
		const int numLocales = 7;


		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.buttonApply = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonOK = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.label5 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.timeZone = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.advancedMode = new System.Windows.Forms.CheckBox();
			this.language = new System.Windows.Forms.ComboBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.languageWithImages = new Skyrim_Save_Editor.Forms.Settings.LocaleComboBox(this.components);
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "monitor.png");
			this.imageList1.Images.SetKeyName(1, "pencil.png");
			// 
			// buttonApply
			// 
			this.buttonApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonApply.Enabled = false;
			this.buttonApply.Location = new System.Drawing.Point(230, 357);
			this.buttonApply.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this.buttonApply.Name = "buttonApply";
			this.buttonApply.Size = new System.Drawing.Size(75, 23);
			this.buttonApply.TabIndex = 5;
			this.buttonApply.Text = "Apply";
			this.buttonApply.UseVisualStyleBackColor = true;
			this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(149, 357);
			this.buttonCancel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 4;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// buttonOK
			// 
			this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new System.Drawing.Point(68, 357);
			this.buttonOK.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 3;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.ImageList = this.imageList1;
			this.tabControl1.Location = new System.Drawing.Point(7, 7);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(302, 344);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this.label9);
			this.tabPage1.Controls.Add(this.pictureBox3);
			this.tabPage1.Controls.Add(this.label10);
			this.tabPage1.Controls.Add(this.label11);
			this.tabPage1.Controls.Add(this.label6);
			this.tabPage1.Controls.Add(this.pictureBox2);
			this.tabPage1.Controls.Add(this.label7);
			this.tabPage1.Controls.Add(this.label8);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.pictureBox1);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.timeZone);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.advancedMode);
			this.tabPage1.Controls.Add(this.languageWithImages);
			this.tabPage1.Controls.Add(this.language);
			this.tabPage1.ImageIndex = 0;
			this.tabPage1.Location = new System.Drawing.Point(4, 23);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(6);
			this.tabPage1.Size = new System.Drawing.Size(294, 317);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Display";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(56, 66);
			this.label5.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(58, 13);
			this.label5.TabIndex = 17;
			this.label5.Text = "Language:";
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label9.Location = new System.Drawing.Point(56, 28);
			this.label9.Name = "label9";
			this.label9.Padding = new System.Windows.Forms.Padding(3, 3, 0, 0);
			this.label9.Size = new System.Drawing.Size(226, 32);
			this.label9.TabIndex = 16;
			this.label9.Text = "Select your preferred language. This will also change the editor\'s date and time " +
    "formats.";
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(18, 28);
			this.pictureBox3.Margin = new System.Windows.Forms.Padding(12, 3, 3, 3);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(32, 32);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 15;
			this.pictureBox3.TabStop = false;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(9, 9);
			this.label10.Margin = new System.Windows.Forms.Padding(3);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(63, 13);
			this.label10.TabIndex = 14;
			this.label10.Text = "Localization";
			// 
			// label11
			// 
			this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label11.Location = new System.Drawing.Point(9, 17);
			this.label11.Margin = new System.Windows.Forms.Padding(0, 6, 6, 6);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(273, 2);
			this.label11.TabIndex = 13;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.Location = new System.Drawing.Point(53, 200);
			this.label6.Name = "label6";
			this.label6.Padding = new System.Windows.Forms.Padding(3, 3, 0, 0);
			this.label6.Size = new System.Drawing.Size(226, 47);
			this.label6.TabIndex = 11;
			this.label6.Text = "Expose an Advanced tab in the main window that displays all save file data in key" +
    "-value pairs.";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(15, 200);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(12, 3, 3, 3);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(32, 32);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 10;
			this.pictureBox2.TabStop = false;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 181);
			this.label7.Margin = new System.Windows.Forms.Padding(3);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(56, 13);
			this.label7.TabIndex = 9;
			this.label7.Text = "Advanced";
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label8.Location = new System.Drawing.Point(6, 189);
			this.label8.Margin = new System.Windows.Forms.Padding(0, 16, 6, 6);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(273, 2);
			this.label8.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(53, 152);
			this.label4.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(59, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Time zone:";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.Location = new System.Drawing.Point(53, 114);
			this.label3.Name = "label3";
			this.label3.Padding = new System.Windows.Forms.Padding(3, 3, 0, 0);
			this.label3.Size = new System.Drawing.Size(226, 32);
			this.label3.TabIndex = 5;
			this.label3.Text = "Select how you would like to have dates and times displayed to you.";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(15, 114);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(12, 3, 3, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(32, 32);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 95);
			this.label2.Margin = new System.Windows.Forms.Padding(3);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Dates and times";
			// 
			// timeZone
			// 
			this.timeZone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.timeZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.timeZone.FormattingEnabled = true;
			this.timeZone.Items.AddRange(new object[] {
            "UTC+0",
            "Local time"});
			this.timeZone.Location = new System.Drawing.Point(121, 149);
			this.timeZone.Name = "timeZone";
			this.timeZone.Size = new System.Drawing.Size(158, 21);
			this.timeZone.TabIndex = 1;
			this.timeZone.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Location = new System.Drawing.Point(6, 103);
			this.label1.Margin = new System.Windows.Forms.Padding(0, 16, 6, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(273, 2);
			this.label1.TabIndex = 1;
			// 
			// advancedMode
			// 
			this.advancedMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.advancedMode.Location = new System.Drawing.Point(56, 252);
			this.advancedMode.Name = "advancedMode";
			this.advancedMode.Size = new System.Drawing.Size(223, 17);
			this.advancedMode.TabIndex = 2;
			this.advancedMode.Text = "Enable Advanced Mode";
			this.advancedMode.UseVisualStyleBackColor = true;
			this.advancedMode.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// language
			// 
			this.language.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.language.FormattingEnabled = true;
			this.language.IntegralHeight = false;
			this.language.Items.AddRange(new object[] {
            "English (USA)",
            "English (UK)",
            "Español",
            "Italia",
            "Deutsch",
            "русский",
            "日本語"});
			this.language.Location = new System.Drawing.Point(124, 63);
			this.language.Name = "language";
			this.language.Size = new System.Drawing.Size(158, 21);
			this.language.TabIndex = 18;
			this.language.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
			// 
			// tabPage2
			// 
			this.tabPage2.ImageIndex = 1;
			this.tabPage2.Location = new System.Drawing.Point(4, 23);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(294, 334);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Editing";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// languageWithImages
			// 
			this.languageWithImages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.languageWithImages.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.languageWithImages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.languageWithImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.languageWithImages.FormattingEnabled = true;
			this.languageWithImages.Location = new System.Drawing.Point(124, 63);
			this.languageWithImages.Name = "languageWithImages";
			this.languageWithImages.Size = new System.Drawing.Size(158, 21);
			this.languageWithImages.TabIndex = 12;
			this.languageWithImages.Visible = false;
			this.languageWithImages.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
			// 
			// SettingsForm
			// 
			this.AcceptButton = this.buttonOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(314, 389);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonApply);
			this.HelpButton = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(330, 400);
			this.Name = "SettingsForm";
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Settings";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
		private void buttonOK_Click(System.Object sender, System.EventArgs e) {
			this.Close();
		}
		private void comboBox1_SelectedIndexChanged(System.Object sender, System.EventArgs e) {
			buttonApply.Enabled = true;
		}
		private void checkBox1_CheckedChanged(System.Object sender, System.EventArgs e) {
			buttonApply.Enabled = true;
		}
		private void buttonApply_Click(System.Object sender, System.EventArgs e) {
			buttonApply.Enabled = false;
		}
		private void comboBox3_SelectedIndexChanged(object sender, EventArgs e) {
			buttonApply.Enabled = true;
		}
		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) {
			buttonApply.Enabled = true;
		}
	}

}
