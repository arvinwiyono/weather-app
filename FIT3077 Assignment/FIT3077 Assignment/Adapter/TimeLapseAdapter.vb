'''
''' Project     : FIT3077 Assignment
''' Class       : LiveAdapter
''' Author      : Arvin Wiyono (awiy1) 
''' Modified    : 18 May 2015
''' Description : Subclass of WeatherAdapter superclass
''' Precondition: Required wsdl server is available
'''

Public Class TimeLapseAdapter
    Inherits WeatherAdapter

    Private server As MonashTimeLapse.MelbourneWeatherTimeLapse

    ''' 
    ''' Class constructor
    ''' Return      : TimeLapseAdapter object
    ''' Param       : None
    ''' 
    Sub New()
        'Set the update interval to 20 seconds (20,000 milliseconds)
        MyBase.New(20000)
        server = New MonashTimeLapse.MelbourneWeatherTimeLapse()
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
    Public Overrides Function GetWeather(location As String) As String()
        Dim returnArray(2) As String
        Dim info As String() = server.getWeather(location)

        If (info(1) <> "-") Then
            Dim kelvin As Double = CDbl(info(1))
            Dim celcius As Double = kelvin - 273.15
            'Round celcius with 2 decimal digits
            celcius = Math.Round(celcius, 2)
            'First element of array is temperature
            returnArray(0) = CStr(celcius)
        Else
            returnArray(0) = info(1)
        End If

        'Second element of array is rainfall
        If info(2) = "Trace" Then
            returnArray(1) = "0.0"
        ElseIf (info(2) <> "-") Then
            'Rainfall is rounded with 2 decimal places
            Dim rainfall As Double = Math.Round(CDbl(info(2)), 2)
            returnArray(1) = CStr(rainfall)
        Else
            returnArray(1) = info(2)
        End If
        'Third element of array is the date/time
        returnArray(2) = info(0)

        Return returnArray
    End Function
End Class
