namespace Enhanced_CS_Tabbed_Web_Browser
{
    partial class CreateFolderDialogue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateFolderDialogue));
            this.cancelOperationButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.FolderNameTextBox = new System.Windows.Forms.TextBox();
            this.FavouritesComboBox = new System.Windows.Forms.ComboBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelOperationButton
            // 
            this.cancelOperationButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelOperationButton.Location = new System.Drawing.Point(181, 62);
            this.cancelOperationButton.Name = "cancelOperationButton";
            this.cancelOperationButton.Size = new System.Drawing.Size(75, 23);
            this.cancelOperationButton.TabIndex = 17;
            this.cancelOperationButton.Text = "Cancel";
            this.cancelOperationButton.UseVisualStyleBackColor = true;
            // 
            // CreateButton
            // 
            this.CreateButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CreateButton.Location = new System.Drawing.Point(100, 62);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 23);
            this.CreateButton.TabIndex = 16;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // FolderNameTextBox
            // 
            this.FolderNameTextBox.Location = new System.Drawing.Point(83, 9);
            this.FolderNameTextBox.Name = "FolderNameTextBox";
            this.FolderNameTextBox.Size = new System.Drawing.Size(173, 20);
            this.FolderNameTextBox.TabIndex = 15;
            // 
            // FavouritesComboBox
            // 
            this.FavouritesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FavouritesComboBox.FormattingEnabled = true;
            this.FavouritesComboBox.Items.AddRange(new object[] {
            "Favourites"});
            this.FavouritesComboBox.Location = new System.Drawing.Point(83, 35);
            this.FavouritesComboBox.Name = "FavouritesComboBox";
            this.FavouritesComboBox.Size = new System.Drawing.Size(173, 21);
            this.FavouritesComboBox.TabIndex = 14;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(7, 38);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(52, 13);
            this.Label2.TabIndex = 13;
            this.Label2.Text = "Create in:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(7, 12);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(70, 13);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "Folder Name:";
            // 
            // CreateFolderDialogue
            // 
            this.AcceptButton = this.CreateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelOperationButton;
            this.ClientSize = new System.Drawing.Size(263, 95);
            this.Controls.Add(this.cancelOperationButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.FolderNameTextBox);
            this.Controls.Add(this.FavouritesComboBox);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateFolderDialogue";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create Folder";
            this.Load += new System.EventHandler(this.CreateFolderDialogue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button cancelOperationButton;
        internal System.Windows.Forms.Button CreateButton;
        internal System.Windows.Forms.TextBox FolderNameTextBox;
        internal System.Windows.Forms.ComboBox FavouritesComboBox;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}