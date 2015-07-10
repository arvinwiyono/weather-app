'''
''' Project     : FIT3077 Assignment
''' Class       : TimeLapseRainfallMonitor
''' Author      : Arvin Wiyono (awiy1)
''' Modified    : 20 May 2015
''' Description : Subclass of TimeLapseMonitor superclass, which feeds only the latest rainfall data and date/time
''' Precondition: WeatherLocation class and Info enumeration are required - Superclass TimeLapseMonitor exists 
''' 

Public Class TimeLapseRainfallMonitor
    Inherits TimeLapseMonitor

    ''' 
    ''' Class constructor
    ''' Return      : TimeLapseRainfallMonitor object
    ''' Param       : wl As WeatherLocation
    '''
    Sub New(ByVal wl As WeatherLocation)
        'Triggered the superclass constructor
        MyBase.New(wl)
        infoType = InfoType.Rainfall
    End Sub

    ''' 
    ''' Description : Giving data to the requestor
    ''' Return      : Array of String = (rainfall, date/time)
    ''' Param       : None
    ''' 
    Public Overrides Function FeedData() As String()
        DoneFeedData()
        Dim array(1) As String
        Dim rain, datetime As String
        Dim rangeHistory As Integer = temperatureList.Count - 1

        'If valid, feed the latest rainfall in the history list As a String. Else, feed with "-"
        If validRainfall.Item(rangeHistory) = True Then
            rain = CStr(rainfallList.Item(rainfallList.Count - 1))
        Else
            rain = "-"
        End If

        datetime = CStr(dateTimeList.Item(dateTimeList.Count - 1))
        'Put the data in the array to be returned
        array(0) = rain
        array(1) = datetime
        Return array
    End Function
End Class
