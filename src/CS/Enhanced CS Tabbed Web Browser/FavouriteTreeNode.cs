using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Enhanced_CS_Tabbed_Web_Browser
{
    public class FavouriteTreeNode : TreeNode
    {
        public Uri Url { get; set; }

        public string DirectoryPath { get; set; }

        public FavouriteTreeNode()
        {
        }

        public FavouriteTreeNode(string displayText, Uri url)
        {
            this.Text = displayText;
            this.Url = url;
        }
    }
}