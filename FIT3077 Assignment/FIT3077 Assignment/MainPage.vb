Imports System.Windows.Forms.DataVisualization.Charting

'''
''' Project     : FIT3077 Assignment
''' Class       : MainPage
''' Author      : Arvin Wiyono (awiy1)
''' Modified    : 18 May 2015
''' Description : The main page of the weather monitor application
''' Precondition: LiveWeatherController, TimeLapseController and Monitor classes exist - InfoType enumeration is required
''' 

Public Class MainPage

    'Declare necessary attributes
    Public labelList As List(Of Label) = New List(Of Label)
    Public chartList As List(Of Chart) = New List(Of Chart)
    Public liveController As WeatherController = New LiveWeatherController()
    Public timeLapseController As WeatherController = New TimeLapseWeatherController()

    ''' 
    ''' Description : Procedure trigerred when MainPage is loaded
    '''
    Private Sub MainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.BackColor = Color.FromArgb(120, 186, 186, 186)
        'Give initial value to both combo box controls
        ServerComboBox.SelectedIndex = 0
        MonitorComboBox.SelectedIndex = 0

        'Setup update interval of both timers
        LiveTimer.Interval = liveController.GetUpdateInterval()
        TimeLapseTimer.Interval = timeLapseController.GetUpdateInterval()
    End Sub

    'Interface related procedures
    Private Sub AddLocationLbl_MouseHover(sender As Object, e As EventArgs) Handles AddLocationLbl.MouseHover
        AddLocationLbl.BackColor = Color.Gray
    End Sub
    Private Sub AddLocationLbl_MouseLeave(sender As Object, e As EventArgs) Handles AddLocationLbl.MouseLeave
        AddLocationLbl.BackColor = SystemColors.ControlDarkDark
        AddLocationLbl.ForeColor = Color.White
    End Sub

    ''' 
    ''' Description : Procedure executed when AddLocationLbl is clicked
    '''
    Private Sub AddLocationLbl_Click(sender As Object, e As EventArgs) Handles AddLocationLbl.Click
        AddLocationLbl.BackColor = SystemColors.ControlLight
        AddLocationLbl.ForeColor = Color.Black
        'If Live server is selected
        If ServerComboBox.SelectedIndex = 0 Then
            'Start the timer
            LiveTimer.Enabled = True
            AddLocation(liveController)
        Else    'If Time Laspe server is selected    
            'Start the timer
            TimeLapseTimer.Enabled = True
            AddLocation(timeLapseController)
        End If

    End Sub

    Private Sub RemoveLocationLbl_Click(sender As Object, e As EventArgs) Handles RemoveLocationLbl.Click
        RemoveLocationLbl.BackColor = SystemColors.ControlLight
        RemoveLocationLbl.ForeColor = Color.Black
        RemovePage.ShowDialog()
    End Sub

    Private Sub RemoveLocationLbl_MouseHover(sender As Object, e As EventArgs) Handles RemoveLocationLbl.MouseHover
        RemoveLocationLbl.BackColor = Color.Gray
    End Sub

    Private Sub RemoveLocationLbl_MouseLeave(sender As Object, e As EventArgs) Handles RemoveLocationLbl.MouseLeave
        RemoveLocationLbl.BackColor = SystemColors.ControlDarkDark
        RemoveLocationLbl.ForeColor = Color.White
    End Sub

    ''' 
    ''' Description : Function which displays the intersection of available locations in both servers
    ''' Post        : Available locations are displayed in the LocationListBox control 
    '''
    Public Sub PrepareAvailableLocations()
        'Get available locations from both Controllers
        Dim liveLocations As String() = liveController.GetAvailableLocations()
        Dim timeLapseLocations As String() = timeLapseController.GetAvailableLocations()

        'Get the intersection of locations which are available in both servers
        'If there are more live locations
        If liveLocations.Count > timeLapseLocations.Count() Then
            For Each ll As String In liveLocations
                For Each tll As String In timeLapseLocations
                    'If location is available in both servers
                    If (ll = tll) Then
                        'Add location to the list box
                        LocationsListBox.Items.Add(ll)
                        Exit For
                    End If
                Next
            Next
        Else    'If there are more time lapse locations
            For Each tll As String In timeLapseLocations
                For Each ll As String In liveLocations
                    'If location is available in both servers
                    If (tll = ll) Then
                        'Add location to the list box
                        LocationsListBox.Items.Add(tll)
                        Exit For
                    End If
                Next
            Next
        End If

        'Sort list in ascending order for easy usability
        LocationsListBox.Sorted = True
    End Sub

    ''' 
    ''' Description : Procedure which adds a new monitor of selected location to be displayed in the MainPage
    '''
    Private Sub AddLocation(ByVal controller As WeatherController)
        'If one of the options are selected and a location is selected
        If (TemperatureCheck.Checked Or RainfallCheck.Checked) And (LocationsListBox.SelectedIndex >= 0) Then
            'Hide introduction picture
            IntroPict.Visible = False
            FlowPanel.Visible = True

            Dim m As Monitor = Nothing

            Dim location As String = LocationsListBox.SelectedItem()
            'If both are selected
            If TemperatureCheck.Checked And RainfallCheck.Checked Then
                m = controller.CreateMonitor(location)
                'If only temperature option is checked
            ElseIf TemperatureCheck.Checked Then
                m = controller.CreateTemperatureMonitor(location)
            ElseIf RainfallCheck.Checked Then
                'If only rainfall option is checked
                m = controller.CreateRainfallMonitor(location)
            End If

            'If text monitor option is selected
            If MonitorComboBox.SelectedIndex = 0 Then
                DrawLabel(m)
            Else
                'If graph monitor option is selected
                DrawChart(m)
            End If
        Else
            MsgBox("Please, select at least one info that you wish to view and a location !")
        End If
    End Sub

    ''' 
    ''' Description : Procedure which interprets data fed by the Monitor and displays a new chart control in the MainPage
    ''' Return      : None
    ''' Param       : Monitor to be displayed
    '''
    Private Sub DrawChart(ByVal monitor As Monitor)
        Dim dataArray As String() = monitor.FeedData()

        'These 2 boolean values are used for marking cross
        Dim validTemp As Boolean = True
        Dim validRain As Boolean = True

        'If dataArray contains both temperature and rainfall info
        If dataArray.Length = 3 Then
            'If data is not valid, assign zero for initial value
            If dataArray(0) = "-" Then
                validTemp = False
                dataArray(0) = "0.0"
            End If

            If dataArray(1) = "-" Then
                validRain = False
                dataArray(1) = "0.0"
            End If

            'If dataArray contains only temperature or only rainfall info
        ElseIf dataArray.Length = 2 Then
            If monitor.GetMonitorType = InfoType.Temperature Then
                If dataArray(0) = "-" Then
                    validTemp = False
                    dataArray(0) = "0.0"
                End If
            ElseIf monitor.GetMonitorType = InfoType.Rainfall Then
                If dataArray(0) = "-" Then
                    validRain = False
                    dataArray(0) = "0.0"
                End If
            End If

        End If

        'Declare and initialize a new chart control
        Dim chart As Chart = New Chart
        'Set up properties
        chart.Margin = New Padding(10, 10, 10, 10)
        chart.BorderlineWidth = 1
        chart.BorderlineDashStyle = ChartDashStyle.Solid
        chart.BorderlineColor = Color.DarkGray

        'Give the chart color code
        'If live server is selected, give gray colour for the background
        If ServerComboBox.SelectedIndex = 0 Then
            chart.BackColor = Color.FromArgb(20, 65, 65, 65)
        ElseIf ServerComboBox.SelectedIndex = 1 Then
            'If time lapse server is selected, color the background with yellow colour
            chart.BackColor = Color.FromArgb(100, 255, 217, 0)
        End If

        chart.ChartAreas.Add("Default")
        chart.ChartAreas(0).BackColor = Color.White

        'Add and format the title
        chart.Titles.Add(monitor.GetLocation)
        chart.Titles(0).Font = New Font("Lato", 12, FontStyle.Bold)
        chart.Legends.Add("Default")
        chart.Legends(0).Font = New Font("Lato", 11)
        chart.Legends(0).BackColor = Color.Transparent

        'Add 2 new data points if monitor displays both temperature and rainfall
        If monitor.GetMonitorType = InfoType.Both Then
            chart.Series.Add("Temperature (°C)")
            chart.Series(0).Color = Color.Gray
            'Add initial data
            chart.Series(0).Points.AddXY(dataArray(2), CDbl(dataArray(0)))

            chart.Series.Add("Rainfall (mm)")
            chart.Series(1).Color = Color.ForestGreen
            'Add initial data
            chart.Series(1).Points.AddXY(dataArray(2), CDbl(dataArray(1)))

            'Add 1 new data point if monitor displays temperature only or rainfall only
        ElseIf monitor.GetMonitorType = InfoType.Temperature Then
            chart.Series.Add("Temperature (°C)")
            chart.Series(0).Color = Color.Gray
            chart.Series(0).Points.AddXY(dataArray(1), CDbl(dataArray(0)))

        ElseIf monitor.GetMonitorType = InfoType.Rainfall Then
            chart.Series.Add("Rainfall (mm)")
            chart.Series(0).Color = Color.ForestGreen
            'Add initial data
            chart.Series(0).Points.AddXY(dataArray(1), CDbl(dataArray(0)))
        End If

        'Set common properties' values of chart's series
        For Each s As Series In chart.Series
            s.XValueType = ChartValueType.String
            s.YValueType = ChartValueType.Double
            s.ChartType = SeriesChartType.Line
            s.BorderWidth = 2
            s.MarkerStyle = MarkerStyle.Circle
            s.MarkerSize = 6
        Next

        'Put a cross marker on invalid data
        If monitor.GetMonitorType = InfoType.Both Then
            If Not validTemp Then
                chart.Series(0).Points(0).MarkerStyle = MarkerStyle.Cross
                chart.Series(0).Points(0).MarkerColor = Color.Red
                chart.Series(0).Points(0).MarkerSize = 9
            End If

            If Not validRain Then
                chart.Series(1).Points(0).MarkerStyle = MarkerStyle.Cross
                chart.Series(1).Points(0).MarkerColor = Color.Red
                chart.Series(1).Points(0).MarkerSize = 9
            End If
        ElseIf monitor.GetMonitorType = InfoType.Temperature Then
            If Not validTemp Then
                chart.Series(0).Points(0).MarkerStyle = MarkerStyle.Cross
                chart.Series(0).Points(0).MarkerColor = Color.Red
                chart.Series(0).Points(0).MarkerSize = 9
            End If
        ElseIf monitor.GetMonitorType = InfoType.Rainfall Then
            If Not validRain Then
                chart.Series(0).Points(0).MarkerStyle = MarkerStyle.Cross
                chart.Series(0).Points(0).MarkerColor = Color.Red
                chart.Series(0).Points(0).MarkerSize = 9
            End If
        End If

        'Associate chart with monitor
        chart.Tag = monitor
        'Adjust the size of the chart
        chart.Size = New Point(545, 150)
        'Add the chart to the list
        chartList.Add(chart)
        'Display the chart
        FlowPanel.Controls.Add(chart)

    End Sub

    ''' 
    ''' Description : Procedure which interprets data fed by the Monitor and displays a new label control in the MainPage
    ''' Return      : None
    ''' Param       : Monitor to be displayed
    '''
    Private Sub DrawLabel(ByVal monitor As Monitor)
        Dim data As String() = monitor.FeedData()
        Dim label As Label = New Label()

        'If the live server is selected
        If ServerComboBox.SelectedIndex = 0 Then
            label.BackColor = Color.FromArgb(40, 65, 65, 65)
        ElseIf ServerComboBox.SelectedIndex = 1 Then
            label.BackColor = Color.FromArgb(140, 255, 217, 0)
        End If

        'Associate label with monitor
        label.Tag = monitor

        If monitor.GetMonitorType = InfoType.Both Then
            label.Text = monitor.GetLocation & vbNewLine & "Temperature: " & data(0) & " °C" & vbNewLine & "Rainfall: " & data(1) & " mm" & vbNewLine & "Last Update: " & data(2)
        ElseIf monitor.GetMonitorType = InfoType.Temperature Then
            label.Text = monitor.GetLocation & vbNewLine & "Temperature: " & data(0) & " °C" & vbNewLine & "Last Update: " & data(1)
        ElseIf monitor.GetMonitorType = InfoType.Rainfall Then
            label.Text = monitor.GetLocation & vbNewLine & "Rainfall: " & data(0) & " mm" & vbNewLine & "Last Update: " & data(1)
        End If

        'Setup label's properties
        label.Size = New Point(260, 100)
        label.BorderStyle = BorderStyle.Fixed3D
        label.Margin = New Padding(10, 10, 10, 10)

        label.Padding = New Padding(0, 8, 0, 0)
        label.Font = New Drawing.Font("Lato", 12, FontStyle.Regular)

        'Add monitor label to the list
        FlowPanel.Controls.Add(label)
        labelList.Add(label)
        Me.Update()
    End Sub

    ''' 
    ''' Description : Procedure which sends request to the controller to update active WeatherLocations
    ''' Return      : None
    ''' Param       : controller As WeatherController, the controller which the GUI sends request to.
    ''' Post        : WeatherLocation and associated monitors are updated. Displayed text and graphs are also updated if only Monitor has new data.
    '''
    Private Sub UpdateLocations(ByVal controller As WeatherController)
        Dim counter, index As Integer
        'Get the number of selected locations
        Dim numLocation As Integer = controller.GetNumberOfLocations()

        UpdateBar.Value = 0
        UpdateBar.Maximum = numLocation
        UpdateBar.Visible = True
        UpdateNumberLbl.Text = "Updating " & counter & " of " & numLocation & " live location(s)"
        UpdateNumberLbl.Visible = True
        RefreshPict.Visible = True

        For index = 0 To numLocation - 1
            counter += 1
            UpdateBar.Value += 1
            Me.Update()
            controller.UpdateLocation(index)
            UpdateNumberLbl.Text = "Updating " & counter & " of " & numLocation & " live location(s)"
            Me.Update()
        Next

        UpdateControls()

        UpdateBar.Visible = False
        UpdateNumberLbl.Visible = False
        RefreshPict.Visible = False
    End Sub
   
   
    ''' 
    ''' Description : Procedure which updates the controls (label and chart) in the MainPage to displays the current data contained in the associated monitor
    ''' Return      : None
    ''' Param       : None
    ''' Post        : WeatherLocation and associated monitors are updated. Displayed text and graphs are also updated if Monitor has new data.
    '''
    Private Sub UpdateControls()
        Dim monitor As Monitor
        'Update each label whose monitor has new data
        For Each lbl As Label In labelList
            'Get the associated monitor from the label's tag
            monitor = CType(lbl.Tag, Monitor)
            'Only update if monitor object has new data
            If monitor.HasNewData() Then
                Dim data As String() = monitor.FeedData()
                If monitor.GetMonitorType = InfoType.Both Then
                    lbl.Text = monitor.GetLocation & vbNewLine & "Temperature: " & data(0) & " °C" & vbNewLine & "Rainfall: " & data(1) & " mm" & vbNewLine & "Last Update: " & data(2)
                ElseIf monitor.GetMonitorType = InfoType.Temperature Then
                    lbl.Text = monitor.GetLocation & vbNewLine & "Temperature: " & data(0) & " °C" & vbNewLine & "Last Update: " & data(1)
                ElseIf monitor.GetMonitorType = InfoType.Rainfall Then
                    lbl.Text = monitor.GetLocation & vbNewLine & "Rainfall: " & data(0) & " mm" & vbNewLine & "Last Update: " & data(1)
                End If
            End If
        Next

        'Update each chart whose monitor has new data
        For Each c As Chart In chartList
            'Get the associated monitor from the chart's tag
            monitor = CType(c.Tag, Monitor)
            If monitor.HasNewData() Then
                Dim data As String() = monitor.FeedData()

                'These 2 boolean values are used for marking cross
                Dim validTemp As Boolean = True
                Dim validRain As Boolean = True

                'Do some data validations
                If data.Length = 3 Then
                    'If temperature is "-"
                    If data(0) = "-" Then
                        validTemp = False
                        'Get the previous data from the previous data point in the series
                        Dim numOfPoints As Integer = c.Series(0).Points.Count
                        data(0) = CStr(c.Series(0).Points(numOfPoints - 1).YValues(0))
                    End If

                    'If rainfall is "-"
                    If data(1) = "-" Then
                        validRain = False
                        If c.Series.Count = 1 Then
                            'Get the previous data from the previous data point in the series
                            Dim numOfPoints As Integer = c.Series(0).Points.Count
                            data(1) = CStr(c.Series(0).Points(numOfPoints - 1).YValues(0))

                        ElseIf c.Series.Count = 2 Then
                            'Get the previous data from the previous data point in the series
                            Dim numOfPoints As Integer = c.Series(1).Points.Count
                            data(1) = CStr(c.Series(1).Points(numOfPoints - 1).YValues(0))
                        End If
                    End If

                ElseIf data.Length = 2 Then
                    If monitor.GetMonitorType = InfoType.Temperature Then
                        'If temperature is "-"
                        If data(0) = "-" Then
                            validTemp = False
                            'Get the previous data from the previous data point in the series
                            Dim numOfPoints As Integer = c.Series(0).Points.Count
                            data(0) = CStr(c.Series(0).Points(numOfPoints - 1).YValues(0))
                        End If
                    ElseIf monitor.GetMonitorType = InfoType.Rainfall Then
                        'If temperature is "-"
                        If data(0) = "-" Then
                            validRain = False
                            'Get the previous data from the previous data point in the series
                            Dim numOfPoints As Integer = c.Series(0).Points.Count
                            data(0) = CStr(c.Series(0).Points(numOfPoints - 1).YValues(0))
                        End If

                    End If
                End If


                'If it is a temperature only / rainfall only monitor
                If data.Length = 2 Then
                    c.Series(0).Points.AddXY(data(1), CDbl(data(0)))

                    'If it is a monitor which displays both temperature and rainfall
                ElseIf data.Length = 3 Then
                    'Add new point for temperature
                    c.Series(0).Points.AddXY(data(2), CDbl(data(0)))
                    'Add new point for rainfall
                    c.Series(1).Points.AddXY(data(2), CDbl(data(1)))
                End If

                Dim lastPointIndex = c.Series(0).Points.Count - 1
                'Mark invalid temperature or rainfall with cross symbol
                If monitor.GetMonitorType = InfoType.Both Then
                    If Not validTemp Then
                        c.Series(0).Points(lastPointIndex).MarkerStyle = MarkerStyle.Cross
                        c.Series(0).Points(lastPointIndex).MarkerSize = 9
                        c.Series(0).Points(lastPointIndex).MarkerColor = Color.Red
                    End If

                    If Not validRain Then
                        c.Series(1).Points(lastPointIndex).MarkerStyle = MarkerStyle.Cross
                        c.Series(1).Points(lastPointIndex).MarkerSize = 9
                        c.Series(1).Points(lastPointIndex).MarkerColor = Color.Red
                    End If
                ElseIf monitor.GetMonitorType = InfoType.Temperature Then
                    If Not validTemp Then
                        c.Series(0).Points(lastPointIndex).MarkerStyle = MarkerStyle.Cross
                        c.Series(0).Points(lastPointIndex).MarkerSize = 9
                        c.Series(0).Points(lastPointIndex).MarkerColor = Color.Red
                    End If
                ElseIf monitor.GetMonitorType = InfoType.Rainfall Then
                    If Not validRain Then
                        c.Series(0).Points(lastPointIndex).MarkerStyle = MarkerStyle.Cross
                        c.Series(0).Points(lastPointIndex).MarkerSize = 9
                        c.Series(0).Points(lastPointIndex).MarkerColor = Color.Red
                    End If
                End If

            End If
        Next
    End Sub

    'When the timer ticks, update active time lapse WeatherLocations in the time lapse controller
    Private Sub TimeLapseTimer_Tick(sender As Object, e As EventArgs) Handles TimeLapseTimer.Tick
        UpdateLocations(timeLapseController)
    End Sub

    'When the timer ticks, update active live WeatherLocations in the time lapse controller
    Private Sub LiveTimer_Tick(sender As Object, e As EventArgs) Handles LiveTimer.Tick
        UpdateLocations(liveController)
    End Sub
End Class
