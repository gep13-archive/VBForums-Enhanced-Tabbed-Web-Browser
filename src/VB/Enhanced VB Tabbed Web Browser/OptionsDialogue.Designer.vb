<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OptionsDialogue
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
        Dim homePageLabel As System.Windows.Forms.Label
        Dim useCurrentAsHomePageButton As System.Windows.Forms.Button
        Dim useBlankAsHomePageButton As System.Windows.Forms.Button
        Dim okButton As System.Windows.Forms.Button
        Dim cancelOperationButton As System.Windows.Forms.Button
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OptionsDialogue))
        Me.homePageText = New System.Windows.Forms.TextBox
        Me.startupWithHomePageToggle = New System.Windows.Forms.CheckBox
        homePageLabel = New System.Windows.Forms.Label
        useCurrentAsHomePageButton = New System.Windows.Forms.Button
        useBlankAsHomePageButton = New System.Windows.Forms.Button
        okButton = New System.Windows.Forms.Button
        cancelOperationButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'homePageLabel
        '
        homePageLabel.AutoSize = True
        homePageLabel.Location = New System.Drawing.Point(12, 15)
        homePageLabel.Name = "homePageLabel"
        homePageLabel.Size = New System.Drawing.Size(66, 13)
        homePageLabel.TabIndex = 0
        homePageLabel.Text = "&Home Page:"
        '
        'homePageText
        '
        Me.homePageText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.homePageText.Location = New System.Drawing.Point(84, 12)
        Me.homePageText.Name = "homePageText"
        Me.homePageText.Size = New System.Drawing.Size(250, 20)
        Me.homePageText.TabIndex = 1
        '
        'useCurrentAsHomePageButton
        '
        useCurrentAsHomePageButton.Location = New System.Drawing.Point(84, 38)
        useCurrentAsHomePageButton.Name = "useCurrentAsHomePageButton"
        useCurrentAsHomePageButton.Size = New System.Drawing.Size(75, 23)
        useCurrentAsHomePageButton.TabIndex = 2
        useCurrentAsHomePageButton.Text = "Use &Current"
        useCurrentAsHomePageButton.UseVisualStyleBackColor = True
        AddHandler useCurrentAsHomePageButton.Click, AddressOf Me.useCurrentAsHomePageButton_Click
        '
        'useBlankAsHomePageButton
        '
        useBlankAsHomePageButton.Location = New System.Drawing.Point(168, 38)
        useBlankAsHomePageButton.Name = "useBlankAsHomePageButton"
        useBlankAsHomePageButton.Size = New System.Drawing.Size(75, 23)
        useBlankAsHomePageButton.TabIndex = 3
        useBlankAsHomePageButton.Text = "Use &Blank"
        useBlankAsHomePageButton.UseVisualStyleBackColor = True
        AddHandler useBlankAsHomePageButton.Click, AddressOf Me.useBlankAsHomePageButton_Click
        '
        'startupWithHomePageToggle
        '
        Me.startupWithHomePageToggle.AutoSize = True
        Me.startupWithHomePageToggle.Location = New System.Drawing.Point(84, 67)
        Me.startupWithHomePageToggle.Name = "startupWithHomePageToggle"
        Me.startupWithHomePageToggle.Size = New System.Drawing.Size(153, 17)
        Me.startupWithHomePageToggle.TabIndex = 5
        Me.startupWithHomePageToggle.Text = "&Load home page at startup"
        Me.startupWithHomePageToggle.UseVisualStyleBackColor = True
        '
        'okButton
        '
        okButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        okButton.DialogResult = System.Windows.Forms.DialogResult.OK
        okButton.Location = New System.Drawing.Point(178, 90)
        okButton.Name = "okButton"
        okButton.Size = New System.Drawing.Size(75, 23)
        okButton.TabIndex = 6
        okButton.Text = "OK"
        okButton.UseVisualStyleBackColor = True
        AddHandler okButton.Click, AddressOf Me.okButton_Click
        '
        'cancelOperationButton
        '
        cancelOperationButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        cancelOperationButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        cancelOperationButton.Location = New System.Drawing.Point(259, 90)
        cancelOperationButton.Name = "cancelOperationButton"
        cancelOperationButton.Size = New System.Drawing.Size(75, 23)
        cancelOperationButton.TabIndex = 7
        cancelOperationButton.Text = "Cancel"
        cancelOperationButton.UseVisualStyleBackColor = True
        '
        'OptionsDialogue
        '
        Me.AcceptButton = okButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = cancelOperationButton
        Me.ClientSize = New System.Drawing.Size(346, 125)
        Me.Controls.Add(cancelOperationButton)
        Me.Controls.Add(okButton)
        Me.Controls.Add(Me.startupWithHomePageToggle)
        Me.Controls.Add(useBlankAsHomePageButton)
        Me.Controls.Add(useCurrentAsHomePageButton)
        Me.Controls.Add(Me.homePageText)
        Me.Controls.Add(homePageLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "OptionsDialogue"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Options"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents homePageText As System.Windows.Forms.TextBox
    Private WithEvents startupWithHomePageToggle As System.Windows.Forms.CheckBox
End Class
