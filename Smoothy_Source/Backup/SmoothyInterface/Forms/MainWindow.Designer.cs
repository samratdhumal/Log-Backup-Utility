namespace SmoothyInterface
{
	partial class MainWindow
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.toolBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.connectToRemoteComputerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.arrangeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.treeViewLogs = new System.Windows.Forms.TreeView();
			this.treeImageList = new System.Windows.Forms.ImageList(this.components);
			this.treeContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.clearEventLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteEventLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.computerContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.newEventLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.refreshEventLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip.SuspendLayout();
			this.toolStrip.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.treeContextMenu.SuspendLayout();
			this.computerContextMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.viewMenu,
            this.toolsMenu,
            this.windowsMenu,
            this.helpMenu});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.MdiWindowListItem = this.windowsMenu;
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(632, 24);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "MenuStrip";
			// 
			// fileMenu
			// 
			this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
			this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
			this.fileMenu.Name = "fileMenu";
			this.fileMenu.Size = new System.Drawing.Size(35, 20);
			this.fileMenu.Text = "&File";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Image = global::SmoothyInterface.Properties.Resources.door_out;
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
			// 
			// viewMenu
			// 
			this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBarToolStripMenuItem,
            this.statusBarToolStripMenuItem});
			this.viewMenu.Name = "viewMenu";
			this.viewMenu.Size = new System.Drawing.Size(41, 20);
			this.viewMenu.Text = "&View";
			// 
			// toolBarToolStripMenuItem
			// 
			this.toolBarToolStripMenuItem.Checked = true;
			this.toolBarToolStripMenuItem.CheckOnClick = true;
			this.toolBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolBarToolStripMenuItem.Name = "toolBarToolStripMenuItem";
			this.toolBarToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
			this.toolBarToolStripMenuItem.Text = "&Toolbar";
			this.toolBarToolStripMenuItem.Click += new System.EventHandler(this.ToolBarToolStripMenuItem_Click);
			// 
			// statusBarToolStripMenuItem
			// 
			this.statusBarToolStripMenuItem.Checked = true;
			this.statusBarToolStripMenuItem.CheckOnClick = true;
			this.statusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
			this.statusBarToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
			this.statusBarToolStripMenuItem.Text = "&Status Bar";
			this.statusBarToolStripMenuItem.Click += new System.EventHandler(this.StatusBarToolStripMenuItem_Click);
			// 
			// toolsMenu
			// 
			this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.connectToRemoteComputerToolStripMenuItem});
			this.toolsMenu.Name = "toolsMenu";
			this.toolsMenu.Size = new System.Drawing.Size(44, 20);
			this.toolsMenu.Text = "&Tools";
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.Image = global::SmoothyInterface.Properties.Resources.table;
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
			this.optionsToolStripMenuItem.Text = "&Options";
			this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
			// 
			// connectToRemoteComputerToolStripMenuItem
			// 
			this.connectToRemoteComputerToolStripMenuItem.Image = global::SmoothyInterface.Properties.Resources.connect;
			this.connectToRemoteComputerToolStripMenuItem.Name = "connectToRemoteComputerToolStripMenuItem";
			this.connectToRemoteComputerToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
			this.connectToRemoteComputerToolStripMenuItem.Text = "&Connect To Computer";
			this.connectToRemoteComputerToolStripMenuItem.Click += new System.EventHandler(this.connectToRemoteComputerToolStripMenuItem_Click);
			// 
			// windowsMenu
			// 
			this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWindowToolStripMenuItem,
            this.cascadeToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.closeAllToolStripMenuItem,
            this.arrangeIconsToolStripMenuItem});
			this.windowsMenu.Name = "windowsMenu";
			this.windowsMenu.Size = new System.Drawing.Size(62, 20);
			this.windowsMenu.Text = "&Windows";
			// 
			// newWindowToolStripMenuItem
			// 
			this.newWindowToolStripMenuItem.Image = global::SmoothyInterface.Properties.Resources.add;
			this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
			this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.newWindowToolStripMenuItem.Text = "&New Window";
			this.newWindowToolStripMenuItem.Click += new System.EventHandler(this.ShowNewForm);
			// 
			// cascadeToolStripMenuItem
			// 
			this.cascadeToolStripMenuItem.Image = global::SmoothyInterface.Properties.Resources.arrow_out;
			this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
			this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.cascadeToolStripMenuItem.Text = "&Cascade";
			this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
			// 
			// tileVerticalToolStripMenuItem
			// 
			this.tileVerticalToolStripMenuItem.Image = global::SmoothyInterface.Properties.Resources.arrow_up;
			this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
			this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.tileVerticalToolStripMenuItem.Text = "Tile &Vertical";
			this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.TileVerticleToolStripMenuItem_Click);
			// 
			// tileHorizontalToolStripMenuItem
			// 
			this.tileHorizontalToolStripMenuItem.Image = global::SmoothyInterface.Properties.Resources.arrow_right;
			this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
			this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.tileHorizontalToolStripMenuItem.Text = "Tile &Horizontal";
			this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.TileHorizontalToolStripMenuItem_Click);
			// 
			// closeAllToolStripMenuItem
			// 
			this.closeAllToolStripMenuItem.Image = global::SmoothyInterface.Properties.Resources.cancel;
			this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
			this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.closeAllToolStripMenuItem.Text = "C&lose All";
			this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
			// 
			// arrangeIconsToolStripMenuItem
			// 
			this.arrangeIconsToolStripMenuItem.Image = global::SmoothyInterface.Properties.Resources.arrow_in;
			this.arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
			this.arrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
			this.arrangeIconsToolStripMenuItem.Text = "&Arrange Icons";
			this.arrangeIconsToolStripMenuItem.Click += new System.EventHandler(this.ArrangeIconsToolStripMenuItem_Click);
			// 
			// helpMenu
			// 
			this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpMenu.Name = "helpMenu";
			this.helpMenu.Size = new System.Drawing.Size(40, 20);
			this.helpMenu.Text = "&Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Image = global::SmoothyInterface.Properties.Resources.help;
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
			this.aboutToolStripMenuItem.Text = "&About ...";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// toolStrip
			// 
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator1,
            this.printToolStripButton,
            this.toolStripSeparator2,
            this.helpToolStripButton});
			this.toolStrip.Location = new System.Drawing.Point(0, 24);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new System.Drawing.Size(632, 25);
			this.toolStrip.TabIndex = 1;
			this.toolStrip.Text = "ToolStrip";
			// 
			// newToolStripButton
			// 
			this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.newToolStripButton.Enabled = false;
			this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
			this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
			this.newToolStripButton.Name = "newToolStripButton";
			this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.newToolStripButton.Text = "New";
			this.newToolStripButton.Click += new System.EventHandler(this.ShowNewForm);
			// 
			// openToolStripButton
			// 
			this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.openToolStripButton.Enabled = false;
			this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
			this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
			this.openToolStripButton.Name = "openToolStripButton";
			this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.openToolStripButton.Text = "Open";
			this.openToolStripButton.Click += new System.EventHandler(this.OpenFile);
			// 
			// saveToolStripButton
			// 
			this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.saveToolStripButton.Enabled = false;
			this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
			this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
			this.saveToolStripButton.Name = "saveToolStripButton";
			this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.saveToolStripButton.Text = "Save";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// printToolStripButton
			// 
			this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.printToolStripButton.Enabled = false;
			this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
			this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
			this.printToolStripButton.Name = "printToolStripButton";
			this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.printToolStripButton.Text = "Print";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// helpToolStripButton
			// 
			this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
			this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
			this.helpToolStripButton.Name = "helpToolStripButton";
			this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.helpToolStripButton.Text = "Help";
			this.helpToolStripButton.Click += new System.EventHandler(this.helpToolStripButton_Click);
			// 
			// statusStrip
			// 
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
			this.statusStrip.Location = new System.Drawing.Point(0, 431);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(632, 22);
			this.statusStrip.TabIndex = 2;
			this.statusStrip.Text = "Ready...";
			// 
			// toolStripStatusLabel
			// 
			this.toolStripStatusLabel.Name = "toolStripStatusLabel";
			this.toolStripStatusLabel.Size = new System.Drawing.Size(50, 17);
			this.toolStripStatusLabel.Text = "Ready...";
			// 
			// treeViewLogs
			// 
			this.treeViewLogs.Dock = System.Windows.Forms.DockStyle.Left;
			this.treeViewLogs.ImageIndex = 0;
			this.treeViewLogs.ImageList = this.treeImageList;
			this.treeViewLogs.Location = new System.Drawing.Point(0, 49);
			this.treeViewLogs.Name = "treeViewLogs";
			this.treeViewLogs.SelectedImageIndex = 0;
			this.treeViewLogs.Size = new System.Drawing.Size(187, 382);
			this.treeViewLogs.TabIndex = 4;
			this.treeViewLogs.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewLogs_NodeMouseDoubleClick);
			this.treeViewLogs.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewLogs_AfterSelect);
			this.treeViewLogs.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewLogs_NodeMouseClick);
			this.treeViewLogs.KeyUp += new System.Windows.Forms.KeyEventHandler(this.treeViewLogs_KeyUp);
			// 
			// treeImageList
			// 
			this.treeImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("treeImageList.ImageStream")));
			this.treeImageList.TransparentColor = System.Drawing.Color.Transparent;
			this.treeImageList.Images.SetKeyName(0, "Group.gif");
			this.treeImageList.Images.SetKeyName(1, "EventLog.gif");
			this.treeImageList.Images.SetKeyName(2, "Group.gif");
			// 
			// treeContextMenu
			// 
			this.treeContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem1,
            this.clearEventLogToolStripMenuItem,
            this.deleteEventLogToolStripMenuItem});
			this.treeContextMenu.Name = "treeContextMenu";
			this.treeContextMenu.Size = new System.Drawing.Size(117, 70);
			this.treeContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.treeContextMenu_Opening);
			// 
			// openToolStripMenuItem1
			// 
			this.openToolStripMenuItem1.Image = global::SmoothyInterface.Properties.Resources.link_go;
			this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
			this.openToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
			this.openToolStripMenuItem1.Text = "O&pen";
			this.openToolStripMenuItem1.Click += new System.EventHandler(this.openToolStripMenuItem1_Click);
			// 
			// clearEventLogToolStripMenuItem
			// 
			this.clearEventLogToolStripMenuItem.Image = global::SmoothyInterface.Properties.Resources.flag_orange;
			this.clearEventLogToolStripMenuItem.Name = "clearEventLogToolStripMenuItem";
			this.clearEventLogToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.clearEventLogToolStripMenuItem.Text = "&Clear";
			this.clearEventLogToolStripMenuItem.Click += new System.EventHandler(this.clearEventLogToolStripMenuItem_Click);
			// 
			// deleteEventLogToolStripMenuItem
			// 
			this.deleteEventLogToolStripMenuItem.Image = global::SmoothyInterface.Properties.Resources.link_error;
			this.deleteEventLogToolStripMenuItem.Name = "deleteEventLogToolStripMenuItem";
			this.deleteEventLogToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.deleteEventLogToolStripMenuItem.Text = "&Delete";
			this.deleteEventLogToolStripMenuItem.Click += new System.EventHandler(this.deleteEventLogToolStripMenuItem_Click);
			// 
			// computerContextMenuStrip
			// 
			this.computerContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshEventLogsToolStripMenuItem,
            this.newEventLogToolStripMenuItem,
            this.clearAllToolStripMenuItem});
			this.computerContextMenuStrip.Name = "treeContextMenu";
			this.computerContextMenuStrip.Size = new System.Drawing.Size(180, 92);
			// 
			// newEventLogToolStripMenuItem
			// 
			this.newEventLogToolStripMenuItem.Image = global::SmoothyInterface.Properties.Resources.link_add;
			this.newEventLogToolStripMenuItem.Name = "newEventLogToolStripMenuItem";
			this.newEventLogToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
			this.newEventLogToolStripMenuItem.Text = "&New Event Log";
			this.newEventLogToolStripMenuItem.Click += new System.EventHandler(this.newEventLogToolStripMenuItem_Click);
			// 
			// clearAllToolStripMenuItem
			// 
			this.clearAllToolStripMenuItem.Image = global::SmoothyInterface.Properties.Resources.flag_red;
			this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
			this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
			this.clearAllToolStripMenuItem.Text = "&Clear All Logs";
			this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.clearAllToolStripMenuItem_Click);
			// 
			// refreshEventLogsToolStripMenuItem
			// 
			this.refreshEventLogsToolStripMenuItem.Image = global::SmoothyInterface.Properties.Resources.action_refresh_blue;
			this.refreshEventLogsToolStripMenuItem.Name = "refreshEventLogsToolStripMenuItem";
			this.refreshEventLogsToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
			this.refreshEventLogsToolStripMenuItem.Text = "Refresh Event Logs";
			this.refreshEventLogsToolStripMenuItem.Click += new System.EventHandler(this.refreshEventLogsToolStripMenuItem_Click);
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(632, 453);
			this.Controls.Add(this.treeViewLogs);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.toolStrip);
			this.Controls.Add(this.menuStrip);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip;
			this.Name = "MainWindow";
			this.Text = "Smoothy Log Viewer";
			this.Load += new System.EventHandler(this.MainWindow_Load);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.treeContextMenu.ResumeLayout(false);
			this.computerContextMenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion


		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileMenu;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewMenu;
		private System.Windows.Forms.ToolStripMenuItem toolBarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolsMenu;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem windowsMenu;
		private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpMenu;
		private System.Windows.Forms.ToolStripButton newToolStripButton;
		private System.Windows.Forms.ToolStripButton openToolStripButton;
		private System.Windows.Forms.ToolStripButton saveToolStripButton;
		private System.Windows.Forms.ToolStripButton printToolStripButton;
		private System.Windows.Forms.ToolStripButton helpToolStripButton;
		private System.Windows.Forms.ToolTip ToolTip;
		private System.Windows.Forms.TreeView treeViewLogs;
		private System.Windows.Forms.ImageList treeImageList;
		private System.Windows.Forms.ContextMenuStrip treeContextMenu;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem clearEventLogToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem deleteEventLogToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip computerContextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem connectToRemoteComputerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newEventLogToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem refreshEventLogsToolStripMenuItem;
	}
}



