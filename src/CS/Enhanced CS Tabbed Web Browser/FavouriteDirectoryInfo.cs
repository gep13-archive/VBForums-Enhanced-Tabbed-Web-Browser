using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enhanced_CS_Tabbed_Web_Browser
{
    public class FavouriteDirectoryInfo
    {
        public string DirectoryName { get; set; }

        public string FullPath { get; set; }

        public override string ToString()
        {
            return this.DirectoryName;
        }
    }
}