'''
''' Project     : FIT3077 Assignment
''' Class       : LiveTemperatureMonitor
''' Author      : Arvin Wiyono (awiy1)
''' Modified    : 20 May 2015
''' Description : Subclass of LiveMonitor superclass, which feeds only the temperature data and date/time
''' Precondition: WeatherLocation class and Info enumeration are required - Superclass LiveMonitor exists 
''' 

Public Class LiveTemperatureMonitor
    Inherits LiveMonitor

    ''' 
    ''' Class constructor
    ''' Return      : LiveTemperatureMonitor object
    ''' Param       : wl As WeatherLocation
    '''
    Sub New(ByVal wl As WeatherLocation)
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
        array(0) = CStr(temperature)
        array(1) = CStr(lastUpdate)
        Return array
    End Function

End Class
