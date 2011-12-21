Imports System.IO

Public Class CreateFolderDialogue

#Region " Variables "

    Public newFavouriteDirectoryInfo As FavouriteDirectoryInfo

#End Region 'Variables

#Region " Event Handlers "

    Private Sub CreateFolderDialogue_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For Each dirName As String In Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.Favorites))
            Dim dirInfo As New DirectoryInfo(dirName)
            Dim favouriteDirInfo As New FavouriteDirectoryInfo
            favouriteDirInfo.DirectoryName = dirInfo.Name
            favouriteDirInfo.FullPath = dirName
            Me.FavouritesComboBox.Items.Add(favouriteDirInfo)
        Next

        Me.FavouritesComboBox.SelectedIndex = 0
    End Sub

#End Region 'Event Handlers

    Private Sub CreateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateButton.Click
        If Me.FolderNameTextBox.Text = String.Empty Then
            MessageBox.Show("You must provide a Name for the new folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return
        End If

        newFavouriteDirectoryInfo = New FavouriteDirectoryInfo()
        newFavouriteDirectoryInfo.DirectoryName = Me.FolderNameTextBox.Text

        If Me.FavouritesComboBox.Text = "Favourites" Then
            newFavouriteDirectoryInfo.FullPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Favorites), Me.FolderNameTextBox.Text)
        Else
            Dim parentDirectoryInfo = DirectCast(Me.FavouritesComboBox.SelectedItem, FavouriteDirectoryInfo)

            newFavouriteDirectoryInfo.FullPath = Path.Combine(newFavouriteDirectoryInfo.FullPath, Me.FolderNameTextBox.Text)
        End If

        Directory.CreateDirectory(newFavouriteDirectoryInfo.FullPath)
    End Sub
End Class