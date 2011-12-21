Imports System.Runtime.InteropServices
Imports System.IO

Public Class AddFavouriteDialogue

#Region " Variables "

    ''' <summary>
    ''' The address currently displayed in the browser.
    ''' </summary>
    Private currentAddress As String

    ''' <summary>
    ''' The name of the address currently displayed in the browser.
    ''' </summary>
    Private currentName As String

#End Region 'Variables

#Region " Constructors "

    ''' <summary>
    ''' Creates a new instance of the <see cref="AddFavouriteDialogue" /> class.
    ''' </summary>
    ''' <param name="currentAddress">
    ''' A <b>String</b> containing the address of the page currently displayed in the browser.
    ''' </param>
    ''' <param name="currentName">
    ''' A <b>String</b> containing the name of the page currently displayed in the browser.
    ''' </param>
    Public Sub New(ByVal currentAddress As String, ByVal currentName As String)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.currentAddress = currentAddress
        Me.currentName = currentName
    End Sub

#End Region

#Region " PInvokes "

    <DllImport("kernel32.dll", SetLastError:=True)> _
    Private Shared Function WritePrivateProfileString(ByVal lpAppName As String, _
                                          ByVal lpKeyName As String, _
                                          ByVal lpString As String, _
                                          ByVal lpFileName As String) As Integer

    End Function

#End Region 'PInvokes

#Region " Event Handlers "

    Private Sub AddFavouriteDialogue_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For Each dirName As String In Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.Favorites))
            Dim dirInfo As New DirectoryInfo(dirName)
            Dim favouriteDirInfo As New FavouriteDirectoryInfo
            favouriteDirInfo.DirectoryName = dirInfo.Name
            favouriteDirInfo.FullPath = dirName
            Me.FavouritesComboBox.Items.Add(favouriteDirInfo)
        Next

        Me.NameTextBox.Text = Me.currentName
        Me.FavouritesComboBox.SelectedIndex = 0
    End Sub

    Private Sub AddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButton.Click
        If Me.NameTextBox.Text = String.Empty Then
            MessageBox.Show("You must provide a Display Name for the Favourite", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return
        End If

        If Me.currentAddress = String.Empty Then
            MessageBox.Show("You must provide a Url for the Favourite", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return
        End If

        Dim favouriteUri As Uri = Nothing

        If Not Uri.TryCreate(Me.currentAddress, UriKind.RelativeOrAbsolute, favouriteUri) Then
            MessageBox.Show("Please provide a valid Url", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return
        End If

        Dim favouriteFileName As String

        If Me.FavouritesComboBox.Text = "Favourites" Then
            favouriteFileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Favorites), Me.NameTextBox.Text + ".url")
        Else
            Dim favouriteDirectoryInfo As FavouriteDirectoryInfo
            favouriteDirectoryInfo = DirectCast(Me.FavouritesComboBox.SelectedItem, FavouriteDirectoryInfo)

            favouriteFileName = Path.Combine(favouriteDirectoryInfo.FullPath, Me.NameTextBox.Text + ".url")
        End If


        WritePrivateProfileString("InternetShortcut", "URL", favouriteUri.ToString(), favouriteFileName)
    End Sub

    Private Sub NewFolderButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewFolderButton.Click
        Using createFolderForm As New CreateFolderDialogue()
            createFolderForm.ShowDialog()

            If createFolderForm.DialogResult = Windows.Forms.DialogResult.OK Then
                Me.FavouritesComboBox.Items.Add(createFolderForm.newFavouriteDirectoryInfo)
                Me.FavouritesComboBox.SelectedIndex = Me.FavouritesComboBox.Items.Count - 1
            End If
        End Using
    End Sub

#End Region 'Event Handlers

    Private Sub FavouritesComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FavouritesComboBox.SelectedIndexChanged

    End Sub
End Class