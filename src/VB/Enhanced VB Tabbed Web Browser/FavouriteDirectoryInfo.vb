Public Class FavouriteDirectoryInfo
    Private _directoryName As String
    Public Property DirectoryName() As String
        Get
            Return _directoryName
        End Get
        Set(ByVal value As String)
            _directoryName = value
        End Set
    End Property


    Private _fullPath As String
    Public Property FullPath() As String
        Get
            Return _fullPath
        End Get
        Set(ByVal value As String)
            _fullPath = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Me.DirectoryName
    End Function
End Class
