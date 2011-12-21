''' <summary>
''' A <b>TabControl</b> designed to display <see cref="WebBrowserTabPage" /> objects.
''' </summary>
''' <remarks></remarks>
Friend Class WebBrowserTabControl
    Inherits System.Windows.Forms.TabControl

#Region " Properties "

    ''' <summary>
    ''' Gets the currently selected tab page.
    ''' </summary>
    ''' <value>
    ''' The <see cref="WebBrowserTabPage" /> that is currently selected.
    ''' </value>
    Public ReadOnly Property SelectedWebBrowserTabPage() As WebBrowserTabPage
        Get
            Return DirectCast(Me.SelectedTab, WebBrowserTabPage)
        End Get
    End Property

    ''' <summary>
    ''' Gets the currently selected web browser.
    ''' </summary>
    ''' <value>
    ''' The <b>WebBrowser</b> control on the currently selected tab page.
    ''' </value>
    Public ReadOnly Property SelectedWebBrowser() As WebBrowser
        Get
            Return Me.SelectedWebBrowserTabPage.Browser
        End Get
    End Property

#End Region 'Properties

#Region " Methods "

    ''' <summary>
    ''' Adds a new, empty page to the tab control.
    ''' </summary>
    ''' <returns> 
    ''' The <see cref="WebBrowserTabPage" /> that was added.
    ''' </returns>
    Public Overloads Function AddTab() As WebBrowserTabPage
        Dim tab As New WebBrowserTabPage

        Me.TabPages.Add(tab)
        Me.SelectedTab = tab

        Return tab
    End Function

    ''' <summary>
    ''' Adds a new page to the tab control and navigates to the specified address.
    ''' </summary>
    ''' <param name="address">
    ''' The address of the page to display in the new tab.
    ''' </param>
    ''' <returns> 
    ''' The <see cref="WebBrowserTabPage" /> that was added.
    ''' </returns>
    Public Overloads Function AddTab(ByVal address As String) As WebBrowserTabPage
        Dim tab As WebBrowserTabPage = Me.AddTab()

        tab.Browser.Navigate(address)

        Return tab
    End Function

    ''' <summary>
    ''' Removes the currently selected tab from the tab control.
    ''' </summary>
    ''' <returns>
    ''' <b>True</b> if the current tab was removed; otherwise, <b>False</b>.
    ''' </returns>
    ''' <remarks>
    ''' There must always be at least one tab so the last tab cannot be removed.
    ''' </remarks>
    Public Function RemoveCurrentTab() As Boolean
        Dim canRemove As Boolean = (Me.TabCount > 1)

        If canRemove Then
            Dim tab As WebBrowserTabPage = Me.SelectedWebBrowserTabPage

            Me.TabPages.Remove(tab)
            tab.Dispose()
        End If

        Return canRemove
    End Function

#End Region 'Methods

End Class
