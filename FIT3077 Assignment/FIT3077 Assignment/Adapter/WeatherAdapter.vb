'''
''' Project     : FIT3077 Assignment
''' Class       : WeatherAdapter
''' Author      : Arvin Wiyono (awiy1) and Darren Wong (dwwon6)
''' Modified    : 18 May 2015
''' Description : An abstract class which encapsulates and bridges the transfer of data between the real server and the WeatherLocation
''' Precondition: None
'''

Public MustInherit Class WeatherAdapter

    'Update interval is used for determining how often data is updated in the server. This is also used by the system to ask the active WeatherLocations to request new data from the Adapter
    'The update interval is specified in MILLISECOND unit
    Private updateInterval As Integer


    ''' 
    ''' Superclass constructor
    ''' Return      : WeatherAdapter object
    ''' Param       : The update interval time as Integer specified in millisecond unit
    ''' 
    Sub New(ByVal interval As Integer)
        updateInterval = interval
    End Sub

    'Abstract functions which must be overriden by the subclasses
    MustOverride Function GetLocations() As String()
    MustOverride Function GetWeather(ByVal location As String) As String()

    ''' 
    ''' Description : Getting the value of updateInterval attribute
    ''' Return      : The update interval time as Integer
    ''' Param       : None
    '''
    Public Function GetUpdateInterval() As Integer
        Return updateInterval
    End Function
End Class
