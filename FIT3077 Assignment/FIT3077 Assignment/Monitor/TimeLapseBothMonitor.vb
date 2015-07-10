'''
''' Project     : FIT3077 Assignment
''' Class       : TimeLapseBothMonitor
''' Author      : Arvin Wiyono (awiy1)
''' Modified    : 21 May 2015
''' Description : Subclass of TimeLapseMonitor superclass, which feeds both latest temperature and rainfall data, and date/time
''' Precondition: WeatherLocation class and Info enumeration are required - Superclass TimeLapseMonitor exists 
''' 

Public Class TimeLapseBothMonitor
    Inherits TimeLapseMonitor

    ''' 
    ''' Class constructor
    ''' Return      : TimeLapseBothMonitor object
    ''' Param       : wl As WeatherLocation
    '''
    Public Sub New(ByVal wl As WeatherLocation)
        'Triggered the superclass constructor
        MyBase.New(wl)
        infoType = infoType.Both
    End Sub

    ''' 
    ''' Description : Giving data to the requestor
    ''' Return      : Array of String = (temperature, rainfall, date/time)
    ''' Param       : None
    ''' 
    Public Overrides Function FeedData() As String()
        'Set boolean newData to False
        DoneFeedData()
        Dim array(2) As String
        Dim temp, rain, datetime As String
        Dim rangeHistory As Integer = temperatureList.Count - 1

        'If valid, feed the latest temperature in the history list As a String. Else, feed "-"
        If validTemperature.Item(rangeHistory) = True Then
            temp = CStr(temperatureList.Item(temperatureList.Count - 1))
        Else
            temp = "-"
        End If

        'If valid, feed the latest rainfall in the history list As a String. Else, feed "-"
        If validRainfall.Item(rangeHistory) = True Then
            rain = CStr(rainfallList.Item(rainfallList.Count - 1))
        Else
            rain = "-"
        End If

        datetime = CStr(dateTimeList.Item(dateTimeList.Count - 1))

        'Put the converted data to the return array
        array(0) = temp
        array(1) = rain
        array(2) = datetime

        Return array
    End Function
End Class
