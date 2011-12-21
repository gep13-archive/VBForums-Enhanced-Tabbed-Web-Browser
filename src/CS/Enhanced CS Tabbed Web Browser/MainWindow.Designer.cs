namespace Enhanced_CS_Tabbed_Web_Browser
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
            System.Windows.Forms.ToolStripMenuItem openMenuItem;
            System.Windows.Forms.ToolStripMenuItem exitMenuItem;
            System.Windows.Forms.ToolStripButton homeButton;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            System.Windows.Forms.ToolStripButton newTabButton;
            System.Windows.Forms.ToolStripSeparator toolbarSeparator2;
            System.Windows.Forms.ToolStripLabel addressLabel;
            System.Windows.Forms.ToolStripSeparator toolbarSeparator1;
            this.favouritesTabControl = new System.Windows.Forms.TabControl();
            this.favouritesTabPage = new System.Windows.Forms.TabPage();
            this.favouritesTreeView = new System.Windows.Forms.TreeView();
            this.favouritesContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeleteFavouriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditFavouriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feedsTabPage = new System.Windows.Forms.TabPage();
            this.historyTabPage = new System.Windows.Forms.TabPage();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.tabs = new Enhanced_CS_Tabbed_Web_Browser.WebBrowserTabControl();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTabMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeTabMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.viewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.historyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forwardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageLoadProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.statusbar = new System.Windows.Forms.StatusStrip();
            this.browserStatusTextLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.forwardButton = new System.Windows.Forms.ToolStripButton();
            this.refreshButton = new System.Windows.Forms.ToolStripButton();
            this.stopButton = new System.Windows.Forms.ToolStripButton();
            this.favouritesButton = new System.Windows.Forms.ToolStripSplitButton();
            this.AddToFavouritesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeTabButton = new System.Windows.Forms.ToolStripButton();
            this.addressCombo = new System.Windows.Forms.ToolStripComboBox();
            this.goButton = new System.Windows.Forms.ToolStripButton();
            this.toolbar = new System.Windows.Forms.ToolStrip();
            this.backButton = new System.Windows.Forms.ToolStripButton();
            openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            homeButton = new System.Windows.Forms.ToolStripButton();
            newTabButton = new System.Windows.Forms.ToolStripButton();
            toolbarSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            addressLabel = new System.Windows.Forms.ToolStripLabel();
            toolbarSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.favouritesTabControl.SuspendLayout();
            this.favouritesTabPage.SuspendLayout();
            this.favouritesContextMenu.SuspendLayout();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.statusbar.SuspendLayout();
            this.toolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // openMenuItem
            // 
            openMenuItem.Enabled = false;
            openMenuItem.Name = "openMenuItem";
            openMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            openMenuItem.Size = new System.Drawing.Size(164, 22);
            openMenuItem.Text = "&Open...";
            openMenuItem.Click += new System.EventHandler(this.openMenuItem_Click);
            // 
            // exitMenuItem
            // 
            exitMenuItem.Name = "exitMenuItem";
            exitMenuItem.Size = new System.Drawing.Size(164, 22);
            exitMenuItem.Text = "E&xit";
            exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // homeButton
            // 
            homeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            homeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            homeButton.Name = "homeButton";
            homeButton.Size = new System.Drawing.Size(23, 22);
            homeButton.Text = "Home";
            homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // newTabButton
            // 
            newTabButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            newTabButton.Image = ((System.Drawing.Image)(resources.GetObject("newTabButton.Image")));
            newTabButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            newTabButton.Name = "newTabButton";
            newTabButton.Size = new System.Drawing.Size(23, 22);
            newTabButton.Text = "New Tab";
            newTabButton.ToolTipText = "New Tab";
            newTabButton.Click += new System.EventHandler(this.newTabButton_Click);
            // 
            // toolbarSeparator2
            // 
            toolbarSeparator2.Name = "toolbarSeparator2";
            toolbarSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // addressLabel
            // 
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(52, 22);
            addressLabel.Text = "Address:";
            // 
            // toolbarSeparator1
            // 
            toolbarSeparator1.Name = "toolbarSeparator1";
            toolbarSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // favouritesTabControl
            // 
            this.favouritesTabControl.Controls.Add(this.favouritesTabPage);
            this.favouritesTabControl.Controls.Add(this.feedsTabPage);
            this.favouritesTabControl.Controls.Add(this.historyTabPage);
            this.favouritesTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.favouritesTabControl.Location = new System.Drawing.Point(0, 0);
            this.favouritesTabControl.Name = "favouritesTabControl";
            this.favouritesTabControl.SelectedIndex = 0;
            this.favouritesTabControl.Size = new System.Drawing.Size(300, 495);
            this.favouritesTabControl.TabIndex = 0;
            // 
            // favouritesTabPage
            // 
            this.favouritesTabPage.Controls.Add(this.favouritesTreeView);
            this.favouritesTabPage.Location = new System.Drawing.Point(4, 22);
            this.favouritesTabPage.Name = "favouritesTabPage";
            this.favouritesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.favouritesTabPage.Size = new System.Drawing.Size(292, 469);
            this.favouritesTabPage.TabIndex = 0;
            this.favouritesTabPage.Text = "Favourites";
            this.favouritesTabPage.UseVisualStyleBackColor = true;
            // 
            // favouritesTreeView
            // 
            this.favouritesTreeView.ContextMenuStrip = this.favouritesContextMenu;
            this.favouritesTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.favouritesTreeView.Location = new System.Drawing.Point(3, 3);
            this.favouritesTreeView.Name = "favouritesTreeView";
            this.favouritesTreeView.Size = new System.Drawing.Size(286, 463);
            this.favouritesTreeView.TabIndex = 0;
            this.favouritesTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.favouritesTreeView_NodeMouseDoubleClick);
            this.favouritesTreeView.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.favouritesTreeView_BeforeExpand);
            this.favouritesTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.favouritesTreeView_NodeMouseClick);
            // 
            // favouritesContextMenu
            // 
            this.favouritesContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteFavouriteToolStripMenuItem,
            this.EditFavouriteToolStripMenuItem});
            this.favouritesContextMenu.Name = "favouritesContextMenu";
            this.favouritesContextMenu.Size = new System.Drawing.Size(160, 48);
            // 
            // DeleteFavouriteToolStripMenuItem
            // 
            this.DeleteFavouriteToolStripMenuItem.Name = "DeleteFavouriteToolStripMenuItem";
            this.DeleteFavouriteToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.DeleteFavouriteToolStripMenuItem.Text = "Delete Favourite";
            this.DeleteFavouriteToolStripMenuItem.Click += new System.EventHandler(this.DeleteFavouriteToolStripMenuItem_Click);
            // 
            // EditFavouriteToolStripMenuItem
            // 
            this.EditFavouriteToolStripMenuItem.Name = "EditFavouriteToolStripMenuItem";
            this.EditFavouriteToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.EditFavouriteToolStripMenuItem.Text = "Edit Favourite...";
            this.EditFavouriteToolStripMenuItem.Click += new System.EventHandler(this.EditFavouriteToolStripMenuItem_Click);
            // 
            // feedsTabPage
            // 
            this.feedsTabPage.Location = new System.Drawing.Point(4, 22);
            this.feedsTabPage.Name = "feedsTabPage";
            this.feedsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.feedsTabPage.Size = new System.Drawing.Size(292, 469);
            this.feedsTabPage.TabIndex = 1;
            this.feedsTabPage.Text = "Feeds";
            this.feedsTabPage.UseVisualStyleBackColor = true;
            // 
            // historyTabPage
            // 
            this.historyTabPage.Location = new System.Drawing.Point(4, 22);
            this.historyTabPage.Name = "historyTabPage";
            this.historyTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.historyTabPage.Size = new System.Drawing.Size(292, 469);
            this.historyTabPage.TabIndex = 2;
            this.historyTabPage.Text = "History";
            this.historyTabPage.UseVisualStyleBackColor = true;
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 49);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.favouritesTabControl);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.tabs);
            this.mainSplitContainer.Size = new System.Drawing.Size(903, 495);
            this.mainSplitContainer.SplitterDistance = 300;
            this.mainSplitContainer.TabIndex = 6;
            // 
            // tabs
            // 
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(599, 495);
            this.tabs.TabIndex = 0;
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTabMenuItem,
            openMenuItem,
            this.closeTabMenuItem,
            this.fileMenuSeparator1,
            exitMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileMenuItem.Text = "&File";
            // 
            // newTabMenuItem
            // 
            this.newTabMenuItem.Name = "newTabMenuItem";
            this.newTabMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newTabMenuItem.Size = new System.Drawing.Size(164, 22);
            this.newTabMenuItem.Text = "&New Tab";
            this.newTabMenuItem.Click += new System.EventHandler(this.newTabMenuItem_Click);
            // 
            // closeTabMenuItem
            // 
            this.closeTabMenuItem.Enabled = false;
            this.closeTabMenuItem.Name = "closeTabMenuItem";
            this.closeTabMenuItem.Size = new System.Drawing.Size(164, 22);
            this.closeTabMenuItem.Text = "&Close Tab";
            this.closeTabMenuItem.Click += new System.EventHandler(this.closeTabMenuItem_Click);
            // 
            // fileMenuSeparator1
            // 
            this.fileMenuSeparator1.Name = "fileMenuSeparator1";
            this.fileMenuSeparator1.Size = new System.Drawing.Size(161, 6);
            // 
            // viewMenuItem
            // 
            this.viewMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshMenuItem,
            this.stopMenuItem});
            this.viewMenuItem.Name = "viewMenuItem";
            this.viewMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewMenuItem.Text = "&View";
            // 
            // refreshMenuItem
            // 
            this.refreshMenuItem.Enabled = false;
            this.refreshMenuItem.Name = "refreshMenuItem";
            this.refreshMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.refreshMenuItem.Size = new System.Drawing.Size(154, 22);
            this.refreshMenuItem.Text = "&Refresh";
            this.refreshMenuItem.Click += new System.EventHandler(this.refreshMenuItem_Click);
            // 
            // stopMenuItem
            // 
            this.stopMenuItem.Enabled = false;
            this.stopMenuItem.Name = "stopMenuItem";
            this.stopMenuItem.Size = new System.Drawing.Size(154, 22);
            this.stopMenuItem.Text = "&Stop";
            this.stopMenuItem.Click += new System.EventHandler(this.stopMenuItem_Click);
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.viewMenuItem,
            this.historyMenuItem,
            this.toolsMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(903, 24);
            this.mainMenu.TabIndex = 3;
            this.mainMenu.Text = "menuStrip1";
            // 
            // historyMenuItem
            // 
            this.historyMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backMenuItem,
            this.forwardMenuItem,
            this.homeMenuItem});
            this.historyMenuItem.Name = "historyMenuItem";
            this.historyMenuItem.Size = new System.Drawing.Size(57, 20);
            this.historyMenuItem.Text = "Hi&story";
            // 
            // backMenuItem
            // 
            this.backMenuItem.Enabled = false;
            this.backMenuItem.Name = "backMenuItem";
            this.backMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Left)));
            this.backMenuItem.Size = new System.Drawing.Size(179, 22);
            this.backMenuItem.Text = "&Back";
            this.backMenuItem.Click += new System.EventHandler(this.backMenuItem_Click);
            // 
            // forwardMenuItem
            // 
            this.forwardMenuItem.Enabled = false;
            this.forwardMenuItem.Name = "forwardMenuItem";
            this.forwardMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Right)));
            this.forwardMenuItem.Size = new System.Drawing.Size(179, 22);
            this.forwardMenuItem.Text = "For&ward";
            this.forwardMenuItem.Click += new System.EventHandler(this.forwardMenuItem_Click);
            // 
            // homeMenuItem
            // 
            this.homeMenuItem.Name = "homeMenuItem";
            this.homeMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.homeMenuItem.Size = new System.Drawing.Size(179, 22);
            this.homeMenuItem.Text = "H&ome";
            this.homeMenuItem.Click += new System.EventHandler(this.homeMenuItem_Click);
            // 
            // toolsMenuItem
            // 
            this.toolsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsMenuItem});
            this.toolsMenuItem.Name = "toolsMenuItem";
            this.toolsMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsMenuItem.Text = "&Tools";
            // 
            // optionsMenuItem
            // 
            this.optionsMenuItem.Name = "optionsMenuItem";
            this.optionsMenuItem.Size = new System.Drawing.Size(125, 22);
            this.optionsMenuItem.Text = "&Options...";
            this.optionsMenuItem.Click += new System.EventHandler(this.optionsMenuItem_Click);
            // 
            // pageLoadProgress
            // 
            this.pageLoadProgress.Name = "pageLoadProgress";
            this.pageLoadProgress.Size = new System.Drawing.Size(100, 16);
            this.pageLoadProgress.Visible = false;
            // 
            // statusbar
            // 
            this.statusbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.browserStatusTextLabel,
            this.pageLoadProgress});
            this.statusbar.Location = new System.Drawing.Point(0, 544);
            this.statusbar.Name = "statusbar";
            this.statusbar.Size = new System.Drawing.Size(903, 22);
            this.statusbar.TabIndex = 5;
            this.statusbar.Text = "statusStrip1";
            // 
            // browserStatusTextLabel
            // 
            this.browserStatusTextLabel.Name = "browserStatusTextLabel";
            this.browserStatusTextLabel.Size = new System.Drawing.Size(888, 17);
            this.browserStatusTextLabel.Spring = true;
            this.browserStatusTextLabel.Text = "toolStripStatusLabel1";
            this.browserStatusTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // forwardButton
            // 
            this.forwardButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.forwardButton.Enabled = false;
            this.forwardButton.Image = ((System.Drawing.Image)(resources.GetObject("forwardButton.Image")));
            this.forwardButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(23, 22);
            this.forwardButton.Text = "Forward";
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refreshButton.Enabled = false;
            this.refreshButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshButton.Image")));
            this.refreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(23, 22);
            this.refreshButton.Text = "Refresh";
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stopButton.Enabled = false;
            this.stopButton.Image = ((System.Drawing.Image)(resources.GetObject("stopButton.Image")));
            this.stopButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(23, 22);
            this.stopButton.Text = "Text";
            this.stopButton.ToolTipText = "Stop";
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // favouritesButton
            // 
            this.favouritesButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToFavouritesMenuItem});
            this.favouritesButton.Image = ((System.Drawing.Image)(resources.GetObject("favouritesButton.Image")));
            this.favouritesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.favouritesButton.Name = "favouritesButton";
            this.favouritesButton.Size = new System.Drawing.Size(93, 22);
            this.favouritesButton.Text = "Favourites";
            this.favouritesButton.ButtonClick += new System.EventHandler(this.favouritesButton_ButtonClick);
            // 
            // AddToFavouritesMenuItem
            // 
            this.AddToFavouritesMenuItem.Name = "AddToFavouritesMenuItem";
            this.AddToFavouritesMenuItem.Size = new System.Drawing.Size(179, 22);
            this.AddToFavouritesMenuItem.Text = "Add To Favourites...";
            this.AddToFavouritesMenuItem.Click += new System.EventHandler(this.AddToFavouritesMenuItem_Click);
            // 
            // closeTabButton
            // 
            this.closeTabButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.closeTabButton.Enabled = false;
            this.closeTabButton.Image = ((System.Drawing.Image)(resources.GetObject("closeTabButton.Image")));
            this.closeTabButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.closeTabButton.Name = "closeTabButton";
            this.closeTabButton.Size = new System.Drawing.Size(23, 22);
            this.closeTabButton.Text = "Close Tab";
            this.closeTabButton.ToolTipText = "Close Tab";
            this.closeTabButton.Click += new System.EventHandler(this.closeTabButton_Click);
            // 
            // addressCombo
            // 
            this.addressCombo.AutoSize = false;
            this.addressCombo.Name = "addressCombo";
            this.addressCombo.Size = new System.Drawing.Size(510, 23);
            this.addressCombo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addressCombo_KeyDown);
            // 
            // goButton
            // 
            this.goButton.Image = ((System.Drawing.Image)(resources.GetObject("goButton.Image")));
            this.goButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(42, 22);
            this.goButton.Text = "Go";
            this.goButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.goButton.ToolTipText = "Go";
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // toolbar
            // 
            this.toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backButton,
            this.forwardButton,
            this.refreshButton,
            this.stopButton,
            this.favouritesButton,
            homeButton,
            toolbarSeparator1,
            newTabButton,
            this.closeTabButton,
            toolbarSeparator2,
            addressLabel,
            this.addressCombo,
            this.goButton});
            this.toolbar.Location = new System.Drawing.Point(0, 24);
            this.toolbar.Name = "toolbar";
            this.toolbar.Size = new System.Drawing.Size(903, 25);
            this.toolbar.TabIndex = 4;
            this.toolbar.Text = "toolStrip1";
            // 
            // backButton
            // 
            this.backButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.backButton.Enabled = false;
            this.backButton.Image = ((System.Drawing.Image)(resources.GetObject("backButton.Image")));
            this.backButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(23, 22);
            this.backButton.Text = "Back";
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 566);
            this.Controls.Add(this.mainSplitContainer);
            this.Controls.Add(this.toolbar);
            this.Controls.Add(this.statusbar);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Enhanced C# Tabbed Web Browser";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.SizeChanged += new System.EventHandler(this.MainWindow_SizeChanged);
            this.favouritesTabControl.ResumeLayout(false);
            this.favouritesTabPage.ResumeLayout(false);
            this.favouritesContextMenu.ResumeLayout(false);
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            this.mainSplitContainer.ResumeLayout(false);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statusbar.ResumeLayout(false);
            this.statusbar.PerformLayout();
            this.toolbar.ResumeLayout(false);
            this.toolbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl favouritesTabControl;
        private System.Windows.Forms.TabPage favouritesTabPage;
        private System.Windows.Forms.TreeView favouritesTreeView;
        private System.Windows.Forms.TabPage feedsTabPage;
        private System.Windows.Forms.TabPage historyTabPage;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private Enhanced_CS_Tabbed_Web_Browser.WebBrowserTabControl tabs;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTabMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeTabMenuItem;
        private System.Windows.Forms.ToolStripSeparator fileMenuSeparator1;
        private System.Windows.Forms.ToolStripMenuItem viewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopMenuItem;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem historyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forwardMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsMenuItem;
        private System.Windows.Forms.ToolStripProgressBar pageLoadProgress;
        private System.Windows.Forms.StatusStrip statusbar;
        private System.Windows.Forms.ToolStripStatusLabel browserStatusTextLabel;
        private System.Windows.Forms.ToolStripButton forwardButton;
        private System.Windows.Forms.ToolStripButton refreshButton;
        private System.Windows.Forms.ToolStripButton stopButton;
        internal System.Windows.Forms.ToolStripSplitButton favouritesButton;
        internal System.Windows.Forms.ToolStripMenuItem AddToFavouritesMenuItem;
        private System.Windows.Forms.ToolStripButton closeTabButton;
        private System.Windows.Forms.ToolStripComboBox addressCombo;
        private System.Windows.Forms.ToolStripButton goButton;
        private System.Windows.Forms.ToolStrip toolbar;
        private System.Windows.Forms.ToolStripButton backButton;
        internal System.Windows.Forms.ContextMenuStrip favouritesContextMenu;
        internal System.Windows.Forms.ToolStripMenuItem DeleteFavouriteToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem EditFavouriteToolStripMenuItem;


    }
}