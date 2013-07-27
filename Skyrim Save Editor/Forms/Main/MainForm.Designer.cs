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
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.newMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuSeperator1 = new System.Windows.Forms.ToolStripSeparator();
			this.recentFilesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuSeperator2 = new System.Windows.Forms.ToolStripSeparator();
			this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.undoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.redoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuSeperator3 = new System.Windows.Forms.ToolStripSeparator();
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
			this.descriptionColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripContextEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.typeImageList = new System.Windows.Forms.ImageList(this.components);
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.treeListView = new BrightIdeasSoftware.TreeListView();
			this.treeColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.fieldListView = new BrightIdeasSoftware.ObjectListView();
			this.typeImageColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.typeColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.keyColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.valueColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
			this.advancedFilter = new System.Windows.Forms.TextBox();
			this.clearButtonImageList = new System.Windows.Forms.ImageList(this.components);
			this.panel = new System.Windows.Forms.Panel();
			this.clearButton = new Skyrim_Save_Editor.Forms.Main.Controls.ClearButton();
			this.menuStrip.SuspendLayout();
			this.toolStrip.SuspendLayout();
			this.contextMenuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.treeListView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fieldListView)).BeginInit();
			this.panel.SuspendLayout();
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
            this.toolStripMenuSeperator1,
            this.recentFilesMenuItem,
            this.toolStripMenuSeperator2,
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
			// toolStripMenuSeperator1
			// 
			this.toolStripMenuSeperator1.Name = "toolStripMenuSeperator1";
			this.toolStripMenuSeperator1.Size = new System.Drawing.Size(190, 6);
			// 
			// recentFilesMenuItem
			// 
			this.recentFilesMenuItem.Name = "recentFilesMenuItem";
			this.recentFilesMenuItem.Size = new System.Drawing.Size(193, 22);
			this.recentFilesMenuItem.Text = "&Recent Files";
			// 
			// toolStripMenuSeperator2
			// 
			this.toolStripMenuSeperator2.Name = "toolStripMenuSeperator2";
			this.toolStripMenuSeperator2.Size = new System.Drawing.Size(190, 6);
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
            this.toolStripMenuSeperator3,
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
			this.undoMenuItem.Size = new System.Drawing.Size(152, 22);
			this.undoMenuItem.Text = "&Undo";
			// 
			// redoMenuItem
			// 
			this.redoMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("redoMenuItem.Image")));
			this.redoMenuItem.Name = "redoMenuItem";
			this.redoMenuItem.ShortcutKeyDisplayString = "Ctrl+Y";
			this.redoMenuItem.Size = new System.Drawing.Size(152, 22);
			this.redoMenuItem.Text = "&Redo";
			// 
			// toolStripMenuSeperator3
			// 
			this.toolStripMenuSeperator3.Name = "toolStripMenuSeperator3";
			this.toolStripMenuSeperator3.Size = new System.Drawing.Size(149, 6);
			// 
			// filePropertiesMenuItem
			// 
			this.filePropertiesMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("filePropertiesMenuItem.Image")));
			this.filePropertiesMenuItem.Name = "filePropertiesMenuItem";
			this.filePropertiesMenuItem.Size = new System.Drawing.Size(152, 22);
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
			this.aboutMenuItem.Size = new System.Drawing.Size(152, 22);
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
			// descriptionColumn
			// 
			this.descriptionColumn.AspectName = "Description";
			this.descriptionColumn.DisplayIndex = 4;
			this.descriptionColumn.FillsFreeSpace = true;
			this.descriptionColumn.IsEditable = false;
			this.descriptionColumn.IsVisible = false;
			this.descriptionColumn.Sortable = false;
			this.descriptionColumn.Text = "Description";
			this.descriptionColumn.Width = 440;
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripContextEdit});
			this.contextMenuStrip.Name = "contextMenuStrip1";
			this.contextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.contextMenuStrip.Size = new System.Drawing.Size(95, 26);
			this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
			this.contextMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip_ItemClicked);
			// 
			// toolStripContextEdit
			// 
			this.toolStripContextEdit.Name = "toolStripContextEdit";
			this.toolStripContextEdit.Size = new System.Drawing.Size(94, 22);
			this.toolStripContextEdit.Text = "Edit";
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
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer1.Location = new System.Drawing.Point(3, 30);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.treeListView);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.fieldListView);
			this.splitContainer1.Size = new System.Drawing.Size(660, 280);
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
			this.treeListView.HeaderMaximumHeight = 0;
			this.treeListView.Location = new System.Drawing.Point(0, 0);
			this.treeListView.MultiSelect = false;
			this.treeListView.Name = "treeListView";
			this.treeListView.OwnerDraw = true;
			this.treeListView.RowHeight = 17;
			this.treeListView.SelectColumnsOnRightClick = false;
			this.treeListView.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.None;
			this.treeListView.ShowFilterMenuOnRightClick = false;
			this.treeListView.ShowGroups = false;
			this.treeListView.Size = new System.Drawing.Size(175, 280);
			this.treeListView.SmallImageList = this.treeImageList;
			this.treeListView.TabIndex = 0;
			this.treeListView.UseCompatibleStateImageBehavior = false;
			this.treeListView.UseExplorerTheme = true;
			this.treeListView.UseFiltering = true;
			this.treeListView.UseHotItem = true;
			this.treeListView.UseOverlays = false;
			this.treeListView.UseTranslucentHotItem = true;
			this.treeListView.UseTranslucentSelection = true;
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
			this.treeColumn.ShowTextInHeader = false;
			this.treeColumn.Sortable = false;
			this.treeColumn.Text = "";
			this.treeColumn.Width = 0;
			// 
			// fieldListView
			// 
			this.fieldListView.AllColumns.Add(this.typeImageColumn);
			this.fieldListView.AllColumns.Add(this.typeColumn);
			this.fieldListView.AllColumns.Add(this.keyColumn);
			this.fieldListView.AllColumns.Add(this.valueColumn);
			this.fieldListView.AllColumns.Add(this.descriptionColumn);
			this.fieldListView.AllowColumnReorder = true;
			this.fieldListView.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
			this.fieldListView.CellEditTabChangesRows = true;
			this.fieldListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.typeImageColumn,
            this.typeColumn,
            this.keyColumn,
            this.valueColumn});
			this.fieldListView.ContextMenuStrip = this.contextMenuStrip;
			this.fieldListView.Cursor = System.Windows.Forms.Cursors.Default;
			this.fieldListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fieldListView.FullRowSelect = true;
			this.fieldListView.Location = new System.Drawing.Point(0, 0);
			this.fieldListView.MultiSelect = false;
			this.fieldListView.Name = "fieldListView";
			this.fieldListView.RowHeight = 20;
			this.fieldListView.ShowFilterMenuOnRightClick = false;
			this.fieldListView.ShowGroups = false;
			this.fieldListView.Size = new System.Drawing.Size(481, 280);
			this.fieldListView.SmallImageList = this.typeImageList;
			this.fieldListView.TabIndex = 7;
			this.fieldListView.UseCompatibleStateImageBehavior = false;
			this.fieldListView.UseExplorerTheme = true;
			this.fieldListView.UseFiltering = true;
			this.fieldListView.UseHotItem = true;
			this.fieldListView.UseOverlays = false;
			this.fieldListView.UseTranslucentHotItem = true;
			this.fieldListView.UseTranslucentSelection = true;
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
			// advancedFilter
			// 
			this.advancedFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.advancedFilter.ForeColor = System.Drawing.Color.Gray;
			this.advancedFilter.Location = new System.Drawing.Point(3, 5);
			this.advancedFilter.Name = "advancedFilter";
			this.advancedFilter.Size = new System.Drawing.Size(660, 20);
			this.advancedFilter.TabIndex = 7;
			this.advancedFilter.Text = "Key filter...";
			this.advancedFilter.Enter += new System.EventHandler(this.advancedFilter_Enter);
			this.advancedFilter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.advancedFilter_KeyUp);
			this.advancedFilter.Leave += new System.EventHandler(this.advancedFilter_Leave);
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
			// panel
			// 
			this.panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.panel.Controls.Add(this.clearButton);
			this.panel.Controls.Add(this.splitContainer1);
			this.panel.Controls.Add(this.advancedFilter);
			this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel.Location = new System.Drawing.Point(0, 49);
			this.panel.Name = "panel";
			this.panel.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
			this.panel.Size = new System.Drawing.Size(666, 313);
			this.panel.TabIndex = 3;
			this.panel.Visible = false;
			// 
			// clearButton
			// 
			this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.clearButton.ButtonEnabled = false;
			this.clearButton.Location = new System.Drawing.Point(643, 6);
			this.clearButton.Name = "clearButton";
			this.clearButton.Size = new System.Drawing.Size(18, 18);
			this.clearButton.TabIndex = 8;
			this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(666, 362);
			this.Controls.Add(this.panel);
			this.Controls.Add(this.toolStrip);
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
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.treeListView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fieldListView)).EndInit();
			this.panel.ResumeLayout(false);
			this.panel.PerformLayout();
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
		private System.Windows.Forms.ToolStripSeparator toolStripMenuSeperator2;
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
		private System.Windows.Forms.ToolStripSeparator toolStripMenuSeperator1;
		private System.Windows.Forms.ToolStripMenuItem recentFilesMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem undoMenuItem;
		private System.Windows.Forms.ToolStripMenuItem redoMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuSeperator3;
		private System.Windows.Forms.ToolStripMenuItem filePropertiesMenuItem;
		private System.Windows.Forms.ToolStripButton undoToolButton;
		private System.Windows.Forms.ToolStripButton redoToolButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem saveAsMenuItem;
		private ImageList treeImageList;
		private BrightIdeasSoftware.OLVColumn descriptionColumn;
		private ImageList typeImageList;
		#endregion

		private ContextMenuStrip contextMenuStrip;
		private ToolStripMenuItem toolStripContextEdit;
		private TextBox advancedFilter;
		private SplitContainer splitContainer1;
		private BrightIdeasSoftware.TreeListView treeListView;
		private BrightIdeasSoftware.OLVColumn treeColumn;
		private BrightIdeasSoftware.ObjectListView fieldListView;
		private BrightIdeasSoftware.OLVColumn typeImageColumn;
		private BrightIdeasSoftware.OLVColumn typeColumn;
		private BrightIdeasSoftware.OLVColumn keyColumn;
		private BrightIdeasSoftware.OLVColumn valueColumn;
		private ImageList clearButtonImageList;
		private Controls.ClearButton clearButton;
		private Panel panel;
	}
}

