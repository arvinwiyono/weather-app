'''
''' Project     : FIT3077 Assignment
''' Class       : LiveMonitor
''' Author      : Arvin Wiyono (awiy1)
''' Modified    : 21 May 2015
''' Description : An abstract class deriving from Monitor superclass, which observes a WeatherLocation in a 'Live' manner
''' Precondition: Monitor superclass and WeatherLocation classes are required
''' 

Public MustInherit Class LiveMonitor
    Inherits Monitor

    'Declare common attributes possessed by LiveMonitor objects
    Protected temperature, rainfall, lastUpdate As String

    ''' 
    ''' Class constructor
    ''' Param       : wl As WeatherLocation
    '''
    Sub New(ByVal wl As WeatherLocation)
        MyBase.New()
        'Triggers the superclass constructor
        weatherLocation = wl
        GetInfo()
    End Sub

    ''' 
    ''' Description : Get data from the observed WeatherLocation
    ''' Return      : None
    ''' Param       : None
    '''
    Public Overrides Sub GetInfo()
        location = weatherLocation.GetLocation()
        temperature = weatherLocation.GetTemperature()
        rainfall = weatherLocation.GetRainfall()
        lastUpdate = weatherLocation.GetLastUpdate()
    End Sub

End Class
