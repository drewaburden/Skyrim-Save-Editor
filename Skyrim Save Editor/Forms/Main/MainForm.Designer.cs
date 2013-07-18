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
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		#region Variables
		private ArrayList listViewItems;
		private ArrayList removedListViewItems;

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
		private System.Windows.Forms.TabPage pluginsTab;
		private System.Windows.Forms.CheckedListBox pluginsList;
		private System.Windows.Forms.TabPage generalTab;
		private System.Windows.Forms.SplitContainer splitContainer;
		private System.Windows.Forms.Label labelScreenshot;
		private System.Windows.Forms.TextBox saveName;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.MaskedTextBox ingameDate;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker saveTime;
		private System.Windows.Forms.PictureBox screenshot;
		private System.Windows.Forms.Panel leftPanel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel rightPanel;
		private System.Windows.Forms.RadioButton maleSex;
		private System.Windows.Forms.TextBox playerName;
		private System.Windows.Forms.RadioButton femaleSex;
		private System.Windows.Forms.ComboBox playerRace;
		private System.Windows.Forms.NumericUpDown playerLevel;
		private System.Windows.Forms.ProgressBar playerExperienceBar;
		private System.Windows.Forms.NumericUpDown playerExperienceBox;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage advancedTab;
		private System.Windows.Forms.ListView advancedKeyValues;
		private System.Windows.Forms.TextBox advancedFilter;
		private System.Windows.Forms.Button advancedFilterClear;
		private System.Windows.Forms.ColumnHeader advancedKeyHeader;
		private System.Windows.Forms.ColumnHeader advancedValueHeader;
		private System.Windows.Forms.ToolStripButton undoToolButton;
		private System.Windows.Forms.ToolStripButton redoToolButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem saveAsMenuItem;
		#endregion

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			System.Windows.Forms.ListViewGroup listViewGroup36 = new System.Windows.Forms.ListViewGroup("Header", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup37 = new System.Windows.Forms.ListViewGroup("Save Information", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup38 = new System.Windows.Forms.ListViewGroup("Plugin Info", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup39 = new System.Windows.Forms.ListViewGroup("File Location Table", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup40 = new System.Windows.Forms.ListViewGroup("Misc Stats (0)", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup41 = new System.Windows.Forms.ListViewGroup("Player Location (1)", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup42 = new System.Windows.Forms.ListViewGroup("TES (2)", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup43 = new System.Windows.Forms.ListViewGroup("Global Variables (3)", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup44 = new System.Windows.Forms.ListViewGroup("Created Objects (4)", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup45 = new System.Windows.Forms.ListViewGroup("Effects (5)", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup46 = new System.Windows.Forms.ListViewGroup("Weather (6)", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup47 = new System.Windows.Forms.ListViewGroup("Audio (7)", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup48 = new System.Windows.Forms.ListViewGroup("Sky Cells (8)", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup49 = new System.Windows.Forms.ListViewGroup("Process Lists (100)", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup50 = new System.Windows.Forms.ListViewGroup("Combat (101)", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup51 = new System.Windows.Forms.ListViewGroup("Interface (102)", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup52 = new System.Windows.Forms.ListViewGroup("Actor Causes (103)", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup53 = new System.Windows.Forms.ListViewGroup("Unknown (104)", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup54 = new System.Windows.Forms.ListViewGroup("Detection Manager (105)", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup55 = new System.Windows.Forms.ListViewGroup("Location MetaData (106)", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup56 = new System.Windows.Forms.ListViewGroup("Quest Static Data (107)", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup57 = new System.Windows.Forms.ListViewGroup("StoryTeller (108)", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup58 = new System.Windows.Forms.ListViewGroup("Magic Favorites (109)", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup59 = new System.Windows.Forms.ListViewGroup("PlayerControls (110)", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup60 = new System.Windows.Forms.ListViewGroup("Story Event Manager (111)", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup61 = new System.Windows.Forms.ListViewGroup("Ingredient Shared (112)", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup62 = new System.Windows.Forms.ListViewGroup("MenuControls (113)", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup63 = new System.Windows.Forms.ListViewGroup("MenuTopicManager (114)", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup64 = new System.Windows.Forms.ListViewGroup("Temp Effects (1000)", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup65 = new System.Windows.Forms.ListViewGroup("Papyrus (1001)", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup66 = new System.Windows.Forms.ListViewGroup("Anim Objects (1002)", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup67 = new System.Windows.Forms.ListViewGroup("Timer (1003)", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup68 = new System.Windows.Forms.ListViewGroup("Synchronized Animations (1004)", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup69 = new System.Windows.Forms.ListViewGroup("Main (1005)", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup70 = new System.Windows.Forms.ListViewGroup("Change Form", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Node4");
			System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Node5");
			System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Node6", 8, 9);
			System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Header", new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13,
            treeNode14});
			System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("File Properties");
			System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Plugin Info");
			System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("File Location Table");
			System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Node3");
			System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Misc Stats", new System.Windows.Forms.TreeNode[] {
            treeNode19});
			System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Player Location");
			System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Save File", new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode20,
            treeNode21});
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
			this.advancedTab = new System.Windows.Forms.TabPage();
			this.advancedKeyValues = new System.Windows.Forms.ListView();
			this.advancedKeyHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.advancedValueHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.advancedFilterClear = new System.Windows.Forms.Button();
			this.advancedFilter = new System.Windows.Forms.TextBox();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.objectListView1 = new BrightIdeasSoftware.ObjectListView();
			this.typeColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.imageList2 = new System.Windows.Forms.ImageList(this.components);
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.menuStrip.SuspendLayout();
			this.toolStrip.SuspendLayout();
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
			this.advancedTab.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
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
			this.settingsMenuItem.Click += new System.EventHandler(this.openSettings);
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
			this.settingsToolButton.Click += new System.EventHandler(this.openSettings);
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
			this.ingameDate.Mask = "###.##.##";
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
			this.tabControl.Controls.Add(this.advancedTab);
			this.tabControl.Controls.Add(this.tabPage1);
			this.tabControl.Location = new System.Drawing.Point(0, 52);
			this.tabControl.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(666, 311);
			this.tabControl.TabIndex = 0;
			this.tabControl.Visible = false;
			// 
			// advancedTab
			// 
			this.advancedTab.Controls.Add(this.advancedKeyValues);
			this.advancedTab.Controls.Add(this.advancedFilterClear);
			this.advancedTab.Controls.Add(this.advancedFilter);
			this.advancedTab.Location = new System.Drawing.Point(4, 22);
			this.advancedTab.Name = "advancedTab";
			this.advancedTab.Padding = new System.Windows.Forms.Padding(3);
			this.advancedTab.Size = new System.Drawing.Size(658, 285);
			this.advancedTab.TabIndex = 2;
			this.advancedTab.Text = "Advaned";
			this.advancedTab.UseVisualStyleBackColor = true;
			// 
			// advancedKeyValues
			// 
			this.advancedKeyValues.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.advancedKeyValues.BackColor = System.Drawing.SystemColors.Window;
			this.advancedKeyValues.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.advancedKeyHeader,
            this.advancedValueHeader});
			this.advancedKeyValues.FullRowSelect = true;
			this.advancedKeyValues.GridLines = true;
			listViewGroup36.Header = "Header";
			listViewGroup36.Name = null;
			listViewGroup37.Header = "Save Information";
			listViewGroup37.Name = null;
			listViewGroup38.Header = "Plugin Info";
			listViewGroup38.Name = null;
			listViewGroup39.Header = "File Location Table";
			listViewGroup39.Name = null;
			listViewGroup40.Header = "Misc Stats (0)";
			listViewGroup40.Name = null;
			listViewGroup41.Header = "Player Location (1)";
			listViewGroup41.Name = null;
			listViewGroup42.Header = "TES (2)";
			listViewGroup42.Name = null;
			listViewGroup43.Header = "Global Variables (3)";
			listViewGroup43.Name = null;
			listViewGroup44.Header = "Created Objects (4)";
			listViewGroup44.Name = null;
			listViewGroup45.Header = "Effects (5)";
			listViewGroup45.Name = null;
			listViewGroup46.Header = "Weather (6)";
			listViewGroup46.Name = null;
			listViewGroup47.Header = "Audio (7)";
			listViewGroup47.Name = null;
			listViewGroup48.Header = "Sky Cells (8)";
			listViewGroup48.Name = null;
			listViewGroup49.Header = "Process Lists (100)";
			listViewGroup49.Name = null;
			listViewGroup50.Header = "Combat (101)";
			listViewGroup50.Name = null;
			listViewGroup51.Header = "Interface (102)";
			listViewGroup51.Name = null;
			listViewGroup52.Header = "Actor Causes (103)";
			listViewGroup52.Name = null;
			listViewGroup53.Header = "Unknown (104)";
			listViewGroup53.Name = null;
			listViewGroup54.Header = "Detection Manager (105)";
			listViewGroup54.Name = null;
			listViewGroup55.Header = "Location MetaData (106)";
			listViewGroup55.Name = null;
			listViewGroup56.Header = "Quest Static Data (107)";
			listViewGroup56.Name = null;
			listViewGroup57.Header = "StoryTeller (108)";
			listViewGroup57.Name = null;
			listViewGroup58.Header = "Magic Favorites (109)";
			listViewGroup58.Name = null;
			listViewGroup59.Header = "PlayerControls (110)";
			listViewGroup59.Name = null;
			listViewGroup60.Header = "Story Event Manager (111)";
			listViewGroup60.Name = null;
			listViewGroup61.Header = "Ingredient Shared (112)";
			listViewGroup61.Name = null;
			listViewGroup62.Header = "MenuControls (113)";
			listViewGroup62.Name = null;
			listViewGroup63.Header = "MenuTopicManager (114)";
			listViewGroup63.Name = null;
			listViewGroup64.Header = "Temp Effects (1000)";
			listViewGroup64.Name = null;
			listViewGroup65.Header = "Papyrus (1001)";
			listViewGroup65.Name = null;
			listViewGroup66.Header = "Anim Objects (1002)";
			listViewGroup66.Name = null;
			listViewGroup67.Header = "Timer (1003)";
			listViewGroup67.Name = null;
			listViewGroup68.Header = "Synchronized Animations (1004)";
			listViewGroup68.Name = null;
			listViewGroup69.Header = "Main (1005)";
			listViewGroup69.Name = null;
			listViewGroup70.Header = "Change Form";
			listViewGroup70.Name = null;
			this.advancedKeyValues.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup36,
            listViewGroup37,
            listViewGroup38,
            listViewGroup39,
            listViewGroup40,
            listViewGroup41,
            listViewGroup42,
            listViewGroup43,
            listViewGroup44,
            listViewGroup45,
            listViewGroup46,
            listViewGroup47,
            listViewGroup48,
            listViewGroup49,
            listViewGroup50,
            listViewGroup51,
            listViewGroup52,
            listViewGroup53,
            listViewGroup54,
            listViewGroup55,
            listViewGroup56,
            listViewGroup57,
            listViewGroup58,
            listViewGroup59,
            listViewGroup60,
            listViewGroup61,
            listViewGroup62,
            listViewGroup63,
            listViewGroup64,
            listViewGroup65,
            listViewGroup66,
            listViewGroup67,
            listViewGroup68,
            listViewGroup69,
            listViewGroup70});
			this.advancedKeyValues.LabelWrap = false;
			this.advancedKeyValues.Location = new System.Drawing.Point(4, 29);
			this.advancedKeyValues.MultiSelect = false;
			this.advancedKeyValues.Name = "advancedKeyValues";
			this.advancedKeyValues.Size = new System.Drawing.Size(653, 253);
			this.advancedKeyValues.TabIndex = 2;
			this.advancedKeyValues.UseCompatibleStateImageBehavior = false;
			this.advancedKeyValues.View = System.Windows.Forms.View.Details;
			this.advancedKeyValues.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.advancedKeyValues_MouseDoubleClick);
			// 
			// advancedKeyHeader
			// 
			this.advancedKeyHeader.Text = "Key";
			this.advancedKeyHeader.Width = 214;
			// 
			// advancedValueHeader
			// 
			this.advancedValueHeader.Text = "Value";
			this.advancedValueHeader.Width = 385;
			// 
			// advancedFilterClear
			// 
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
			this.advancedFilterClear.TabIndex = 3;
			this.advancedFilterClear.UseVisualStyleBackColor = false;
			this.advancedFilterClear.Click += new System.EventHandler(this.buttonAdvancedClear_Click);
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
			this.advancedFilter.TabIndex = 1;
			this.advancedFilter.Text = "Filter...";
			this.advancedFilter.Enter += new System.EventHandler(this.advancedFilter_Enter);
			this.advancedFilter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.advancedFilter_KeyUp);
			this.advancedFilter.Leave += new System.EventHandler(this.advancedFilter_Leave);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.splitContainer1);
			this.tabPage1.Controls.Add(this.button1);
			this.tabPage1.Controls.Add(this.textBox1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(658, 285);
			this.tabPage1.TabIndex = 3;
			this.tabPage1.Text = "Advanced";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.Location = new System.Drawing.Point(3, 29);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.treeView1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.objectListView1);
			this.splitContainer1.Panel2.Controls.Add(this.listView1);
			this.splitContainer1.Size = new System.Drawing.Size(652, 253);
			this.splitContainer1.SplitterDistance = 150;
			this.splitContainer1.TabIndex = 6;
			// 
			// treeView1
			// 
			this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeView1.ImageIndex = 6;
			this.treeView1.ImageList = this.imageList1;
			this.treeView1.Location = new System.Drawing.Point(0, 0);
			this.treeView1.Name = "treeView1";
			treeNode12.ImageIndex = 8;
			treeNode12.Name = "Node4";
			treeNode12.SelectedImageKey = "brick_go.png";
			treeNode12.Text = "Node4";
			treeNode13.ImageIndex = 8;
			treeNode13.Name = "Node5";
			treeNode13.SelectedImageKey = "brick_go.png";
			treeNode13.Text = "Node5";
			treeNode14.ImageIndex = 8;
			treeNode14.Name = "Node6";
			treeNode14.SelectedImageIndex = 9;
			treeNode14.Text = "Node6";
			treeNode15.ImageIndex = 1;
			treeNode15.Name = "Node0";
			treeNode15.SelectedImageKey = "bricks.png";
			treeNode15.Text = "Header";
			treeNode16.ImageKey = "bricks.png";
			treeNode16.Name = "Node2";
			treeNode16.SelectedImageKey = "bricks.png";
			treeNode16.Text = "File Properties";
			treeNode17.ImageIndex = 1;
			treeNode17.Name = "Node1";
			treeNode17.SelectedImageKey = "bricks.png";
			treeNode17.Text = "Plugin Info";
			treeNode18.ImageIndex = 1;
			treeNode18.Name = "Node2";
			treeNode18.SelectedImageKey = "bricks.png";
			treeNode18.Text = "File Location Table";
			treeNode19.ImageKey = "brick.png";
			treeNode19.Name = "Node3";
			treeNode19.SelectedImageKey = "brick_go.png";
			treeNode19.Text = "Node3";
			treeNode20.ImageIndex = 1;
			treeNode20.Name = "Node3";
			treeNode20.SelectedImageKey = "bricks.png";
			treeNode20.Text = "Misc Stats";
			treeNode21.ImageIndex = 1;
			treeNode21.Name = "Node4";
			treeNode21.SelectedImageKey = "bricks.png";
			treeNode21.Text = "Player Location";
			treeNode22.ImageKey = "box_closed.png";
			treeNode22.Name = "Node0";
			treeNode22.SelectedImageKey = "box_closed.png";
			treeNode22.Text = "Save File";
			this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode22});
			this.treeView1.SelectedImageIndex = 0;
			this.treeView1.Size = new System.Drawing.Size(150, 253);
			this.treeView1.TabIndex = 1;
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "tree_red.png");
			this.imageList1.Images.SetKeyName(1, "bricks.png");
			this.imageList1.Images.SetKeyName(2, "scull.png");
			this.imageList1.Images.SetKeyName(3, "tower.png");
			this.imageList1.Images.SetKeyName(4, "toilet.png");
			this.imageList1.Images.SetKeyName(5, "bow.png");
			this.imageList1.Images.SetKeyName(6, "box_closed.png");
			this.imageList1.Images.SetKeyName(7, "box_open.png");
			this.imageList1.Images.SetKeyName(8, "brick.png");
			this.imageList1.Images.SetKeyName(9, "brick_go.png");
			// 
			// objectListView1
			// 
			this.objectListView1.AllColumns.Add(this.typeColumn);
			this.objectListView1.AllColumns.Add(this.olvColumn2);
			this.objectListView1.AllColumns.Add(this.olvColumn1);
			this.objectListView1.AllColumns.Add(this.olvColumn3);
			this.objectListView1.AllColumns.Add(this.olvColumn4);
			this.objectListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.typeColumn,
            this.olvColumn2,
            this.olvColumn1,
            this.olvColumn3,
            this.olvColumn4});
			this.objectListView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.objectListView1.FullRowSelect = true;
			this.objectListView1.Location = new System.Drawing.Point(0, 0);
			this.objectListView1.Name = "objectListView1";
			this.objectListView1.RowHeight = 20;
			this.objectListView1.ShowGroups = false;
			this.objectListView1.Size = new System.Drawing.Size(498, 253);
			this.objectListView1.SmallImageList = this.imageList2;
			this.objectListView1.TabIndex = 7;
			this.objectListView1.UseCompatibleStateImageBehavior = false;
			this.objectListView1.View = System.Windows.Forms.View.Details;
			// 
			// typeColumn
			// 
			this.typeColumn.Hideable = false;
			this.typeColumn.IsEditable = false;
			this.typeColumn.MaximumWidth = 20;
			this.typeColumn.MinimumWidth = 20;
			this.typeColumn.Searchable = false;
			this.typeColumn.ShowTextInHeader = false;
			this.typeColumn.Text = "";
			this.typeColumn.UseFiltering = false;
			this.typeColumn.Width = 20;
			// 
			// olvColumn2
			// 
			this.olvColumn2.AspectName = "Type";
			this.olvColumn2.Text = "Type";
			// 
			// olvColumn1
			// 
			this.olvColumn1.AspectName = "Key";
			this.olvColumn1.Hideable = false;
			this.olvColumn1.Text = "Key";
			this.olvColumn1.Width = 113;
			// 
			// olvColumn3
			// 
			this.olvColumn3.AspectName = "Value";
			this.olvColumn3.Hideable = false;
			this.olvColumn3.Sortable = false;
			this.olvColumn3.Text = "Value";
			this.olvColumn3.Width = 149;
			// 
			// olvColumn4
			// 
			this.olvColumn4.AspectName = "Description";
			this.olvColumn4.FillsFreeSpace = true;
			this.olvColumn4.IsEditable = false;
			this.olvColumn4.Sortable = false;
			this.olvColumn4.Text = "Description";
			this.olvColumn4.Width = 440;
			// 
			// imageList2
			// 
			this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
			this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList2.Images.SetKeyName(0, "String");
			this.imageList2.Images.SetKeyName(1, "Unknown");
			this.imageList2.Images.SetKeyName(2, "Byte");
			this.imageList2.Images.SetKeyName(3, "Image");
			this.imageList2.Images.SetKeyName(4, "Byte");
			this.imageList2.Images.SetKeyName(5, "Int");
			this.imageList2.Images.SetKeyName(6, "RefID");
			this.imageList2.Images.SetKeyName(7, "calculator_black.png");
			this.imageList2.Images.SetKeyName(8, "radiobutton_group.png");
			this.imageList2.Images.SetKeyName(9, "Filetime");
			this.imageList2.Images.SetKeyName(10, "Single");
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
			this.listView1.Size = new System.Drawing.Size(498, 253);
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
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.button1.Enabled = false;
			this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ScrollBar;
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(635, 3);
			this.button1.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(20, 20);
			this.button1.TabIndex = 5;
			this.button1.UseVisualStyleBackColor = false;
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.textBox1.Location = new System.Drawing.Point(3, 3);
			this.textBox1.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(633, 20);
			this.textBox1.TabIndex = 4;
			this.textBox1.Text = "Filter...";
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
			this.advancedTab.ResumeLayout(false);
			this.advancedTab.PerformLayout();
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.objectListView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TabPage tabPage1;
		private SplitContainer splitContainer1;
		private Button button1;
		private TextBox textBox1;
		private TreeView treeView1;
		private ListView listView1;
		private ColumnHeader columnHeader1;
		private ColumnHeader columnHeader2;
		private ColumnHeader columnHeader3;
		private ColumnHeader columnHeader4;
		private ImageList imageList1;
		private BrightIdeasSoftware.ObjectListView objectListView1;
		private BrightIdeasSoftware.OLVColumn olvColumn1;
		private BrightIdeasSoftware.OLVColumn olvColumn2;
		private BrightIdeasSoftware.OLVColumn olvColumn3;
		private BrightIdeasSoftware.OLVColumn olvColumn4;

		private int calcNumFields(Type type) {
			int num = 0;

			foreach (System.Reflection.FieldInfo field in type.GetFields()) {
				Console.WriteLine(field.Name);
				num += Math.Max(1, calcNumFields(field.FieldType));
			}

			return num;
		}

		private ImageList imageList2;
		private BrightIdeasSoftware.OLVColumn typeColumn;

	}
}

