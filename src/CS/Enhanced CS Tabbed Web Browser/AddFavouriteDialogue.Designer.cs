namespace Enhanced_CS_Tabbed_Web_Browser
{
    partial class AddFavouriteDialogue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFavouriteDialogue));
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.FavouritesComboBox = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.cancelOperationButton = new System.Windows.Forms.Button();
            this.NewFolderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(78, 36);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(261, 32);
            this.Label4.TabIndex = 26;
            this.Label4.Text = "Add this webpage as a favourite.  To access your favourites, visit the Favourites" +
                " Center";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(78, 12);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(97, 13);
            this.Label3.TabIndex = 25;
            this.Label3.Text = "Add a Favourite";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(81, 71);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(258, 20);
            this.NameTextBox.TabIndex = 24;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(11, 74);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(38, 13);
            this.Label2.TabIndex = 23;
            this.Label2.Text = "Name:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(11, 102);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(52, 13);
            this.Label1.TabIndex = 22;
            this.Label1.Text = "Create in:";
            // 
            // FavouritesComboBox
            // 
            this.FavouritesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FavouritesComboBox.FormattingEnabled = true;
            this.FavouritesComboBox.Items.AddRange(new object[] {
            "Favourites"});
            this.FavouritesComboBox.Location = new System.Drawing.Point(81, 97);
            this.FavouritesComboBox.Name = "FavouritesComboBox";
            this.FavouritesComboBox.Size = new System.Drawing.Size(177, 21);
            this.FavouritesComboBox.TabIndex = 21;
            // 
            // AddButton
            // 
            this.AddButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddButton.Location = new System.Drawing.Point(183, 126);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 20;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // cancelOperationButton
            // 
            this.cancelOperationButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelOperationButton.Location = new System.Drawing.Point(264, 127);
            this.cancelOperationButton.Name = "cancelOperationButton";
            this.cancelOperationButton.Size = new System.Drawing.Size(75, 23);
            this.cancelOperationButton.TabIndex = 19;
            this.cancelOperationButton.Text = "Cancel";
            this.cancelOperationButton.UseVisualStyleBackColor = true;
            // 
            // NewFolderButton
            // 
            this.NewFolderButton.Location = new System.Drawing.Point(264, 97);
            this.NewFolderButton.Name = "NewFolderButton";
            this.NewFolderButton.Size = new System.Drawing.Size(75, 23);
            this.NewFolderButton.TabIndex = 18;
            this.NewFolderButton.Text = "New Folder";
            this.NewFolderButton.UseVisualStyleBackColor = true;
            this.NewFolderButton.Click += new System.EventHandler(this.NewFolderButton_Click);
            // 
            // AddFavouriteDialogue
            // 
            this.AcceptButton = this.AddButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelOperationButton;
            this.ClientSize = new System.Drawing.Size(351, 162);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.FavouritesComboBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.cancelOperationButton);
            this.Controls.Add(this.NewFolderButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddFavouriteDialogue";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add A Favourite";
            this.Load += new System.EventHandler(this.AddFavouriteDialogue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox NameTextBox;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox FavouritesComboBox;
        internal System.Windows.Forms.Button AddButton;
        internal System.Windows.Forms.Button cancelOperationButton;
        internal System.Windows.Forms.Button NewFolderButton;
    }
}