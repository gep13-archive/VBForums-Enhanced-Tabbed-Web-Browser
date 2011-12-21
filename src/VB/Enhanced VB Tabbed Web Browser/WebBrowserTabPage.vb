''' <summary>
''' A <b>TabPage</b> that displays a <b>WebBrowser</b> control.
''' </summary>
Friend Class WebBrowserTabPage
    Inherits System.Windows.Forms.TabPage

#Region " Constants "

    ''' <summary>
    ''' The title to display on the tab when no page is loaded.
    ''' </summary>
    Private Const BLANK_PAGE_TITLE As String = "(Blank)"

#End Region 'Constants

#Region " Variables "

    ''' <summary>
    ''' The <b>WebBrowser</b> control displayed on the page.
    ''' </summary>
    Private WithEvents _browser As WebBrowser
    ''' <summary>
    ''' The current progress at the last <b>ProgressChanged</b> event.
    ''' </summary>
    Private _lastCurrentProgress As Long
    ''' <summary>
    ''' The maximum progress at the last <b>ProgressChanged</b> event.
    ''' </summary>
    Private _lastMaximumProgress As Long

#End Region 'Variables

#Region " Properties "

    ''' <summary>
    ''' Gets the <b>WebBrowser</b> control displayed on the page.
    ''' </summary>
    ''' <value>
    ''' A <b>WebBrowser</b> object.
    ''' </value>
    Public ReadOnly Property Browser() As WebBrowser
        Get
            Return Me._browser
        End Get
    End Property

    ''' <summary>
    ''' Gets the current progress at the last <b>ProgressChanged</b> event.
    ''' </summary>
    ''' <value>
    ''' A <b>Long</b> containing the last current load progress.
    ''' </value>
    Public ReadOnly Property LastCurrentProgress() As Long
        Get
            Return Me._lastCurrentProgress
        End Get
    End Property

    ''' <summary>
    ''' Gets the maximum progress at the last <b>ProgressChanged</b> event.
    ''' </summary>
    ''' <value>
    ''' A <b>Long</b> containing the last maximum load progress.
    ''' </value>
    Public ReadOnly Property LastMaximumProgress() As Long
        Get
            Return Me._lastMaximumProgress
        End Get
    End Property

#End Region 'Properties

#Region " Constructors "

    ''' <summary>
    ''' Creates a new instance of the <see cref="WebBrowserTabPage" /> class.
    ''' </summary>
    ''' <remarks>
    ''' This constructor creates and displays a new <b>WebBrowser</b> control.
    ''' </remarks>
    Public Sub New()
        Me.New(New WebBrowser)

        Me.Browser.Navigate(String.Empty)
    End Sub

    ''' <summary>
    ''' Creates a new instance of the <see cref="WebBrowserTabPage" /> class and displays the specified <b>WebBrowser</b> control.
    ''' </summary>
    ''' <param name="browser">
    ''' The <b>WebBrowser</b> control to display on the page.
    ''' </param>
    Public Sub New(ByVal browser As WebBrowser)
        browser.Dock = DockStyle.Fill
        Me.Controls.Add(browser)
        Me._browser = browser
        Me.DisplayPageTitle()
    End Sub

#End Region 'Constructors

#Region " Event Handlers "

    Private Sub _browser_DocumentTitleChanged(ByVal sender As Object, _
                                              ByVal e As EventArgs) Handles _browser.DocumentTitleChanged
        Me.DisplayPageTitle()
    End Sub

    Private Sub _browser_ProgressChanged(ByVal sender As Object, _
                                         ByVal e As WebBrowserProgressChangedEventArgs) Handles _browser.ProgressChanged
        'Remember the last progress values for the page.
        Me._lastCurrentProgress = e.CurrentProgress
        Me._lastMaximumProgress = e.MaximumProgress
    End Sub

#End Region 'Event Handlers

#Region " Methods "

    ''' <summary>
    ''' Displays the current page title on the tab.
    ''' </summary>
    ''' <remarks>
    ''' Place-holder text is used if no document is loaded.
    ''' </remarks>
    Private Sub DisplayPageTitle()
        Dim documentTitle As String = Me.Browser.DocumentTitle

        If documentTitle = String.Empty Then
            Me.Text = BLANK_PAGE_TITLE
        Else
            Me.Text = documentTitle
        End If
    End Sub

#End Region 'Methods

End Class
