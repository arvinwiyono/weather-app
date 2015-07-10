'''
''' Project     : FIT3077 Assignment
''' Class       : LiveRainfallMonitor
''' Author      : Arvin Wiyono (awiy1)
''' Modified    : 20 May 2015
''' Description : Subclass of LiveMonitor superclass, which feeds only the rainfall data and date/time
''' Precondition: WeatherLocation class and Info enumeration are required - Superclass LiveMonitor exists 
''' 

Public Class LiveRainfallMonitor
    Inherits LiveMonitor

    ''' 
    ''' Class constructor
    ''' Return      : LiveRainfallMonitor object
    ''' Param       : wl As WeatherLocation
    '''
    Sub New(ByVal wl As WeatherLocation)
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
        array(0) = CStr(rainfall)
        array(1) = CStr(lastUpdate)
        Return array
    End Function

End Class
