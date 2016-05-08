<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim toolbarSeparator1 As System.Windows.Forms.ToolStripSeparator
        Dim newTabButton As System.Windows.Forms.ToolStripButton
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Dim fileMenuItem As System.Windows.Forms.ToolStripMenuItem
        Dim openMenuItem As System.Windows.Forms.ToolStripMenuItem
        Dim fileMenuSeparator1 As System.Windows.Forms.ToolStripSeparator
        Dim exitMenuItem As System.Windows.Forms.ToolStripMenuItem
        Dim viewMenuItem As System.Windows.Forms.ToolStripMenuItem
        Dim historyMenuItem As System.Windows.Forms.ToolStripMenuItem
        Dim toolbarSeparator2 As System.Windows.Forms.ToolStripSeparator
        Dim addressLabel As System.Windows.Forms.ToolStripLabel
        Dim homeButton As System.Windows.Forms.ToolStripButton
        Dim toolsMenuItem As System.Windows.Forms.ToolStripMenuItem
        Dim optionsMenuItem As System.Windows.Forms.ToolStripMenuItem
        Me.newTabMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.closeTabMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.refreshMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.stopMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.backMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.forwardMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.homeMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.goButton = New System.Windows.Forms.ToolStripButton()
        Me.mainMenu = New System.Windows.Forms.MenuStrip()
        Me.toolbar = New System.Windows.Forms.ToolStrip()
        Me.backButton = New System.Windows.Forms.ToolStripButton()
        Me.forwardButton = New System.Windows.Forms.ToolStripButton()
        Me.refreshButton = New System.Windows.Forms.ToolStripButton()
        Me.stopButton = New System.Windows.Forms.ToolStripButton()
        Me.favouritesButton = New System.Windows.Forms.ToolStripSplitButton()
        Me.AddToFavouritesMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.closeTabButton = New System.Windows.Forms.ToolStripButton()
        Me.addressCombo = New System.Windows.Forms.ToolStripComboBox()
        Me.statusbar = New System.Windows.Forms.StatusStrip()
        Me.browserStatusTextLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pageLoadProgress = New System.Windows.Forms.ToolStripProgressBar()
        Me.MainSplitContainer = New System.Windows.Forms.SplitContainer()
        Me.FavouritesTabControl = New System.Windows.Forms.TabControl()
        Me.FavouritesTabPage = New System.Windows.Forms.TabPage()
        Me.FavouritesTreeView = New System.Windows.Forms.TreeView()
        Me.favouritesContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteFavouriteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditFavouriteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FeedsTabPage = New System.Windows.Forms.TabPage()
        Me.HistoryTabPage = New System.Windows.Forms.TabPage()
        Me.tabs = New Enhanced_VB_Tabbed_Web_Browser.WebBrowserTabControl()
        Me.iconImageList = New System.Windows.Forms.ImageList(Me.components)
        toolbarSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        newTabButton = New System.Windows.Forms.ToolStripButton()
        fileMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        openMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        fileMenuSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        exitMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        viewMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        historyMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        toolbarSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        addressLabel = New System.Windows.Forms.ToolStripLabel()
        homeButton = New System.Windows.Forms.ToolStripButton()
        toolsMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        optionsMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mainMenu.SuspendLayout
        Me.toolbar.SuspendLayout
        Me.statusbar.SuspendLayout
        Me.MainSplitContainer.Panel1.SuspendLayout
        Me.MainSplitContainer.Panel2.SuspendLayout
        Me.MainSplitContainer.SuspendLayout
        Me.FavouritesTabControl.SuspendLayout
        Me.FavouritesTabPage.SuspendLayout
        Me.favouritesContextMenu.SuspendLayout
        Me.SuspendLayout
        '
        'toolbarSeparator1
        '
        toolbarSeparator1.Name = "toolbarSeparator1"
        toolbarSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'newTabButton
        '
        newTabButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        newTabButton.Image = CType(resources.GetObject("newTabButton.Image"),System.Drawing.Image)
        newTabButton.ImageTransparentColor = System.Drawing.Color.Magenta
        newTabButton.Name = "newTabButton"
        newTabButton.Size = New System.Drawing.Size(23, 22)
        newTabButton.Text = "New Tab"
        AddHandler newTabButton.Click, AddressOf Me.newTabButton_Click
        '
        'fileMenuItem
        '
        fileMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.newTabMenuItem, openMenuItem, Me.closeTabMenuItem, fileMenuSeparator1, exitMenuItem})
        fileMenuItem.Name = "fileMenuItem"
        fileMenuItem.Size = New System.Drawing.Size(37, 20)
        fileMenuItem.Text = "&File"
        '
        'newTabMenuItem
        '
        Me.newTabMenuItem.Image = CType(resources.GetObject("newTabMenuItem.Image"),System.Drawing.Image)
        Me.newTabMenuItem.Name = "newTabMenuItem"
        Me.newTabMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N),System.Windows.Forms.Keys)
        Me.newTabMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.newTabMenuItem.Text = "&New Tab"
        '
        'openMenuItem
        '
        openMenuItem.Enabled = false
        openMenuItem.Name = "openMenuItem"
        openMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O),System.Windows.Forms.Keys)
        openMenuItem.Size = New System.Drawing.Size(164, 22)
        openMenuItem.Text = "&Open..."
        AddHandler openMenuItem.Click, AddressOf Me.openMenuItem_Click
        '
        'closeTabMenuItem
        '
        Me.closeTabMenuItem.Enabled = false
        Me.closeTabMenuItem.Image = CType(resources.GetObject("closeTabMenuItem.Image"),System.Drawing.Image)
        Me.closeTabMenuItem.Name = "closeTabMenuItem"
        Me.closeTabMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.closeTabMenuItem.Text = "&Close Tab"
        '
        'fileMenuSeparator1
        '
        fileMenuSeparator1.Name = "fileMenuSeparator1"
        fileMenuSeparator1.Size = New System.Drawing.Size(161, 6)
        '
        'exitMenuItem
        '
        exitMenuItem.Image = CType(resources.GetObject("exitMenuItem.Image"),System.Drawing.Image)
        exitMenuItem.Name = "exitMenuItem"
        exitMenuItem.Size = New System.Drawing.Size(164, 22)
        exitMenuItem.Text = "E&xit"
        AddHandler exitMenuItem.Click, AddressOf Me.exitMenuItem_Click
        '
        'viewMenuItem
        '
        viewMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.refreshMenuItem, Me.stopMenuItem})
        viewMenuItem.Name = "viewMenuItem"
        viewMenuItem.Size = New System.Drawing.Size(44, 20)
        viewMenuItem.Text = "&View"
        '
        'refreshMenuItem
        '
        Me.refreshMenuItem.Enabled = false
        Me.refreshMenuItem.Image = CType(resources.GetObject("refreshMenuItem.Image"),System.Drawing.Image)
        Me.refreshMenuItem.Name = "refreshMenuItem"
        Me.refreshMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R),System.Windows.Forms.Keys)
        Me.refreshMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.refreshMenuItem.Text = "&Refresh"
        '
        'stopMenuItem
        '
        Me.stopMenuItem.Enabled = false
        Me.stopMenuItem.Image = CType(resources.GetObject("stopMenuItem.Image"),System.Drawing.Image)
        Me.stopMenuItem.Name = "stopMenuItem"
        Me.stopMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.stopMenuItem.Text = "&Stop"
        '
        'historyMenuItem
        '
        historyMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.backMenuItem, Me.forwardMenuItem, Me.homeMenuItem})
        historyMenuItem.Name = "historyMenuItem"
        historyMenuItem.Size = New System.Drawing.Size(57, 20)
        historyMenuItem.Text = "Hi&story"
        '
        'backMenuItem
        '
        Me.backMenuItem.Enabled = false
        Me.backMenuItem.Image = CType(resources.GetObject("backMenuItem.Image"),System.Drawing.Image)
        Me.backMenuItem.Name = "backMenuItem"
        Me.backMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Left),System.Windows.Forms.Keys)
        Me.backMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.backMenuItem.Text = "&Back"
        '
        'forwardMenuItem
        '
        Me.forwardMenuItem.Enabled = false
        Me.forwardMenuItem.Image = CType(resources.GetObject("forwardMenuItem.Image"),System.Drawing.Image)
        Me.forwardMenuItem.Name = "forwardMenuItem"
        Me.forwardMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Right),System.Windows.Forms.Keys)
        Me.forwardMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.forwardMenuItem.Text = "For&ward"
        '
        'homeMenuItem
        '
        Me.homeMenuItem.Image = CType(resources.GetObject("homeMenuItem.Image"),System.Drawing.Image)
        Me.homeMenuItem.Name = "homeMenuItem"
        Me.homeMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H),System.Windows.Forms.Keys)
        Me.homeMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.homeMenuItem.Text = "H&ome"
        '
        'toolbarSeparator2
        '
        toolbarSeparator2.Name = "toolbarSeparator2"
        toolbarSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'addressLabel
        '
        addressLabel.Name = "addressLabel"
        addressLabel.Size = New System.Drawing.Size(52, 22)
        addressLabel.Text = "Address:"
        '
        'homeButton
        '
        homeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        homeButton.Image = CType(resources.GetObject("homeButton.Image"),System.Drawing.Image)
        homeButton.ImageTransparentColor = System.Drawing.Color.Magenta
        homeButton.Name = "homeButton"
        homeButton.Size = New System.Drawing.Size(23, 22)
        homeButton.Text = "Home"
        AddHandler homeButton.Click, AddressOf Me.homeButton_Click
        '
        'toolsMenuItem
        '
        toolsMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {optionsMenuItem})
        toolsMenuItem.Name = "toolsMenuItem"
        toolsMenuItem.Size = New System.Drawing.Size(48, 20)
        toolsMenuItem.Text = "&Tools"
        '
        'optionsMenuItem
        '
        optionsMenuItem.Image = CType(resources.GetObject("optionsMenuItem.Image"),System.Drawing.Image)
        optionsMenuItem.Name = "optionsMenuItem"
        optionsMenuItem.Size = New System.Drawing.Size(125, 22)
        optionsMenuItem.Text = "&Options..."
        AddHandler optionsMenuItem.Click, AddressOf Me.optionsMenuItem_Click
        '
        'goButton
        '
        Me.goButton.Image = CType(resources.GetObject("goButton.Image"),System.Drawing.Image)
        Me.goButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.goButton.Name = "goButton"
        Me.goButton.Size = New System.Drawing.Size(42, 22)
        Me.goButton.Text = "Go"
        Me.goButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'mainMenu
        '
        Me.mainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {fileMenuItem, viewMenuItem, historyMenuItem, toolsMenuItem})
        Me.mainMenu.Location = New System.Drawing.Point(0, 0)
        Me.mainMenu.Name = "mainMenu"
        Me.mainMenu.Size = New System.Drawing.Size(897, 24)
        Me.mainMenu.TabIndex = 0
        Me.mainMenu.Text = "MenuStrip1"
        '
        'toolbar
        '
        Me.toolbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.backButton, Me.forwardButton, Me.refreshButton, Me.stopButton, Me.favouritesButton, homeButton, toolbarSeparator1, newTabButton, Me.closeTabButton, toolbarSeparator2, addressLabel, Me.addressCombo, Me.goButton})
        Me.toolbar.Location = New System.Drawing.Point(0, 24)
        Me.toolbar.Name = "toolbar"
        Me.toolbar.Size = New System.Drawing.Size(897, 25)
        Me.toolbar.TabIndex = 1
        Me.toolbar.Text = "ToolStrip1"
        '
        'backButton
        '
        Me.backButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.backButton.Enabled = false
        Me.backButton.Image = CType(resources.GetObject("backButton.Image"),System.Drawing.Image)
        Me.backButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(23, 22)
        Me.backButton.Text = "Back"
        '
        'forwardButton
        '
        Me.forwardButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.forwardButton.Enabled = false
        Me.forwardButton.Image = CType(resources.GetObject("forwardButton.Image"),System.Drawing.Image)
        Me.forwardButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.forwardButton.Name = "forwardButton"
        Me.forwardButton.Size = New System.Drawing.Size(23, 22)
        Me.forwardButton.Text = "Forward"
        '
        'refreshButton
        '
        Me.refreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.refreshButton.Enabled = false
        Me.refreshButton.Image = CType(resources.GetObject("refreshButton.Image"),System.Drawing.Image)
        Me.refreshButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.refreshButton.Name = "refreshButton"
        Me.refreshButton.Size = New System.Drawing.Size(23, 22)
        Me.refreshButton.Text = "Refresh"
        '
        'stopButton
        '
        Me.stopButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.stopButton.Enabled = false
        Me.stopButton.Image = CType(resources.GetObject("stopButton.Image"),System.Drawing.Image)
        Me.stopButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.stopButton.Name = "stopButton"
        Me.stopButton.Size = New System.Drawing.Size(23, 22)
        Me.stopButton.Text = "Stop"
        '
        'favouritesButton
        '
        Me.favouritesButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToFavouritesMenuItem})
        Me.favouritesButton.Image = Global.Enhanced_VB_Tabbed_Web_Browser.My.Resources.Resources.star
        Me.favouritesButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.favouritesButton.Name = "favouritesButton"
        Me.favouritesButton.Size = New System.Drawing.Size(93, 22)
        Me.favouritesButton.Text = "Favourites"
        '
        'AddToFavouritesMenuItem
        '
        Me.AddToFavouritesMenuItem.Name = "AddToFavouritesMenuItem"
        Me.AddToFavouritesMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.AddToFavouritesMenuItem.Text = "Add To Favourites..."
        '
        'closeTabButton
        '
        Me.closeTabButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.closeTabButton.Enabled = false
        Me.closeTabButton.Image = CType(resources.GetObject("closeTabButton.Image"),System.Drawing.Image)
        Me.closeTabButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.closeTabButton.Name = "closeTabButton"
        Me.closeTabButton.Size = New System.Drawing.Size(23, 22)
        Me.closeTabButton.Text = "Close Tab"
        '
        'addressCombo
        '
        Me.addressCombo.AutoSize = false
        Me.addressCombo.Name = "addressCombo"
        Me.addressCombo.Size = New System.Drawing.Size(510, 23)
        '
        'statusbar
        '
        Me.statusbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.browserStatusTextLabel, Me.pageLoadProgress})
        Me.statusbar.Location = New System.Drawing.Point(0, 544)
        Me.statusbar.Name = "statusbar"
        Me.statusbar.Size = New System.Drawing.Size(897, 22)
        Me.statusbar.TabIndex = 2
        Me.statusbar.Text = "StatusStrip1"
        '
        'browserStatusTextLabel
        '
        Me.browserStatusTextLabel.Name = "browserStatusTextLabel"
        Me.browserStatusTextLabel.Size = New System.Drawing.Size(882, 17)
        Me.browserStatusTextLabel.Spring = true
        Me.browserStatusTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pageLoadProgress
        '
        Me.pageLoadProgress.Name = "pageLoadProgress"
        Me.pageLoadProgress.Size = New System.Drawing.Size(100, 16)
        Me.pageLoadProgress.Visible = false
        '
        'MainSplitContainer
        '
        Me.MainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainSplitContainer.Location = New System.Drawing.Point(0, 49)
        Me.MainSplitContainer.Name = "MainSplitContainer"
        '
        'MainSplitContainer.Panel1
        '
        Me.MainSplitContainer.Panel1.Controls.Add(Me.FavouritesTabControl)
        '
        'MainSplitContainer.Panel2
        '
        Me.MainSplitContainer.Panel2.Controls.Add(Me.tabs)
        Me.MainSplitContainer.Size = New System.Drawing.Size(897, 495)
        Me.MainSplitContainer.SplitterDistance = 299
        Me.MainSplitContainer.TabIndex = 4
        '
        'FavouritesTabControl
        '
        Me.FavouritesTabControl.Controls.Add(Me.FavouritesTabPage)
        Me.FavouritesTabControl.Controls.Add(Me.FeedsTabPage)
        Me.FavouritesTabControl.Controls.Add(Me.HistoryTabPage)
        Me.FavouritesTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FavouritesTabControl.Location = New System.Drawing.Point(0, 0)
        Me.FavouritesTabControl.Name = "FavouritesTabControl"
        Me.FavouritesTabControl.SelectedIndex = 0
        Me.FavouritesTabControl.Size = New System.Drawing.Size(299, 495)
        Me.FavouritesTabControl.TabIndex = 0
        '
        'FavouritesTabPage
        '
        Me.FavouritesTabPage.Controls.Add(Me.FavouritesTreeView)
        Me.FavouritesTabPage.Location = New System.Drawing.Point(4, 22)
        Me.FavouritesTabPage.Name = "FavouritesTabPage"
        Me.FavouritesTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.FavouritesTabPage.Size = New System.Drawing.Size(291, 469)
        Me.FavouritesTabPage.TabIndex = 0
        Me.FavouritesTabPage.Text = "Favourites"
        Me.FavouritesTabPage.UseVisualStyleBackColor = true
        '
        'FavouritesTreeView
        '
        Me.FavouritesTreeView.ContextMenuStrip = Me.favouritesContextMenu
        Me.FavouritesTreeView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FavouritesTreeView.Location = New System.Drawing.Point(3, 3)
        Me.FavouritesTreeView.Name = "FavouritesTreeView"
        Me.FavouritesTreeView.Size = New System.Drawing.Size(285, 463)
        Me.FavouritesTreeView.TabIndex = 0
        '
        'favouritesContextMenu
        '
        Me.favouritesContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteFavouriteToolStripMenuItem, Me.EditFavouriteToolStripMenuItem})
        Me.favouritesContextMenu.Name = "favouritesContextMenu"
        Me.favouritesContextMenu.Size = New System.Drawing.Size(160, 48)
        '
        'DeleteFavouriteToolStripMenuItem
        '
        Me.DeleteFavouriteToolStripMenuItem.Name = "DeleteFavouriteToolStripMenuItem"
        Me.DeleteFavouriteToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.DeleteFavouriteToolStripMenuItem.Text = "Delete Favourite"
        '
        'EditFavouriteToolStripMenuItem
        '
        Me.EditFavouriteToolStripMenuItem.Name = "EditFavouriteToolStripMenuItem"
        Me.EditFavouriteToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.EditFavouriteToolStripMenuItem.Text = "Edit Favourite..."
        '
        'FeedsTabPage
        '
        Me.FeedsTabPage.Location = New System.Drawing.Point(4, 22)
        Me.FeedsTabPage.Name = "FeedsTabPage"
        Me.FeedsTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.FeedsTabPage.Size = New System.Drawing.Size(291, 469)
        Me.FeedsTabPage.TabIndex = 1
        Me.FeedsTabPage.Text = "Feeds"
        Me.FeedsTabPage.UseVisualStyleBackColor = true
        '
        'HistoryTabPage
        '
        Me.HistoryTabPage.Location = New System.Drawing.Point(4, 22)
        Me.HistoryTabPage.Name = "HistoryTabPage"
        Me.HistoryTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.HistoryTabPage.Size = New System.Drawing.Size(291, 469)
        Me.HistoryTabPage.TabIndex = 2
        Me.HistoryTabPage.Text = "History"
        Me.HistoryTabPage.UseVisualStyleBackColor = true
        '
        'tabs
        '
        Me.tabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabs.Location = New System.Drawing.Point(0, 0)
        Me.tabs.Name = "tabs"
        Me.tabs.SelectedIndex = 0
        Me.tabs.Size = New System.Drawing.Size(594, 495)
        Me.tabs.TabIndex = 3
        '
        'iconImageList
        '
        Me.iconImageList.ImageStream = CType(resources.GetObject("iconImageList.ImageStream"),System.Windows.Forms.ImageListStreamer)
        Me.iconImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.iconImageList.Images.SetKeyName(0, "folder.png")
        Me.iconImageList.Images.SetKeyName(1, "world_link.png")
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(897, 566)
        Me.Controls.Add(Me.MainSplitContainer)
        Me.Controls.Add(Me.statusbar)
        Me.Controls.Add(Me.toolbar)
        Me.Controls.Add(Me.mainMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MainMenuStrip = Me.mainMenu
        Me.Name = "MainWindow"
        Me.Text = "Enhanced VB.Net Tabbed Web Browser"
        Me.mainMenu.ResumeLayout(false)
        Me.mainMenu.PerformLayout
        Me.toolbar.ResumeLayout(false)
        Me.toolbar.PerformLayout
        Me.statusbar.ResumeLayout(false)
        Me.statusbar.PerformLayout
        Me.MainSplitContainer.Panel1.ResumeLayout(false)
        Me.MainSplitContainer.Panel2.ResumeLayout(false)
        Me.MainSplitContainer.ResumeLayout(false)
        Me.FavouritesTabControl.ResumeLayout(false)
        Me.FavouritesTabPage.ResumeLayout(false)
        Me.favouritesContextMenu.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Private WithEvents backButton As System.Windows.Forms.ToolStripButton
    Private WithEvents forwardButton As System.Windows.Forms.ToolStripButton
    Private WithEvents refreshButton As System.Windows.Forms.ToolStripButton
    Private WithEvents stopButton As System.Windows.Forms.ToolStripButton
    Private WithEvents closeTabMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents closeTabButton As System.Windows.Forms.ToolStripButton
    Private WithEvents refreshMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents stopMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents backMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents forwardMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents newTabMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents addressCombo As System.Windows.Forms.ToolStripComboBox
    Private WithEvents mainMenu As System.Windows.Forms.MenuStrip
    Private WithEvents toolbar As System.Windows.Forms.ToolStrip
    Private WithEvents statusbar As System.Windows.Forms.StatusStrip
    Private WithEvents tabs As WebBrowserTabControl
    Private WithEvents goButton As System.Windows.Forms.ToolStripButton
    Private WithEvents browserStatusTextLabel As System.Windows.Forms.ToolStripStatusLabel
    Private WithEvents pageLoadProgress As System.Windows.Forms.ToolStripProgressBar
    Private WithEvents homeMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents favouritesButton As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents AddToFavouritesMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainSplitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents FavouritesTabControl As System.Windows.Forms.TabControl
    Friend WithEvents FavouritesTabPage As System.Windows.Forms.TabPage
    Friend WithEvents FavouritesTreeView As System.Windows.Forms.TreeView
    Friend WithEvents favouritesContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteFavouriteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditFavouriteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FeedsTabPage As System.Windows.Forms.TabPage
    Friend WithEvents HistoryTabPage As System.Windows.Forms.TabPage
    Friend WithEvents iconImageList As ImageList
End Class
