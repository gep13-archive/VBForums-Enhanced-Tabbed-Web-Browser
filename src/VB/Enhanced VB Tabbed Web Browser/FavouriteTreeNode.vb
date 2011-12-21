Public Class FavouriteTreeNode
    Inherits TreeNode
    Private _url As Uri
    Public Property Url() As Uri
        Get
            Return _url
        End Get
        Set(ByVal value As Uri)
            _url = value
        End Set
    End Property

    Private _directoryPath As String
    Public Property DirectoryPath() As String
        Get
            Return _directoryPath
        End Get
        Set(ByVal value As String)
            _directoryPath = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal displayText As String, ByVal url As Uri)
        Me.Text = displayText
        Me.Url = url
    End Sub
End Class
