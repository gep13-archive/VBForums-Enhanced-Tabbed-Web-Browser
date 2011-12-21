using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace Enhanced_CS_Tabbed_Web_Browser
{
    public partial class AddFavouriteDialogue : Form
    {
        #region Variables

        /// <summary>
        /// The address currently displayed in the browser
        /// </summary>
        private string currentAddress;

        /// <summary>
        /// The name of the address currently displayed in the browser
        /// </summary>
        private string currentName;

        #endregion

        #region Constructors

        /// <summary>
        /// Creates a new instance of the <see cref="AddFavouriteDialogue" /> class.
        /// </summary>
        /// <param name="currentAddress">
        /// A <b>String</b> containing the address of the page currently displayed in the browser.
        /// </param>
        /// <param name="currentName">
        /// A <b>String</b> containing the name of the page currently displayed in the browser.
        /// </param>
        public AddFavouriteDialogue(string currentAddress, string currentName)
        {
            InitializeComponent();

            this.currentAddress = currentAddress;
            this.currentName = currentName;
        }

        #endregion

        #region PInvokes

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool WritePrivateProfileString(
            string lpAppName,
            string lpKeyName,
            string lpString,
            string lpFileName);

        #endregion

        #region Event Handlers

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (this.NameTextBox.Text == string.Empty)
            {
                MessageBox.Show("You must provide a Display Name for the Favourite", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }

            if (this.currentAddress == string.Empty)
            {
                MessageBox.Show("You must provide a Url for the Favourite", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }

            Uri favouriteUri = null;

            if(!Uri.TryCreate(this.currentAddress, UriKind.RelativeOrAbsolute, out favouriteUri))
            {
                MessageBox.Show("Please provide a valid Url", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }

            string favouriteFileName;

            if (this.FavouritesComboBox.Text == "Favourites")
            {
                favouriteFileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Favorites), this.NameTextBox.Text + ".url");
            }
            else
            {
                FavouriteDirectoryInfo favouriteDirectoryInfo = (FavouriteDirectoryInfo)this.FavouritesComboBox.SelectedItem;
                favouriteFileName = Path.Combine(favouriteDirectoryInfo.FullPath, this.NameTextBox.Text + ".url");
            }

            WritePrivateProfileString("InternetShortcut", "URL", favouriteUri.ToString(), favouriteFileName);
        }

        private void NewFolderButton_Click(object sender, EventArgs e)
        {
            using (CreateFolderDialogue createFolderForm = new CreateFolderDialogue())
            {
                createFolderForm.ShowDialog();

                if (createFolderForm.DialogResult == DialogResult.OK)
                {
                    this.FavouritesComboBox.Items.Add(createFolderForm.newFavouriteDirectoryInfo);
                    this.FavouritesComboBox.SelectedIndex = this.FavouritesComboBox.Items.Count - 1;
                }
            }
        }

        private void AddFavouriteDialogue_Load(object sender, EventArgs e)
        {
            foreach(string dirName in Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.Favorites)))
            {
                DirectoryInfo dirInfo = new DirectoryInfo(dirName);
                FavouriteDirectoryInfo favouriteDirectoryInfo = new FavouriteDirectoryInfo();
                favouriteDirectoryInfo.DirectoryName = dirInfo.Name;
                favouriteDirectoryInfo.FullPath = dirName;
                this.FavouritesComboBox.Items.Add(favouriteDirectoryInfo);
            }

            this.NameTextBox.Text = this.currentName;
            this.FavouritesComboBox.SelectedIndex = 0;
        }

        #endregion
    }
}
