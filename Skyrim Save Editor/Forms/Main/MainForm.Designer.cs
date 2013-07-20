using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Skyrim_Save_Editor.Forms.Main {
	partial class MainForm {
		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "test",
            "test",
            "test",
            "test"}, -1);
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.newMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.recentFilesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.undoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.redoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.filePropertiesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.settingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.newToolButton = new System.Windows.Forms.ToolStripButton();
			this.openToolButton = new System.Windows.Forms.ToolStripButton();
			this.saveToolButton = new System.Windows.Forms.ToolStripButton();
			this.closeToolButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.undoToolButton = new System.Windows.Forms.ToolStripButton();
			this.redoToolButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.settingsToolButton = new System.Windows.Forms.ToolStripButton();
			this.aboutToolButton = new System.Windows.Forms.ToolStripButton();
			this.treeImageList = new System.Windows.Forms.ImageList(this.components);
			this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
			this.typeImageList = new System.Windows.Forms.ImageList(this.components);
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.advancedFilterClear = new System.Windows.Forms.Button();
			this.advancedFilter = new System.Windows.Forms.TextBox();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.treeListView = new BrightIdeasSoftware.TreeListView();
			this.treeColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.fieldListView = new BrightIdeasSoftware.ObjectListView();
			this.typeImageColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.typeColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.keyColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.valueColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.pluginsTab = new System.Windows.Forms.TabPage();
			this.pluginsList = new System.Windows.Forms.CheckedListBox();
			this.generalTab = new System.Windows.Forms.TabPage();
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.labelScreenshot = new System.Windows.Forms.Label();
			this.saveName = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.ingameDate = new System.Windows.Forms.MaskedTextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.saveTime = new System.Windows.Forms.DateTimePicker();
			this.screenshot = new System.Windows.Forms.PictureBox();
			this.leftPanel = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.rightPanel = new System.Windows.Forms.Panel();
			this.maleSex = new System.Windows.Forms.RadioButton();
			this.playerName = new System.Windows.Forms.TextBox();
			this.femaleSex = new System.Windows.Forms.RadioButton();
			this.playerRace = new System.Windows.Forms.ComboBox();
			this.playerLevel = new System.Windows.Forms.NumericUpDown();
			this.playerExperienceBar = new System.Windows.Forms.ProgressBar();
			this.playerExperienceBox = new System.Windows.Forms.NumericUpDown();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.menuStrip.SuspendLayout();
			this.toolStrip.SuspendLayout();
			this.contextMenuStrip.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.treeListView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fieldListView)).BeginInit();
			this.pluginsTab.SuspendLayout();
			this.generalTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.screenshot)).BeginInit();
			this.leftPanel.SuspendLayout();
			this.rightPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.playerLevel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.playerExperienceBox)).BeginInit();
			this.tabControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editToolStripMenuItem,
            this.toolsMenu,
            this.helpMenu});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(666, 24);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "menuStrip1";
			// 
			// fileMenu
			// 
			this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMenuItem,
            this.openMenuItem,
            this.saveMenuItem,
            this.saveAsMenuItem,
            this.closeMenuItem,
            this.toolStripMenuItem2,
            this.recentFilesMenuItem,
            this.toolStripMenuItem1,
            this.exitMenuItem});
			this.fileMenu.Name = "fileMenu";
			this.fileMenu.Size = new System.Drawing.Size(37, 20);
			this.fileMenu.Text = "&File";
			// 
			// newMenuItem
			// 
			this.newMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newMenuItem.Image")));
			this.newMenuItem.Name = "newMenuItem";
			this.newMenuItem.ShortcutKeyDisplayString = "Ctrl+N";
			this.newMenuItem.Size = new System.Drawing.Size(193, 22);
			this.newMenuItem.Text = "&New";
			this.newMenuItem.Click += new System.EventHandler(this.createSave);
			// 
			// openMenuItem
			// 
			this.openMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openMenuItem.Image")));
			this.openMenuItem.Name = "openMenuItem";
			this.openMenuItem.ShortcutKeyDisplayString = "Ctrl+O";
			this.openMenuItem.Size = new System.Drawing.Size(193, 22);
			this.openMenuItem.Text = "&Open";
			this.openMenuItem.Click += new System.EventHandler(this.openSave);
			// 
			// saveMenuItem
			// 
			this.saveMenuItem.Enabled = false;
			this.saveMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveMenuItem.Image")));
			this.saveMenuItem.Name = "saveMenuItem";
			this.saveMenuItem.ShortcutKeyDisplayString = "Ctrl+S";
			this.saveMenuItem.Size = new System.Drawing.Size(193, 22);
			this.saveMenuItem.Text = "&Save";
			// 
			// saveAsMenuItem
			// 
			this.saveAsMenuItem.Enabled = false;
			this.saveAsMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveAsMenuItem.Image")));
			this.saveAsMenuItem.Name = "saveAsMenuItem";
			this.saveAsMenuItem.ShortcutKeyDisplayString = "Ctrl+Shift+S";
			this.saveAsMenuItem.Size = new System.Drawing.Size(193, 22);
			this.saveAsMenuItem.Text = "Save as...";
			// 
			// closeMenuItem
			// 
			this.closeMenuItem.Enabled = false;
			this.closeMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("closeMenuItem.Image")));
			this.closeMenuItem.Name = "closeMenuItem";
			this.closeMenuItem.ShortcutKeyDisplayString = "Ctrl+W";
			this.closeMenuItem.Size = new System.Drawing.Size(193, 22);
			this.closeMenuItem.Text = "&Close";
			this.closeMenuItem.Click += new System.EventHandler(this.closeSave);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(190, 6);
			// 
			// recentFilesMenuItem
			// 
			this.recentFilesMenuItem.Name = "recentFilesMenuItem";
			this.recentFilesMenuItem.Size = new System.Drawing.Size(193, 22);
			this.recentFilesMenuItem.Text = "&Recent Files";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(190, 6);
			// 
			// exitMenuItem
			// 
			this.exitMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitMenuItem.Image")));
			this.exitMenuItem.Name = "exitMenuItem";
			this.exitMenuItem.ShortcutKeyDisplayString = "Alt+F4";
			this.exitMenuItem.Size = new System.Drawing.Size(193, 22);
			this.exitMenuItem.Text = "E&xit";
			this.exitMenuItem.Click += new System.EventHandler(this.closeForm);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoMenuItem,
            this.redoMenuItem,
            this.toolStripMenuItem3,
            this.filePropertiesMenuItem});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// undoMenuItem
			// 
			this.undoMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("undoMenuItem.Image")));
			this.undoMenuItem.Name = "undoMenuItem";
			this.undoMenuItem.ShortcutKeyDisplayString = "Ctrl+Z";
			this.undoMenuItem.Size = new System.Drawing.Size(148, 22);
			this.undoMenuItem.Text = "&Undo";
			// 
			// redoMenuItem
			// 
			this.redoMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("redoMenuItem.Image")));
			this.redoMenuItem.Name = "redoMenuItem";
			this.redoMenuItem.ShortcutKeyDisplayString = "Ctrl+Y";
			this.redoMenuItem.Size = new System.Drawing.Size(148, 22);
			this.redoMenuItem.Text = "&Redo";
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(145, 6);
			// 
			// filePropertiesMenuItem
			// 
			this.filePropertiesMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("filePropertiesMenuItem.Image")));
			this.filePropertiesMenuItem.Name = "filePropertiesMenuItem";
			this.filePropertiesMenuItem.Size = new System.Drawing.Size(148, 22);
			this.filePropertiesMenuItem.Text = "File Properties";
			// 
			// toolsMenu
			// 
			this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsMenuItem});
			this.toolsMenu.Name = "toolsMenu";
			this.toolsMenu.Size = new System.Drawing.Size(48, 20);
			this.toolsMenu.Text = "Tools";
			// 
			// settingsMenuItem
			// 
			this.settingsMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("settingsMenuItem.Image")));
			this.settingsMenuItem.Name = "settingsMenuItem";
			this.settingsMenuItem.ShortcutKeyDisplayString = "Ctrl+P";
			this.settingsMenuItem.Size = new System.Drawing.Size(157, 22);
			this.settingsMenuItem.Text = "&Settings";
			this.settingsMenuItem.Click += new System.EventHandler(this.showSettingsForm);
			// 
			// helpMenu
			// 
			this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenuItem});
			this.helpMenu.Name = "helpMenu";
			this.helpMenu.Size = new System.Drawing.Size(44, 20);
			this.helpMenu.Text = "Help";
			// 
			// aboutMenuItem
			// 
			this.aboutMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutMenuItem.Image")));
			this.aboutMenuItem.Name = "aboutMenuItem";
			this.aboutMenuItem.Size = new System.Drawing.Size(107, 22);
			this.aboutMenuItem.Text = "About";
			this.aboutMenuItem.Click += new System.EventHandler(this.showAboutForm);
			// 
			// openFileDialog
			// 
			this.openFileDialog.DefaultExt = "ess";
			this.openFileDialog.Filter = "Elder Scrolls Save File|*.ess|All Files|*.*";
			// 
			// toolStrip
			// 
			this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolButton,
            this.openToolButton,
            this.saveToolButton,
            this.closeToolButton,
            this.toolStripSeparator1,
            this.undoToolButton,
            this.redoToolButton,
            this.toolStripSeparator2,
            this.settingsToolButton,
            this.aboutToolButton});
			this.toolStrip.Location = new System.Drawing.Point(0, 24);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Padding = new System.Windows.Forms.Padding(6, 0, 1, 0);
			this.toolStrip.Size = new System.Drawing.Size(666, 25);
			this.toolStrip.TabIndex = 2;
			this.toolStrip.Text = "toolStrip1";
			// 
			// newToolButton
			// 
			this.newToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.newToolButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolButton.Image")));
			this.newToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.newToolButton.Margin = new System.Windows.Forms.Padding(0, 1, 2, 2);
			this.newToolButton.Name = "newToolButton";
			this.newToolButton.Size = new System.Drawing.Size(23, 22);
			this.newToolButton.Text = "New";
			this.newToolButton.Click += new System.EventHandler(this.createSave);
			// 
			// openToolButton
			// 
			this.openToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.openToolButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolButton.Image")));
			this.openToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.openToolButton.Margin = new System.Windows.Forms.Padding(0, 1, 2, 2);
			this.openToolButton.Name = "openToolButton";
			this.openToolButton.Size = new System.Drawing.Size(23, 22);
			this.openToolButton.Text = "Open";
			this.openToolButton.Click += new System.EventHandler(this.openSave);
			// 
			// saveToolButton
			// 
			this.saveToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.saveToolButton.Enabled = false;
			this.saveToolButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolButton.Image")));
			this.saveToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.saveToolButton.Margin = new System.Windows.Forms.Padding(0, 1, 2, 2);
			this.saveToolButton.Name = "saveToolButton";
			this.saveToolButton.Size = new System.Drawing.Size(23, 22);
			this.saveToolButton.Text = "Save";
			// 
			// closeToolButton
			// 
			this.closeToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.closeToolButton.Enabled = false;
			this.closeToolButton.Image = ((System.Drawing.Image)(resources.GetObject("closeToolButton.Image")));
			this.closeToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.closeToolButton.Margin = new System.Windows.Forms.Padding(0, 1, 2, 2);
			this.closeToolButton.Name = "closeToolButton";
			this.closeToolButton.Size = new System.Drawing.Size(23, 22);
			this.closeToolButton.Text = "Close";
			this.closeToolButton.Click += new System.EventHandler(this.closeSave);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// undoToolButton
			// 
			this.undoToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.undoToolButton.Image = ((System.Drawing.Image)(resources.GetObject("undoToolButton.Image")));
			this.undoToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.undoToolButton.Name = "undoToolButton";
			this.undoToolButton.Size = new System.Drawing.Size(23, 22);
			this.undoToolButton.Text = "toolStripButtonUndo";
			// 
			// redoToolButton
			// 
			this.redoToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.redoToolButton.Image = ((System.Drawing.Image)(resources.GetObject("redoToolButton.Image")));
			this.redoToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.redoToolButton.Name = "redoToolButton";
			this.redoToolButton.Size = new System.Drawing.Size(23, 22);
			this.redoToolButton.Text = "toolStripButtonRedo";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// settingsToolButton
			// 
			this.settingsToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.settingsToolButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsToolButton.Image")));
			this.settingsToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.settingsToolButton.Margin = new System.Windows.Forms.Padding(0, 1, 2, 2);
			this.settingsToolButton.Name = "settingsToolButton";
			this.settingsToolButton.Size = new System.Drawing.Size(23, 22);
			this.settingsToolButton.Text = "Settings";
			this.settingsToolButton.Click += new System.EventHandler(this.showSettingsForm);
			// 
			// aboutToolButton
			// 
			this.aboutToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.aboutToolButton.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolButton.Image")));
			this.aboutToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.aboutToolButton.Margin = new System.Windows.Forms.Padding(0, 1, 2, 2);
			this.aboutToolButton.Name = "aboutToolButton";
			this.aboutToolButton.Size = new System.Drawing.Size(23, 22);
			this.aboutToolButton.Text = "About";
			this.aboutToolButton.Click += new System.EventHandler(this.showAboutForm);
			// 
			// treeImageList
			// 
			this.treeImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("treeImageList.ImageStream")));
			this.treeImageList.TransparentColor = System.Drawing.Color.Transparent;
			this.treeImageList.Images.SetKeyName(0, "tree_red.png");
			this.treeImageList.Images.SetKeyName(1, "bricks.png");
			this.treeImageList.Images.SetKeyName(2, "scull.png");
			this.treeImageList.Images.SetKeyName(3, "tower.png");
			this.treeImageList.Images.SetKeyName(4, "toilet.png");
			this.treeImageList.Images.SetKeyName(5, "bow.png");
			this.treeImageList.Images.SetKeyName(6, "box_closed.png");
			this.treeImageList.Images.SetKeyName(7, "box_open.png");
			this.treeImageList.Images.SetKeyName(8, "brick.png");
			this.treeImageList.Images.SetKeyName(9, "brick_go.png");
			// 
			// olvColumn4
			// 
			this.olvColumn4.AspectName = "Description";
			this.olvColumn4.DisplayIndex = 4;
			this.olvColumn4.FillsFreeSpace = true;
			this.olvColumn4.IsEditable = false;
			this.olvColumn4.IsVisible = false;
			this.olvColumn4.Sortable = false;
			this.olvColumn4.Text = "Description";
			this.olvColumn4.Width = 440;
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4});
			this.contextMenuStrip.Name = "contextMenuStrip1";
			this.contextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.contextMenuStrip.Size = new System.Drawing.Size(95, 26);
			this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
			this.contextMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip_ItemClicked);
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(94, 22);
			this.toolStripMenuItem4.Text = "Edit";
			// 
			// typeImageList
			// 
			this.typeImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("typeImageList.ImageStream")));
			this.typeImageList.TransparentColor = System.Drawing.Color.Transparent;
			this.typeImageList.Images.SetKeyName(0, "String");
			this.typeImageList.Images.SetKeyName(1, "Image");
			this.typeImageList.Images.SetKeyName(2, "Int");
			this.typeImageList.Images.SetKeyName(3, "radiobutton_group.png");
			this.typeImageList.Images.SetKeyName(4, "DateTime");
			this.typeImageList.Images.SetKeyName(5, "Single");
			this.typeImageList.Images.SetKeyName(6, "Unknown");
			this.typeImageList.Images.SetKeyName(7, "RefID");
			this.typeImageList.Images.SetKeyName(8, "Byte");
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.advancedFilterClear);
			this.tabPage1.Controls.Add(this.advancedFilter);
			this.tabPage1.Controls.Add(this.splitContainer1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(658, 285);
			this.tabPage1.TabIndex = 3;
			this.tabPage1.Text = "Advanced";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// advancedFilterClear
			// 
			this.advancedFilterClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.advancedFilterClear.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.advancedFilterClear.Enabled = false;
			this.advancedFilterClear.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
			this.advancedFilterClear.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
			this.advancedFilterClear.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.advancedFilterClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.advancedFilterClear.Image = ((System.Drawing.Image)(resources.GetObject("advancedFilterClear.Image")));
			this.advancedFilterClear.Location = new System.Drawing.Point(635, 3);
			this.advancedFilterClear.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
			this.advancedFilterClear.Name = "advancedFilterClear";
			this.advancedFilterClear.Size = new System.Drawing.Size(20, 20);
			this.advancedFilterClear.TabIndex = 8;
			this.advancedFilterClear.UseVisualStyleBackColor = false;
			this.advancedFilterClear.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonAdvancedClear_Click);
			// 
			// advancedFilter
			// 
			this.advancedFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.advancedFilter.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.advancedFilter.Location = new System.Drawing.Point(3, 3);
			this.advancedFilter.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
			this.advancedFilter.Name = "advancedFilter";
			this.advancedFilter.Size = new System.Drawing.Size(633, 20);
			this.advancedFilter.TabIndex = 7;
			this.advancedFilter.Text = "Filter...";
			this.advancedFilter.Enter += new System.EventHandler(this.advancedFilter_Enter);
			this.advancedFilter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.advancedFilter_KeyUp);
			this.advancedFilter.Leave += new System.EventHandler(this.advancedFilter_Leave);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer1.Location = new System.Drawing.Point(3, 29);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.treeListView);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.fieldListView);
			this.splitContainer1.Panel2.Controls.Add(this.listView1);
			this.splitContainer1.Size = new System.Drawing.Size(652, 253);
			this.splitContainer1.SplitterDistance = 175;
			this.splitContainer1.TabIndex = 6;
			// 
			// treeListView
			// 
			this.treeListView.Activation = System.Windows.Forms.ItemActivation.TwoClick;
			this.treeListView.AllColumns.Add(this.treeColumn);
			this.treeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.treeColumn});
			this.treeListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeListView.Location = new System.Drawing.Point(0, 0);
			this.treeListView.Name = "treeListView";
			this.treeListView.OwnerDraw = true;
			this.treeListView.ShowGroups = false;
			this.treeListView.Size = new System.Drawing.Size(175, 253);
			this.treeListView.SmallImageList = this.treeImageList;
			this.treeListView.TabIndex = 0;
			this.treeListView.UseCompatibleStateImageBehavior = false;
			this.treeListView.View = System.Windows.Forms.View.Details;
			this.treeListView.VirtualMode = true;
			this.treeListView.SelectedIndexChanged += new System.EventHandler(this.treeListView_SelectedIndexChanged);
			// 
			// treeColumn
			// 
			this.treeColumn.AspectName = "blockName";
			this.treeColumn.FillsFreeSpace = true;
			this.treeColumn.Groupable = false;
			this.treeColumn.Hideable = false;
			this.treeColumn.IsEditable = false;
			this.treeColumn.IsVisible = false;
			this.treeColumn.Searchable = false;
			this.treeColumn.ShowTextInHeader = false;
			this.treeColumn.Sortable = false;
			this.treeColumn.Text = "";
			// 
			// fieldListView
			// 
			this.fieldListView.AllColumns.Add(this.typeImageColumn);
			this.fieldListView.AllColumns.Add(this.typeColumn);
			this.fieldListView.AllColumns.Add(this.keyColumn);
			this.fieldListView.AllColumns.Add(this.valueColumn);
			this.fieldListView.AllColumns.Add(this.olvColumn4);
			this.fieldListView.AllowColumnReorder = true;
			this.fieldListView.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
			this.fieldListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.typeImageColumn,
            this.typeColumn,
            this.keyColumn,
            this.valueColumn});
			this.fieldListView.ContextMenuStrip = this.contextMenuStrip;
			this.fieldListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fieldListView.FullRowSelect = true;
			this.fieldListView.Location = new System.Drawing.Point(0, 0);
			this.fieldListView.Name = "fieldListView";
			this.fieldListView.RowHeight = 20;
			this.fieldListView.ShowGroups = false;
			this.fieldListView.Size = new System.Drawing.Size(473, 253);
			this.fieldListView.SmallImageList = this.typeImageList;
			this.fieldListView.TabIndex = 7;
			this.fieldListView.UseCompatibleStateImageBehavior = false;
			this.fieldListView.View = System.Windows.Forms.View.Details;
			// 
			// typeImageColumn
			// 
			this.typeImageColumn.Hideable = false;
			this.typeImageColumn.IsEditable = false;
			this.typeImageColumn.MaximumWidth = 20;
			this.typeImageColumn.MinimumWidth = 20;
			this.typeImageColumn.Searchable = false;
			this.typeImageColumn.ShowTextInHeader = false;
			this.typeImageColumn.Text = "";
			this.typeImageColumn.UseFiltering = false;
			this.typeImageColumn.Width = 20;
			// 
			// typeColumn
			// 
			this.typeColumn.AspectName = "Type";
			this.typeColumn.IsEditable = false;
			this.typeColumn.Text = "Type";
			this.typeColumn.Width = 81;
			// 
			// keyColumn
			// 
			this.keyColumn.AspectName = "Key";
			this.keyColumn.Hideable = false;
			this.keyColumn.IsEditable = false;
			this.keyColumn.Text = "Key";
			this.keyColumn.Width = 113;
			// 
			// valueColumn
			// 
			this.valueColumn.AspectName = "Value";
			this.valueColumn.FillsFreeSpace = true;
			this.valueColumn.Hideable = false;
			this.valueColumn.Sortable = false;
			this.valueColumn.Text = "Value";
			this.valueColumn.Width = 149;
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
			this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
			this.listView1.Location = new System.Drawing.Point(0, 0);
			this.listView1.Name = "listView1";
			this.listView1.ShowGroups = false;
			this.listView1.Size = new System.Drawing.Size(473, 253);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Key";
			this.columnHeader1.Width = 110;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Type";
			this.columnHeader2.Width = 41;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Value";
			this.columnHeader3.Width = 80;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Description";
			this.columnHeader4.Width = 206;
			// 
			// pluginsTab
			// 
			this.pluginsTab.Controls.Add(this.pluginsList);
			this.pluginsTab.Location = new System.Drawing.Point(4, 22);
			this.pluginsTab.Name = "pluginsTab";
			this.pluginsTab.Padding = new System.Windows.Forms.Padding(3);
			this.pluginsTab.Size = new System.Drawing.Size(658, 285);
			this.pluginsTab.TabIndex = 1;
			this.pluginsTab.Text = "Plugins";
			this.pluginsTab.UseVisualStyleBackColor = true;
			// 
			// pluginsList
			// 
			this.pluginsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pluginsList.CheckOnClick = true;
			this.pluginsList.FormattingEnabled = true;
			this.pluginsList.Location = new System.Drawing.Point(3, 4);
			this.pluginsList.Name = "pluginsList";
			this.pluginsList.Size = new System.Drawing.Size(652, 274);
			this.pluginsList.TabIndex = 1;
			// 
			// generalTab
			// 
			this.generalTab.Controls.Add(this.splitContainer);
			this.generalTab.Location = new System.Drawing.Point(4, 22);
			this.generalTab.Name = "generalTab";
			this.generalTab.Size = new System.Drawing.Size(658, 285);
			this.generalTab.TabIndex = 0;
			this.generalTab.Text = "General";
			this.generalTab.UseVisualStyleBackColor = true;
			// 
			// splitContainer
			// 
			this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer.Location = new System.Drawing.Point(0, 0);
			this.splitContainer.Name = "splitContainer";
			// 
			// splitContainer.Panel1
			// 
			this.splitContainer.Panel1.Controls.Add(this.labelScreenshot);
			this.splitContainer.Panel1.Controls.Add(this.saveName);
			this.splitContainer.Panel1.Controls.Add(this.label8);
			this.splitContainer.Panel1.Controls.Add(this.label7);
			this.splitContainer.Panel1.Controls.Add(this.ingameDate);
			this.splitContainer.Panel1.Controls.Add(this.label6);
			this.splitContainer.Panel1.Controls.Add(this.saveTime);
			this.splitContainer.Panel1.Controls.Add(this.screenshot);
			this.splitContainer.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.splitContainer.Panel1MinSize = 327;
			// 
			// splitContainer.Panel2
			// 
			this.splitContainer.Panel2.Controls.Add(this.leftPanel);
			this.splitContainer.Panel2.Controls.Add(this.rightPanel);
			this.splitContainer.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.splitContainer.Panel2MinSize = 327;
			this.splitContainer.Size = new System.Drawing.Size(658, 285);
			this.splitContainer.SplitterDistance = 327;
			this.splitContainer.TabIndex = 5;
			this.splitContainer.TabStop = false;
			this.splitContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer_Paint);
			// 
			// labelScreenshot
			// 
			this.labelScreenshot.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelScreenshot.BackColor = System.Drawing.SystemColors.Control;
			this.labelScreenshot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelScreenshot.Location = new System.Drawing.Point(7, 9);
			this.labelScreenshot.Name = "labelScreenshot";
			this.labelScreenshot.Size = new System.Drawing.Size(310, 182);
			this.labelScreenshot.TabIndex = 7;
			this.labelScreenshot.Text = "Screenshot";
			this.labelScreenshot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// saveName
			// 
			this.saveName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.saveName.Location = new System.Drawing.Point(83, 202);
			this.saveName.Name = "saveName";
			this.saveName.ReadOnly = true;
			this.saveName.Size = new System.Drawing.Size(236, 20);
			this.saveName.TabIndex = 0;
			this.saveName.TabStop = false;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(3, 207);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(35, 13);
			this.label8.TabIndex = 5;
			this.label8.Text = "Save:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(3, 257);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(72, 13);
			this.label7.TabIndex = 4;
			this.label7.Text = "In-game date:";
			// 
			// ingameDate
			// 
			this.ingameDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ingameDate.Location = new System.Drawing.Point(83, 254);
			this.ingameDate.Mask = "000-00-00";
			this.ingameDate.Name = "ingameDate";
			this.ingameDate.Size = new System.Drawing.Size(236, 20);
			this.ingameDate.TabIndex = 2;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(3, 232);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(57, 13);
			this.label6.TabIndex = 2;
			this.label6.Text = "Save time:";
			// 
			// saveTime
			// 
			this.saveTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.saveTime.CustomFormat = "ddd, MMM dd, yyyy h:mmtt";
			this.saveTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.saveTime.Location = new System.Drawing.Point(83, 228);
			this.saveTime.Name = "saveTime";
			this.saveTime.Size = new System.Drawing.Size(236, 20);
			this.saveTime.TabIndex = 1;
			// 
			// screenshot
			// 
			this.screenshot.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.screenshot.BackColor = System.Drawing.SystemColors.Control;
			this.screenshot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.screenshot.Location = new System.Drawing.Point(2, 4);
			this.screenshot.Name = "screenshot";
			this.screenshot.Size = new System.Drawing.Size(320, 192);
			this.screenshot.TabIndex = 0;
			this.screenshot.TabStop = false;
			// 
			// leftPanel
			// 
			this.leftPanel.Controls.Add(this.label1);
			this.leftPanel.Controls.Add(this.label2);
			this.leftPanel.Controls.Add(this.label3);
			this.leftPanel.Controls.Add(this.label4);
			this.leftPanel.Controls.Add(this.label5);
			this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.leftPanel.Location = new System.Drawing.Point(0, 0);
			this.leftPanel.Name = "leftPanel";
			this.leftPanel.Size = new System.Drawing.Size(72, 285);
			this.leftPanel.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Name:";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 34);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(36, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Level:";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 61);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Experience:";
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 88);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(36, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Race:";
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(3, 114);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(28, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "Sex:";
			// 
			// rightPanel
			// 
			this.rightPanel.Controls.Add(this.maleSex);
			this.rightPanel.Controls.Add(this.playerName);
			this.rightPanel.Controls.Add(this.femaleSex);
			this.rightPanel.Controls.Add(this.playerRace);
			this.rightPanel.Controls.Add(this.playerLevel);
			this.rightPanel.Controls.Add(this.playerExperienceBar);
			this.rightPanel.Controls.Add(this.playerExperienceBox);
			this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rightPanel.Location = new System.Drawing.Point(0, 0);
			this.rightPanel.Name = "rightPanel";
			this.rightPanel.Size = new System.Drawing.Size(327, 285);
			this.rightPanel.TabIndex = 3;
			// 
			// maleSex
			// 
			this.maleSex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.maleSex.AutoSize = true;
			this.maleSex.Location = new System.Drawing.Point(78, 112);
			this.maleSex.Name = "maleSex";
			this.maleSex.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
			this.maleSex.Size = new System.Drawing.Size(68, 17);
			this.maleSex.TabIndex = 7;
			this.maleSex.TabStop = true;
			this.maleSex.Text = "Male";
			this.maleSex.UseVisualStyleBackColor = true;
			// 
			// playerName
			// 
			this.playerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.playerName.Location = new System.Drawing.Point(78, 6);
			this.playerName.Name = "playerName";
			this.playerName.Size = new System.Drawing.Size(244, 20);
			this.playerName.TabIndex = 3;
			this.playerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.playerName.TextChanged += new System.EventHandler(this.playerName_TextChanged);
			// 
			// femaleSex
			// 
			this.femaleSex.AutoSize = true;
			this.femaleSex.Location = new System.Drawing.Point(152, 112);
			this.femaleSex.Name = "femaleSex";
			this.femaleSex.Size = new System.Drawing.Size(59, 17);
			this.femaleSex.TabIndex = 7;
			this.femaleSex.TabStop = true;
			this.femaleSex.Text = "Female";
			this.femaleSex.UseVisualStyleBackColor = true;
			// 
			// playerRace
			// 
			this.playerRace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.playerRace.DisplayMember = "1";
			this.playerRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.playerRace.FormattingEnabled = true;
			this.playerRace.Items.AddRange(new object[] {
            "Altmer (High Elf)",
            "Argonian (Saxhleel)",
            "Bosmer (Wood Elf)",
            "Breton (Manmer)",
            "Dunmer (Dark Elf)",
            "Imperial (Cyrodiils)",
            "Khajiit",
            "Nord",
            "Orc (Orsimer)",
            "Redguard (Yokudans)"});
			this.playerRace.Location = new System.Drawing.Point(78, 85);
			this.playerRace.Name = "playerRace";
			this.playerRace.Size = new System.Drawing.Size(244, 21);
			this.playerRace.TabIndex = 6;
			this.playerRace.SelectedIndexChanged += new System.EventHandler(this.playerRace_SelectedIndexChanged);
			// 
			// playerLevel
			// 
			this.playerLevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.playerLevel.Location = new System.Drawing.Point(78, 32);
			this.playerLevel.Name = "playerLevel";
			this.playerLevel.Size = new System.Drawing.Size(244, 20);
			this.playerLevel.TabIndex = 4;
			this.playerLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.playerLevel.ValueChanged += new System.EventHandler(this.playerLevel_ValueChanged);
			// 
			// playerExperienceBar
			// 
			this.playerExperienceBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.playerExperienceBar.Location = new System.Drawing.Point(78, 60);
			this.playerExperienceBar.Name = "playerExperienceBar";
			this.playerExperienceBar.Size = new System.Drawing.Size(171, 17);
			this.playerExperienceBar.Step = 1;
			this.playerExperienceBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.playerExperienceBar.TabIndex = 6;
			// 
			// playerExperienceBox
			// 
			this.playerExperienceBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.playerExperienceBox.Location = new System.Drawing.Point(255, 59);
			this.playerExperienceBox.Name = "playerExperienceBox";
			this.playerExperienceBox.Size = new System.Drawing.Size(67, 20);
			this.playerExperienceBox.TabIndex = 5;
			this.playerExperienceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.playerExperienceBox.ValueChanged += new System.EventHandler(this.playerExperience_ValueChanged);
			// 
			// tabControl
			// 
			this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl.Controls.Add(this.generalTab);
			this.tabControl.Controls.Add(this.pluginsTab);
			this.tabControl.Controls.Add(this.tabPage1);
			this.tabControl.Location = new System.Drawing.Point(0, 52);
			this.tabControl.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(666, 311);
			this.tabControl.TabIndex = 0;
			this.tabControl.Visible = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(666, 362);
			this.Controls.Add(this.toolStrip);
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.menuStrip);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MainMenuStrip = this.menuStrip;
			this.MinimumSize = new System.Drawing.Size(682, 400);
			this.Name = "MainForm";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Text = "Skyrim Save Editor";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.contextMenuStrip.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.treeListView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fieldListView)).EndInit();
			this.pluginsTab.ResumeLayout(false);
			this.generalTab.ResumeLayout(false);
			this.splitContainer.Panel1.ResumeLayout(false);
			this.splitContainer.Panel1.PerformLayout();
			this.splitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
			this.splitContainer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.screenshot)).EndInit();
			this.leftPanel.ResumeLayout(false);
			this.leftPanel.PerformLayout();
			this.rightPanel.ResumeLayout(false);
			this.rightPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.playerLevel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.playerExperienceBox)).EndInit();
			this.tabControl.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		#region Windows Form Designer generated variables
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileMenu;
		private System.Windows.Forms.ToolStripMenuItem openMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
		private System.Windows.Forms.ToolStripMenuItem closeMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem newMenuItem;
		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.ToolStripButton newToolButton;
		private System.Windows.Forms.ToolStripButton openToolButton;
		private System.Windows.Forms.ToolStripButton saveToolButton;
		private System.Windows.Forms.ToolStripButton closeToolButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton settingsToolButton;
		private System.Windows.Forms.ToolStripButton aboutToolButton;
		private System.Windows.Forms.ToolStripMenuItem helpMenu;
		private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolsMenu;
		private System.Windows.Forms.ToolStripMenuItem settingsMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem recentFilesMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem undoMenuItem;
		private System.Windows.Forms.ToolStripMenuItem redoMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem filePropertiesMenuItem;
		private System.Windows.Forms.ToolStripButton undoToolButton;
		private System.Windows.Forms.ToolStripButton redoToolButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem saveAsMenuItem;
		private ImageList treeImageList;
		private BrightIdeasSoftware.OLVColumn olvColumn4;
		private ImageList typeImageList;
		#endregion

		private ContextMenuStrip contextMenuStrip;
		private ToolStripMenuItem toolStripMenuItem4;
		private TabPage tabPage1;
		private Button advancedFilterClear;
		private TextBox advancedFilter;
		private SplitContainer splitContainer1;
		private BrightIdeasSoftware.TreeListView treeListView;
		private BrightIdeasSoftware.OLVColumn treeColumn;
		private BrightIdeasSoftware.ObjectListView fieldListView;
		private BrightIdeasSoftware.OLVColumn typeImageColumn;
		private BrightIdeasSoftware.OLVColumn typeColumn;
		private BrightIdeasSoftware.OLVColumn keyColumn;
		private BrightIdeasSoftware.OLVColumn valueColumn;
		private ListView listView1;
		private ColumnHeader columnHeader1;
		private ColumnHeader columnHeader2;
		private ColumnHeader columnHeader3;
		private ColumnHeader columnHeader4;
		private TabPage pluginsTab;
		private CheckedListBox pluginsList;
		private TabPage generalTab;
		private SplitContainer splitContainer;
		private Label labelScreenshot;
		private TextBox saveName;
		private Label label8;
		private Label label7;
		private MaskedTextBox ingameDate;
		private Label label6;
		private DateTimePicker saveTime;
		private PictureBox screenshot;
		private Panel leftPanel;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Panel rightPanel;
		private RadioButton maleSex;
		private TextBox playerName;
		private RadioButton femaleSex;
		private ComboBox playerRace;
		private NumericUpDown playerLevel;
		private ProgressBar playerExperienceBar;
		private NumericUpDown playerExperienceBox;
		private TabControl tabControl;
	}
}

