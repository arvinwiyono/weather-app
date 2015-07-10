'''
''' Project     : FIT3077 Assignment
''' Class       : LiveBothMonitor
''' Author      : Arvin Wiyono (awiy1)
''' Modified    : 21 May 2015
''' Description : Subclass of LiveMonitor superclass, which feeds both the temperature and rainfall data, and date/time
''' Precondition: WeatherLocation class and Info enumeration are required - Superclass LiveMonitor exists 
''' 

Public Class LiveBothMonitor
    Inherits LiveMonitor

    ''' 
    ''' Class constructor
    ''' Return      : LiveBothMonitor object
    ''' Param       : wl As WeatherLocation
    '''
    Public Sub New(ByVal wl As WeatherLocation)
        'Triggered superclass constructor
        MyBase.New(wl)
        'Displays both temperature and rainfall weather info
        infoType = infoType.Both
    End Sub


    ''' 
    ''' Description : Giving data to the client
    ''' Return      : Array of String = (temperature, rainfall, date/time)
    ''' Param       : None
    ''' 
    Public Overrides Function FeedData() As String()
        'Set the boolean newData value to False
        DoneFeedData()

        Dim array(2) As String
        'Convert to string
        array(0) = CStr(temperature)
        array(1) = CStr(rainfall)
        array(2) = CStr(lastUpdate)
        Return array

    End Function
End Class
