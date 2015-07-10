'''
''' Project     : FIT3077 Assignment
''' Class       : MelbourneWeatherLocation
''' Author      : Arvin Wiyono (awiy1) and Darren Wong (dwwon6)
''' Modified    : 19 May 2015
''' Description : Subclass of WeatherLocation
''' Precondition: WeatherAdapter and Monitor classes are required - WeatherLocation superclass exists
''' 

Public Class MelbourneWeatherLocation
    Inherits WeatherLocation

    'Declare attributes to store data
    Private temperature, rainfall, lastUpdate As String

    ''' 
    ''' Class constructor
    ''' Return      : MelbourneWeatherLocation object
    ''' Param       : Location name As String - WeatherAdapter, from which the data will be requested
    ''' 
    Public Sub New(ByVal l As String, ByVal s As WeatherAdapter)
        MyBase.New(l, s)
        'Initialize attributes
        GetData()
    End Sub


    'Attribute accessors
    Public Function GetTemperature() As String
        Return temperature
    End Function

    Public Function GetRainfall() As String
        Return rainfall
    End Function

    Public Function GetLastUpdate() As String
        Return lastUpdate
    End Function

    ''' 
    ''' Description : Check whether old and new data are different. This means that Monitors will be updated as necessary.
    ''' Return      : This function returns True if there is a difference between the old and the new data. False otherwise.
    ''' Param       : None
    ''' 
    Public Overrides Function CheckData() As Boolean
        Dim tempTemperature, tempRainfall, tempLastUpdate As String
        'Store all old attribute values to temporary variables
        tempTemperature = temperature
        tempRainfall = rainfall
        tempLastUpdate = lastUpdate

        'Get the new data from the WeatherAdapter
        GetData()
        'Do some comparisons
        If (String.Compare(temperature, tempTemperature) <> 0 Or String.Compare(rainfall, tempRainfall) <> 0 Or String.Compare(lastUpdate, tempLastUpdate) <> 0) Then
            Return True
        End If

        Return False
    End Function

    ''' 
    ''' Description : Gets data from the WeatherAdapter
    ''' Return      : None
    ''' Param       : None
    ''' Post        : Attributes contain the latest data taken from the server 
    ''' Remark      : Latest data does not mean different data
    ''' 
    Public Overrides Sub GetData()
        'Get data from the server
        Dim info As String() = server.GetWeather(location)
        temperature = info(0)
        rainfall = info(1)
        lastUpdate = info(2)
    End Sub
End Class
