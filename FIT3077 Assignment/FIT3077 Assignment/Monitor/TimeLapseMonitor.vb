'''
''' Project     : FIT3077 Assignment
''' Class       : TimeLapseMonitor
''' Author      : Arvin Wiyono (awiy1)
''' Modified    : 21 May 2015
''' Description : An abstract class deriving from Monitor superclass, which observes a WeatherLocation in a 'Time Lapse' manner by 
'''               keeping history of datum in separate lists
''' Precondition: Monitor superclass and WeatherLocation class are required
''' 

Public MustInherit Class TimeLapseMonitor
    Inherits Monitor

    'Keep data history in a list of Doubles for both temperature and rainfall
    Protected temperatureList, rainfallList As List(Of Double)

    'This is used to determine whether invalid data ("-") is read from the observed WeatherLocation
    Protected validTemperature, validRainfall As List(Of Boolean)

    'Store list of date/time in a list of String
    Protected dateTimeList As List(Of String)

    ''' 
    ''' Class constructor
    ''' Param       : wl As WeatherLocation
    ''' Remark      : This will initialize all list attributes and get the frist data from the server
    '''
    Sub New(ByVal wl As WeatherLocation)
        temperatureList = New List(Of Double)
        rainfallList = New List(Of Double)
        validTemperature = New List(Of Boolean)
        validRainfall = New List(Of Boolean)
        dateTimeList = New List(Of String)
        weatherLocation = wl
        GetInfo()
    End Sub

    ''' 
    ''' Description : Read data from the observed WeatherLocation and store them in the appropriate list
    ''' Return      : None
    ''' Param       : None
    ''' 
    Public Overrides Sub GetInfo()
        location = weatherLocation.GetLocation()

        Dim temp, rain As String
        temp = weatherLocation.GetTemperature()

        'If data is valid
        If (temp <> "-") Then
            'Convert data to Double and store in the temperature list. Set boolean to True
            temperatureList.Add(CDbl(temp))
            validTemperature.Add(True)
        Else
            'If list is still empty, give it zero value
            If temperatureList.Count = 0 Then
                temperatureList.Add(0.0)
            Else
                'If not empty, add the latest value again
                temperatureList.Add(temperatureList.Item(temperatureList.Count - 1))
            End If
            validTemperature.Add(False)
        End If

        rain = weatherLocation.GetRainfall()
        If (rain <> "-") Then
            rainfallList.Add(CDbl(rain))
            validRainfall.Add(True)
        Else
            'If list is still empty, give it zero value
            If rainfallList.Count = 0 Then
                rainfallList.Add(0.0)
            Else
                'If not empty, add the latest value again
                rainfallList.Add(rainfallList.Item(rainfallList.Count - 1))
            End If
            validRainfall.Add(False)
        End If
        'Store date/time As String
        dateTimeList.Add(weatherLocation.GetLastUpdate())
    End Sub
End Class
