'''
''' Project     : FIT3077 Assignment
''' Class       : LiveAdapter
''' Author      : Arvin Wiyono (awiy1) 
''' Modified    : 18 May 2015
''' Description : Subclass of WeatherAdapter superclass
''' Precondition: Required wsdl server is available
'''

Public Class LiveAdapter
    Inherits WeatherAdapter

    Private server As MonashLive.MelbourneWeather2

    ''' 
    ''' Class constructor
    ''' Return      : LiveAdapter object
    ''' Param       : None
    ''' 
    Sub New()
        'Set the update interval to 5 minutes (300,000 milliseconds)
        MyBase.New(300000)
        server = New MonashLive.MelbourneWeather2()
    End Sub


    ''' 
    ''' Description : Transfer the available locations provided by the server - only these locations whose weather info can be requested
    ''' Return      : Array of available locations as an array of Strings
    ''' Param       : None
    ''' 
    Public Overrides Function GetLocations() As String()
        Return server.getLocations()
    End Function


    ''' 
    ''' Description : Transfer the data provided by the server to the requestor (WeatherLocation)
    ''' Return      : Array of Strings = (temperature, rainfall, date/time)
    ''' Param       : Name of location as String
    '''
    Public Overrides Function GetWeather(ByVal location As String) As String()

        Dim returnArray(2) As String
        Dim tempTemperature As String() = server.getTemperature(location)
        Dim tempRainfall As String() = server.getRainfall(location)

        'First element of array is temperature
        returnArray(0) = tempTemperature(1)
        'Second element of array is rainfall
        returnArray(1) = tempRainfall(1)
        'Third element of array is the date/time
        returnArray(2) = tempTemperature(0)

        Return returnArray
    End Function
End Class
