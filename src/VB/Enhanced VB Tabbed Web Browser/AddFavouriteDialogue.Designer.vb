<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddFavouriteDialogue
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddFavouriteDialogue))
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.NameTextBox = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.FavouritesComboBox = New System.Windows.Forms.ComboBox
        Me.AddButton = New System.Windows.Forms.Button
        Me.cancelOperationButton = New System.Windows.Forms.Button
        Me.NewFolderButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(83, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(261, 32)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Add this webpage as a favourite.  To access your favourites, visit the Favourites" & _
            " Center"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(83, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Add a Favourite"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(86, 76)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(258, 20)
        Me.NameTextBox.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Create in:"
        '
        'FavouritesComboBox
        '
        Me.FavouritesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FavouritesComboBox.FormattingEnabled = True
        Me.FavouritesComboBox.Items.AddRange(New Object() {"Favourites"})
        Me.FavouritesComboBox.Location = New System.Drawing.Point(86, 102)
        Me.FavouritesComboBox.Name = "FavouritesComboBox"
        Me.FavouritesComboBox.Size = New System.Drawing.Size(177, 21)
        Me.FavouritesComboBox.TabIndex = 12
        '
        'AddButton
        '
        Me.AddButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.AddButton.Location = New System.Drawing.Point(188, 131)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(75, 23)
        Me.AddButton.TabIndex = 11
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'cancelOperationButton
        '
        Me.cancelOperationButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cancelOperationButton.Location = New System.Drawing.Point(269, 132)
        Me.cancelOperationButton.Name = "cancelOperationButton"
        Me.cancelOperationButton.Size = New System.Drawing.Size(75, 23)
        Me.cancelOperationButton.TabIndex = 10
        Me.cancelOperationButton.Text = "Cancel"
        Me.cancelOperationButton.UseVisualStyleBackColor = True
        '
        'NewFolderButton
        '
        Me.NewFolderButton.Location = New System.Drawing.Point(269, 102)
        Me.NewFolderButton.Name = "NewFolderButton"
        Me.NewFolderButton.Size = New System.Drawing.Size(75, 23)
        Me.NewFolderButton.TabIndex = 9
        Me.NewFolderButton.Text = "New Folder"
        Me.NewFolderButton.UseVisualStyleBackColor = True
        '
        'AddFavouriteDialogue
        '
        Me.AcceptButton = Me.AddButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cancelOperationButton
        Me.ClientSize = New System.Drawing.Size(361, 172)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FavouritesComboBox)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.cancelOperationButton)
        Me.Controls.Add(Me.NewFolderButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddFavouriteDialogue"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add A Favourite"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FavouritesComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents cancelOperationButton As System.Windows.Forms.Button
    Friend WithEvents NewFolderButton As System.Windows.Forms.Button
End Class
