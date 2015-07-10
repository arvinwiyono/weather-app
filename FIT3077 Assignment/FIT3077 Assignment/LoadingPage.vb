'''
''' Project     : FIT3077 Assignment
''' Class       : LoadingPage
''' Author      : Arvin Wiyono (awiy1) and Darren Wong (dwwon6)
''' Modified    : 10 May 2015
''' Description : The loading page of the weather monitor application
''' Precondition: MainPage exists
''' 

Public Class LoadingPage

    Private Sub LoadingPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadingTimer.Start()
        'Do preparation
        MainPage.PrepareAvailableLocations()
    End Sub

    Private Sub LoadingTimer_Tick(sender As Object, e As EventArgs) Handles LoadingTimer.Tick
        If (LoadingBar.Value < LoadingBar.Maximum) Then
            LoadingBar.Value += 20
        Else
            'When the loading bar is full, close this page and display the main page
            LoadingTimer.Stop()
            MainPage.Show()
            Me.Close()
        End If
    End Sub
End Class