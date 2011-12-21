''' <summary>
''' Displays configuration options for the application.
''' </summary>
Friend Class OptionsDialogue

#Region " Variables "

    ''' <summary>
    ''' The addressed currently displayed in the browser.
    ''' </summary>
    Private currentAddress As String

#End Region 'Variables

#Region " Constructors "

    ''' <summary>
    ''' Creates a new instance of the <see cref="OptionsDialogue" /> class.
    ''' </summary>
    ''' <param name="currentAddress">
    ''' A <b>String</b> containing the address of the page currently displayed in the browser.
    ''' </param>
    Public Sub New(ByVal currentAddress As String)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Me.currentAddress = currentAddress
    End Sub

#End Region 'Constructors

#Region " Event Handlers "

    Private Sub OptionsDialogue_Load(ByVal sender As Object, _
                                     ByVal e As EventArgs) Handles MyBase.Load
        'Load the current options.
        Me.homePageText.Text = My.Settings.HomePage
        Me.startupWithHomePageToggle.Checked = My.Settings.StartWithHomePage
    End Sub

    Private Sub useCurrentAsHomePageButton_Click(ByVal sender As Object, _
                                                 ByVal e As EventArgs)
        Me.homePageText.Text = Me.currentAddress
    End Sub

    Private Sub useBlankAsHomePageButton_Click(ByVal sender As Object, _
                                               ByVal e As EventArgs)
        Me.homePageText.Clear()
    End Sub

    Private Sub okButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Save the new settings.
        My.Settings.HomePage = Me.homePageText.Text
        My.Settings.StartWithHomePage = Me.startupWithHomePageToggle.Checked
    End Sub

#End Region 'Event Handlers

End Class