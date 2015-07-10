'''
''' Project     : FIT3077 Assignment
''' Class       : TimeLapseTemperatureMonitor
''' Author      : Arvin Wiyono (awiy1)
''' Modified    : 20 May 2015
''' Description : Subclass of TimeLapseMonitor superclass, which feeds only the latest temperature data and date/time
''' Precondition: WeatherLocation class and Info enumeration are required - Superclass TimeLapseMonitor exists 
''' 

Public Class TimeLapseTemperatureMonitor
    Inherits TimeLapseMonitor

    ''' 
    ''' Class constructor
    ''' Return      : TimeLapseTemperatureMonitor object
    ''' Param       : wl As WeatherLocation
    '''
    Sub New(ByVal wl As WeatherLocation)
        'Triggered the superclass constructor
        MyBase.New(wl)
        infoType = InfoType.Temperature
    End Sub

    ''' 
    ''' Description : Giving data to the requestor
    ''' Return      : Array of String = (temperature, date/time)
    ''' Param       : None
    ''' 
    Public Overrides Function FeedData() As String()
        DoneFeedData()
        Dim array(1) As String
        Dim temp, datetime As String
        Dim rangeHistory As Integer = temperatureList.Count - 1

        'If valid, feed the latest temperature in the history list As a String. Else, feed with "-"
        If validTemperature.Item(rangeHistory) = True Then
            temp = CStr(temperatureList.Item(temperatureList.Count - 1))
        Else
            temp = "-"
        End If

        'Put the data in the array to be returned
        datetime = CStr(dateTimeList.Item(dateTimeList.Count - 1))
        array(0) = temp
        array(1) = datetime
        Return array
    End Function
End Class
