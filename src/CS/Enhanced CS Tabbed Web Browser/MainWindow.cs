﻿using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Enhanced_CS_Tabbed_Web_Browser
{
    /// <summary>
    /// The main window for the tabbed web browser application.
    /// </summary>
    public partial class MainWindow : Form
    {
        #region PInvokes

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
        static extern uint GetPrivateProfileString(
           string lpAppName,
           string lpKeyName,
           string lpDefault,
           StringBuilder lpReturnedString,
           uint nSize,
           string lpFileName);

        #endregion

        #region Variables

        /// <summary>
        /// The difference in width between the window and the address field in the tool bar.
        /// </summary>
        private readonly int addressFieldSizeOffset;

        /// <summary>
        /// The <b>WebBrowser</b> control on the current tab.
        /// </summary>
        private WebBrowser currentBrowser;

        /// <summary>
        /// The <b>StringBuilder</b> used to retrieve information from PInvoke calls
        /// </summary>
        /// <remarks>
        /// Initialized with a value of 500, it is expected that Favourite Url's will not be longer than this
        /// </remarks>
        private StringBuilder sb = new StringBuilder(500);
        private StringBuilder sb1 = new StringBuilder(500);

        /// <summary>
        /// The <b>Integer</b> to hold the result of the PInvoke calls
        /// </summary>
        private uint result;

        #endregion

        #region Constructors

        /// <summary>
        /// Creates a new instance of the <see cref="MainWindow" /> class.
        /// </summary>
        public MainWindow()
        {
            // This call is required by the Windows Form Designer.
            InitializeComponent();

            // Add any initialization after the InitializeComponent() call.

            // Get the initial difference between the form width and address field width.
            // This value will be maintained as the window width changes.
            this.addressFieldSizeOffset = this.Width - this.addressCombo.Width;
        }

        #endregion

        #region Event Handlers

        private void MainWindow_Load(object sender, EventArgs e)
        {
            // Add the default Tab
            this.tabs.AddTab();
            this.currentBrowser = this.tabs.SelectedWebBrowser;

            if (Properties.Settings.Default.StartWithHomePage && !string.IsNullOrEmpty(Properties.Settings.Default.HomePage))
            {
                // Load the home page.
                this.currentBrowser.Navigate(Properties.Settings.Default.HomePage);
            }

            this.currentBrowser.StatusTextChanged += new EventHandler(currentBrowser_StatusTextChanged);
            this.currentBrowser.Navigated += new WebBrowserNavigatedEventHandler(currentBrowser_Navigated);
            this.currentBrowser.CanGoBackChanged += new EventHandler(currentBrowser_CanGoBackChanged);
            this.currentBrowser.CanGoForwardChanged += new EventHandler(currentBrowser_CanGoForwardChanged);
            this.currentBrowser.ProgressChanged += new WebBrowserProgressChangedEventHandler(currentBrowser_ProgressChanged);
            this.currentBrowser.DocumentTitleChanged += new EventHandler(currentBrowser_DocumentTitleChanged);
            this.currentBrowser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(currentBrowser_DocumentCompleted);

            this.favouritesTreeView.ImageList = this.iconImageList;

            this.GetFavourites();
        }

        private void MainWindow_SizeChanged(object sender, EventArgs e)
        {
            if (this.addressFieldSizeOffset > 0)
            {
                // Maintain the original width difference between the form and the address
                // without allowing the address field to become less than 100 pixels wide.
                this.addressCombo.Width = Math.Max(50, this.Width - this.addressFieldSizeOffset);
            }
        }

        private void addressCombo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Navigate to the current address.
                this.currentBrowser.Navigate(this.addressCombo.Text);

                // Prevent the sound that indicates an invalid key press.
                e.SuppressKeyPress = true;
            }
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            // Navigate to the current address.
            this.currentBrowser.Navigate(this.addressCombo.Text);
        }

        private void tabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the current browser.
            this.currentBrowser = this.tabs.SelectedWebBrowser;

            this.DisplayPageTitle();

            // Enable the Close Tab command if and only if there is more than one tab.
            if (this.tabs.TabCount == 1)
            {
                this.closeTabMenuItem.Enabled = false;
                this.closeTabButton.Enabled = false;
            }
            else
            {
                this.closeTabMenuItem.Enabled = true;
                this.closeTabButton.Enabled = true;
            }

            Uri url = this.currentBrowser.Url;

            if (url == null)
            {
                // There is no current address.
                this.addressCombo.Text = string.Empty;

                // The user cannot refresh a page that doesn't exist.
                this.refreshMenuItem.Enabled = false;
                this.refreshButton.Enabled = false;
            }
            else
            {
                // Display the current page address in the address bar.
                this.addressCombo.Text = url.ToString();

                // Allow the user to refresh the current page.
                this.refreshMenuItem.Enabled = true;
                this.refreshButton.Enabled = true;
            }

            // Display the current page's status text in the status bar.
            this.browserStatusTextLabel.Text = this.currentBrowser.StatusText;

            WebBrowserTabPage tab = this.tabs.SelectedWebBrowserTagPage;
            long lastCurrentProgress = tab.LastCurrentProgress;
            long lastMaximumProgress = tab.LastMaximumProgress;

            if (lastMaximumProgress > 0L && lastCurrentProgress > 0L)
            {
                // Display the current progress.
                this.pageLoadProgress.Visible = true;
                this.pageLoadProgress.Value = (int)Math.Round(((double)(100 * lastCurrentProgress / lastMaximumProgress)));
            }
            else
            {
                // Hide and reset the progress bar
                this.pageLoadProgress.Visible = false;
                this.pageLoadProgress.Value = 0;
            }
        }

        private void pageLoadProgress_VisibleChanged(object sender, EventArgs e)
        {
            bool canStop = this.pageLoadProgress.Visible;

            // The loading can only be stopped when a page is loading.
            this.stopMenuItem.Enabled = canStop;
            this.stopButton.Enabled = canStop;
        }

        private void favouritesTreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes[0].Text == "*")
            {
                e.Node.Nodes.Clear();
                this.GetFavouritesForDirectory(new DirectoryInfo(e.Node.Tag.ToString()), e.Node);
            }
        }

        private void favouritesTreeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            FavouriteTreeNode myFav = (FavouriteTreeNode)e.Node;
            this.currentBrowser.Navigate(myFav.Url);
        }

        private void favouritesTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.favouritesTreeView.SelectedNode = e.Node;
            }
        }

        #region Main Menu Event Handlers

        #region File Menu Event Handler

        private void newTabMenuItem_Click(object sender, EventArgs e)
        {
            this.tabs.AddTab();
        }

        private void openMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Prompt to open an address in the current tab.
        }

        private void closeTabMenuItem_Click(object sender, EventArgs e)
        {
            this.tabs.RemoveCurrentTab();
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region View Menu Event Handler

        private void refreshMenuItem_Click(object sender, EventArgs e)
        {
            this.currentBrowser.Refresh();

            this.pageLoadProgress.Visible = true;
        }

        private void stopMenuItem_Click(object sender, EventArgs e)
        {
            this.currentBrowser.Stop();
        }

        #endregion

        #region History Menu Event Handler

        private void backMenuItem_Click(object sender, EventArgs e)
        {
            this.currentBrowser.GoBack();
        }

        private void forwardMenuItem_Click(object sender, EventArgs e)
        {
            this.currentBrowser.GoForward();
        }

        private void homeMenuItem_Click(object sender, EventArgs e)
        {
            this.currentBrowser.Navigate(Properties.Settings.Default.HomePage);
        }

        #endregion

        #region Tools Menu Event Handler

        private void optionsMenuItem_Click(object sender, EventArgs e)
        {
            using (OptionsDialogue dialogue = new OptionsDialogue(this.currentBrowser.Url.ToString()))
            {
                dialogue.ShowDialog();
            }
        }

        #endregion

        #endregion

        #region Toolbar Event Handlers

        private void backButton_Click(object sender, EventArgs e)
        {
            this.backMenuItem.PerformClick();
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            this.forwardMenuItem.PerformClick();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            this.refreshMenuItem.PerformClick();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            this.stopMenuItem.PerformClick();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.homeMenuItem.PerformClick();
        }

        private void newTabButton_Click(object sender, EventArgs e)
        {
            this.newTabMenuItem.PerformClick();
        }

        private void closeTabButton_Click(object sender, EventArgs e)
        {
            this.closeTabMenuItem.PerformClick();
        }

        private void favouritesButton_ButtonClick(object sender, EventArgs e)
        {
            this.mainSplitContainer.Panel1Collapsed = !this.mainSplitContainer.Panel1Collapsed;
        }

        private void AddToFavouritesMenuItem_Click(object sender, EventArgs e)
        {
            if (this.addressCombo.Text != "about:blank")
            {
                using (AddFavouriteDialogue favouriteForm = new AddFavouriteDialogue(this.addressCombo.Text, this.Text))
                {
                    favouriteForm.ShowDialog();

                    if (favouriteForm.DialogResult == DialogResult.OK)
                    {
                        this.GetFavourites();
                    }
                }
            }
        }

        #endregion

        #region Web Browser Event Handlers

        private void currentBrowser_StatusTextChanged(object sender, EventArgs e)
        {
            // Display the current page's status text in the status bar.
            this.browserStatusTextLabel.Text = this.currentBrowser.StatusText;
        }

        private void currentBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            // Display the progress bar.
            this.pageLoadProgress.Visible = true;

            // Display the current page address in the address bar.
            this.addressCombo.Text = this.currentBrowser.Url.ToString();
        }

        private void currentBrowser_CanGoBackChanged(object sender, EventArgs e)
        {
            bool canGoBack = this.currentBrowser.CanGoBack;

            this.backButton.Enabled = canGoBack;
            this.backMenuItem.Enabled = canGoBack;
        }

        private void currentBrowser_CanGoForwardChanged(object sender, EventArgs e)
        {
            bool canGoForward = this.currentBrowser.CanGoForward;

            this.forwardButton.Enabled = canGoForward;
            this.forwardMenuItem.Enabled = canGoForward;
        }

        private void currentBrowser_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            this.pageLoadProgress.Visible = true;

            if (e.MaximumProgress > 0L && e.CurrentProgress > 0L)
            {
                // Display the current progress.
                this.pageLoadProgress.Value = (int)Math.Round(((double)(100 * e.CurrentProgress / e.MaximumProgress)));
            }
            else if (e.MaximumProgress == 0L && e.CurrentProgress == 0L)
            {
                // Hide and reset the progress bar.
                this.pageLoadProgress.Visible = false;
                this.pageLoadProgress.Value = 0;
            }
        }

        private void currentBrowser_DocumentTitleChanged(object sender, EventArgs e)
        {
            this.DisplayPageTitle();
        }

        private void currentBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            this.refreshMenuItem.Enabled = true;
            this.refreshButton.Enabled = true;
        }

        #endregion

        #region Context Menu Event Handlers

        private void DeleteFavouriteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show(String.Format("Are you sure you want to delete {0}", this.favouritesTreeView.SelectedNode.Text), "Deletion Check", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if ((this.favouritesTreeView.SelectedNode) is FavouriteTreeNode)
                {
                    string favouritePath = ((FavouriteTreeNode)this.favouritesTreeView.SelectedNode).DirectoryPath.ToString();
                    if (File.Exists(favouritePath)) {
                        File.Delete(favouritePath);
                        this.favouritesTreeView.SelectedNode.Remove();
                    }

                }
            }
        }

        private void EditFavouriteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #endregion

        #region Methods

        /// <summary>
        /// Displays the current page title in the title bar.
        /// </summary>
        /// <remarks>
        /// Only the application name is displayed if no document is loaded.
        /// </remarks>
        private void DisplayPageTitle()
        {
            string documentTitle = this.currentBrowser.DocumentTitle;

            if (string.IsNullOrEmpty(documentTitle))
            {
                this.Text = Application.ProductName;
            }
            else
            {
                // Display the current page title in the window's title bar.
                this.Text = String.Format("{0} - {1}", documentTitle, Application.ProductName);
            }
        }

        /// <summary>
        /// Enumerates the Favourites within the specified directory and adds them to Favourites TreeView
        /// </summary>
        /// <param name="di">
        /// The directory to find the Favourites in
        /// </param>
        /// <param name="dirNode">
        /// The FavouritesTreeView Node to add the Favourites to
        /// </param>
        /// <remarks>
        /// Uses a PInvoke call to GetPrivateProfileString to get Favourite information
        /// </remarks>
        private void GetFavouritesForDirectory(DirectoryInfo di, TreeNode dirNode)
        {
            foreach (DirectoryInfo dirInfo in di.GetDirectories())
            {
                TreeNode newNode = new TreeNode();
                newNode.Text = dirInfo.Name;
                newNode.Tag = dirInfo.FullName;
                newNode.ImageIndex = 0;
                newNode.SelectedImageIndex = 0;

                if (dirNode == null)
                {
                    this.favouritesTreeView.Nodes.Add(newNode);
                }
                else
                {
                    dirNode.Nodes.Add(newNode);
                }

                newNode.Nodes.Add("*");
            }

            var imageKeyIndex = 0;

            foreach (FileInfo fileInfo in di.GetFiles())
            {
                result = GetPrivateProfileString("InternetShortcut", "URL", "", sb, (uint)sb.Capacity, fileInfo.FullName);
                if (result > 0)
                {
                    FavouriteTreeNode myFav = new FavouriteTreeNode();
                    myFav.Text = Path.GetFileNameWithoutExtension(fileInfo.FullName);
                    myFav.Url = new Uri(sb.ToString());
                    myFav.DirectoryPath = fileInfo.FullName;
                    myFav.ImageIndex = 1;
                    myFav.SelectedImageIndex = 1;

                    // attempt to find an icon for the favourite
                    result = GetPrivateProfileString("InternetShortcut", "IconFile", "", sb1, (uint)sb.Capacity, fileInfo.FullName);
                    if (result > 0)
                    {
                        var image = this.LoadImage(sb1.ToString());
                        if (image != null)
                        {
                            this.iconImageList.Images.Add(string.Format("fav{0}", imageKeyIndex), image);
                            myFav.ImageKey = string.Format("fav{0}", imageKeyIndex);
                            myFav.SelectedImageKey = string.Format("fav{0}", imageKeyIndex);
                        }

                        imageKeyIndex++;
                    }

                    if (dirNode == null)
                    {
                        this.favouritesTreeView.Nodes.Add(myFav);
                    }
                    else
                    {
                        dirNode.Nodes.Add(myFav);
                    }
                }
            }
        }

        /// <summary>
        /// Initial call used to populate FavouritesTreeView with top level Favourites and Directories
        /// </summary>
        private void GetFavourites()
        {
            this.favouritesTreeView.Nodes.Clear();

            GetFavouritesForDirectory(new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.Favorites)), null);
        }

        private Image LoadImage(string url)
        {
            try
            {
                // Create a new WebClient instance.
                WebClient myWebClient = new WebClient();
                using (var myStream = myWebClient.OpenRead(url))
                {
                    var bmp = new Bitmap(myStream);

                    return bmp;
                }
            }
            catch
            {
                return null;
            }
        }

        #endregion
    }
}
