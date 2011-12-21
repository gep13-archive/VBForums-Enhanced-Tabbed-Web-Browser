using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Enhanced_CS_Tabbed_Web_Browser
{
    public partial class CreateFolderDialogue : Form
    {
        #region Variables

        public FavouriteDirectoryInfo newFavouriteDirectoryInfo;

        #endregion

        #region Constructors

        public CreateFolderDialogue()
        {
            InitializeComponent();
        }

        #endregion

        private void CreateFolderDialogue_Load(object sender, EventArgs e)
        {
            foreach (string dirName in Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.Favorites)))
            {
                DirectoryInfo dirInfo = new DirectoryInfo(dirName);
                FavouriteDirectoryInfo favouriteDirectoryInfo = new FavouriteDirectoryInfo();
                favouriteDirectoryInfo.DirectoryName = dirInfo.Name;
                favouriteDirectoryInfo.FullPath = dirName;
                this.FavouritesComboBox.Items.Add(favouriteDirectoryInfo);
            }

            this.FavouritesComboBox.SelectedIndex = 0;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (this.FolderNameTextBox.Text == string.Empty)
            {
                MessageBox.Show("You must provide a Name for the new folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }

            this.newFavouriteDirectoryInfo = new FavouriteDirectoryInfo();
            this.newFavouriteDirectoryInfo.DirectoryName = this.FolderNameTextBox.Text;

            if (this.FavouritesComboBox.Text == "Favourites")
            {
                newFavouriteDirectoryInfo.FullPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Favorites), this.FolderNameTextBox.Text);
            }
            else
            {
                FavouriteDirectoryInfo parentDirectoryInfo = (FavouriteDirectoryInfo)this.FavouritesComboBox.SelectedItem;
                newFavouriteDirectoryInfo.FullPath = Path.Combine(newFavouriteDirectoryInfo.FullPath, this.FolderNameTextBox.Text);
            }

            Directory.CreateDirectory(newFavouriteDirectoryInfo.FullPath);
        }

        #region Event Handlers

        #endregion
    }
}
