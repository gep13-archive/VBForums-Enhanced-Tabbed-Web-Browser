<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateFolderDialogue
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateFolderDialogue))
        Me.cancelOperationButton = New System.Windows.Forms.Button
        Me.CreateButton = New System.Windows.Forms.Button
        Me.FolderNameTextBox = New System.Windows.Forms.TextBox
        Me.FavouritesComboBox = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'cancelOperationButton
        '
        Me.cancelOperationButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cancelOperationButton.Location = New System.Drawing.Point(186, 67)
        Me.cancelOperationButton.Name = "cancelOperationButton"
        Me.cancelOperationButton.Size = New System.Drawing.Size(75, 23)
        Me.cancelOperationButton.TabIndex = 11
        Me.cancelOperationButton.Text = "Cancel"
        Me.cancelOperationButton.UseVisualStyleBackColor = True
        '
        'CreateButton
        '
        Me.CreateButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.CreateButton.Location = New System.Drawing.Point(105, 67)
        Me.CreateButton.Name = "CreateButton"
        Me.CreateButton.Size = New System.Drawing.Size(75, 23)
        Me.CreateButton.TabIndex = 10
        Me.CreateButton.Text = "Create"
        Me.CreateButton.UseVisualStyleBackColor = True
        '
        'FolderNameTextBox
        '
        Me.FolderNameTextBox.Location = New System.Drawing.Point(88, 14)
        Me.FolderNameTextBox.Name = "FolderNameTextBox"
        Me.FolderNameTextBox.Size = New System.Drawing.Size(173, 20)
        Me.FolderNameTextBox.TabIndex = 9
        '
        'FavouritesComboBox
        '
        Me.FavouritesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FavouritesComboBox.FormattingEnabled = True
        Me.FavouritesComboBox.Items.AddRange(New Object() {"Favourites"})
        Me.FavouritesComboBox.Location = New System.Drawing.Point(88, 40)
        Me.FavouritesComboBox.Name = "FavouritesComboBox"
        Me.FavouritesComboBox.Size = New System.Drawing.Size(173, 21)
        Me.FavouritesComboBox.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Create in:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Folder Name:"
        '
        'CreateFolderDialogue
        '
        Me.AcceptButton = Me.CreateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cancelOperationButton
        Me.ClientSize = New System.Drawing.Size(273, 105)
        Me.Controls.Add(Me.cancelOperationButton)
        Me.Controls.Add(Me.CreateButton)
        Me.Controls.Add(Me.FolderNameTextBox)
        Me.Controls.Add(Me.FavouritesComboBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CreateFolderDialogue"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Create Folder"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cancelOperationButton As System.Windows.Forms.Button
    Friend WithEvents CreateButton As System.Windows.Forms.Button
    Friend WithEvents FolderNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FavouritesComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
