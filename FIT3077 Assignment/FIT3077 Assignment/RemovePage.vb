Imports System.Windows.Forms.DataVisualization.Charting

'''
''' Project     : FIT3077 Assignment
''' Class       : LoadingPage
''' Author      : Arvin Wiyono (awiy1) and Darren Wong (dwwon6)
''' Modified    : 18 May 2015
''' Description : The remove page of the weather monitor application
''' Precondition: MainPage and WeatherController classes exists
''' 

Public Class RemovePage

    'Declare two required controllers to send requests
    Dim LController, TLController As WeatherController

    ''' 
    ''' Description : Procedure which is executed when RemovePage is loaded
    ''' Return      : None
    ''' Post        : Active WeatherLocations' location names are listed in the RemoveLocationList
    '''
    Private Sub RemovePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Refresh List
        RemoveLocationList.Items.Clear()
        'Assign the two controllers from the main page
        LController = MainPage.liveController
        TLController = MainPage.timeLapseController

        'Get selected locations' names from both controllers
        Dim liveLocations As String() = LController.GetAllSelectedLocations
        Dim timeLapseLocations As String() = TLController.GetAllSelectedLocations
        Dim combineLocations As List(Of String) = New List(Of String)

        'Get the combine locations while not doubling same location names
        For Each l As String In liveLocations
            combineLocations.Add(l)
        Next
        For Each l As String In timeLapseLocations
            'If the locations has not been included in the list
            If (combineLocations.IndexOf(l) = -1) Then
                combineLocations.Add(l)
            End If
        Next

        For Each l As String In combineLocations
            RemoveLocationList.Items.Add(l)
        Next
        RemoveLocationList.Sorted = True
    End Sub

    ''' 
    ''' Description : Procedure which is executed when RemoveLbl is clicked. This sends request to both controllers to remove WeatherLocations with the specified location from the selectedLocations list
    ''' Return      : None
    ''' Post        : All controls which display the removed locations are removed from the main page flow layout panel
    '''
    Private Sub RemoveLbl_Click(sender As Object, e As EventArgs) Handles RemoveLbl.Click
        RemoveLbl.BackColor = SystemColors.ControlLight
        RemoveLbl.ForeColor = Color.Black

        'If at least one location is selected to be removed
        If RemoveLocationList.SelectedItems.Count > 0 Then
            MainPage.Hide()
            'Remove each selected location in the listbox
            Dim index As Integer
            For index = 0 To RemoveLocationList.SelectedItems.Count - 1

                'Remove text monitors which display the location from the main page
                For Each lbl As Label In MainPage.labelList
                    Dim monitor As Monitor = CType(lbl.Tag, Monitor)
                    If monitor.GetLocation = RemoveLocationList.SelectedItems(index) Then
                        MainPage.FlowPanel.Controls.Remove(lbl)
                    End If
                Next

                'Remove charts which display the location from the main page
                For Each c As Chart In MainPage.chartList
                    Dim monitor As Monitor = CType(c.Tag, Monitor)
                    If monitor.GetLocation = RemoveLocationList.SelectedItems(index) Then
                        MainPage.FlowPanel.Controls.Remove(c)
                    End If
                Next

                Dim loopRemove As Integer = MainPage.labelList.Count - 1
                Dim labelIndex As Integer = 0
                'Remove labels from the LabelList of MainPage
                For j As Integer = 0 To loopRemove
                    Dim monitor As Monitor = CType(MainPage.labelList.Item(labelIndex).Tag, Monitor)
                    If monitor.GetLocation = RemoveLocationList.SelectedItems(index) Then
                        MainPage.labelList.RemoveAt(labelIndex)
                    Else
                        labelIndex += 1
                    End If
                Next

                loopRemove = MainPage.chartList.Count - 1
                Dim chartIndex As Integer = 0
                'Remove charts from the ChartList of MainPage
                For j As Integer = 0 To loopRemove
                    Dim monitor As Monitor = CType(MainPage.chartList.Item(chartIndex).Tag, Monitor)
                    If monitor.GetLocation = RemoveLocationList.SelectedItems(index) Then
                        MainPage.chartList.RemoveAt(chartIndex)
                    Else
                        chartIndex += 1
                    End If
                Next
                'Sends requests to the controllers to remove the WeatherLocation with the specified location
                LController.RemoveLocation(RemoveLocationList.SelectedItems(index))
                TLController.RemoveLocation(RemoveLocationList.SelectedItems(index))
            Next

            'If there is no control in the flow panel, display the intro picture
            If MainPage.FlowPanel.Controls.Count = 0 Then
                MainPage.IntroPict.Visible = True
                MainPage.FlowPanel.Visible = False
            End If

            'Close this page and re-display main page
            Me.Hide()
            MainPage.Show()
        Else
            MsgBox("Please, select at least one location from the listbox to be removed !")
        End If

    End Sub

    'Interface related procedures
    Private Sub RemoveLbl_MouseHover(sender As Object, e As EventArgs) Handles RemoveLbl.MouseHover
        RemoveLbl.BackColor = Color.Gray
    End Sub

    Private Sub RemoveLbl_MouseLeave(sender As Object, e As EventArgs) Handles RemoveLbl.MouseLeave
        RemoveLbl.BackColor = SystemColors.ControlDarkDark
        RemoveLbl.ForeColor = Color.White
    End Sub

    Private Sub BackLbl_Click(sender As Object, e As EventArgs) Handles BackLbl.Click
        BackLbl.BackColor = SystemColors.ControlLight
        BackLbl.ForeColor = Color.Black
        Me.Hide()
    End Sub

    Private Sub BackLbl_MouseHover(sender As Object, e As EventArgs) Handles BackLbl.MouseHover
        BackLbl.BackColor = Color.Gray
    End Sub

    Private Sub BackLbl_MouseLeave(sender As Object, e As EventArgs) Handles BackLbl.MouseLeave
        BackLbl.BackColor = SystemColors.ControlDarkDark
        BackLbl.ForeColor = Color.White
    End Sub
End Class