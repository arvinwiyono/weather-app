'''
''' Project     : FIT3077 Assignment
''' Class       : LiveWeatherController
''' Author      : Arvin Wiyono (awiy1)
''' Modified    : 21 May 2015
''' Description : Subclass of WeatherController which handles system requests regarding WeatherLocations which use services provided by the LiveAdapter
''' Required    : LiveAdapter, Monitor, LiveBothMonitor, LiveTemperatureMonitor, LiveRainfallMonitor, WeatherLocation, WeatherController
'''

Public Class LiveWeatherController
    Inherits WeatherController

    ''' 
    ''' Class constructor
    ''' Return      : LiveWeatherController object
    ''' Param       : None
    ''' 
    Sub New()
        MyBase.New()
        'Use services provided by the LiveAdapter
        server = New LiveAdapter()
    End Sub

    ''' 
    ''' Description : Creates a monitor which feeds only temperature info
    ''' Return      : Monitor object
    ''' Param       : Name of location as String
    ''' Post        : WeatherLocation with the specified location exists with monitor attached
    '''
    Public Overrides Function CreateTemperatureMonitor(ByVal location As String) As Monitor
        Dim checkIndex As Integer = LocationExists(location)
        Dim monitor As Monitor

        'If location exists in the list, attach monitor
        If checkIndex >= 0 Then
            monitor = New LiveTemperatureMonitor(selectedLocations.Item(checkIndex))
            selectedLocations.Item(checkIndex).AttachMonitor(monitor)
        Else
            Dim weatherLocation As MelbourneWeatherLocation = New MelbourneWeatherLocation(location, server)
            monitor = New LiveTemperatureMonitor(weatherLocation)

            'Attach the monitor to the weather location
            weatherLocation.AttachMonitor(monitor)
            'Add a new location to the selected location list
            selectedLocations.Add(weatherLocation)
        End If
        Return monitor

    End Function

    ''' 
    ''' Description : Creates a monitor which feeds only rainfall info
    ''' Return      : Monitor object
    ''' Param       : Name of location as String
    ''' Post        : WeatherLocation with the specified location exists with monitor attached
    '''
    Public Overrides Function CreateRainfallMonitor(ByVal location As String) As Monitor

        Dim checkIndex As Integer = LocationExists(location)
        Dim monitor As Monitor
        'If location exists in the list, attach monitor
        If checkIndex >= 0 Then
            monitor = New LiveRainfallMonitor(selectedLocations.Item(checkIndex))
            selectedLocations.Item(checkIndex).AttachMonitor(monitor)

        Else
            Dim weatherLocation As MelbourneWeatherLocation = New MelbourneWeatherLocation(location, server)
            monitor = New LiveRainfallMonitor(weatherLocation)

            weatherLocation.AttachMonitor(monitor)
            'Add a new location to the selected location list
            selectedLocations.Add(weatherLocation)

        End If

        Return monitor

    End Function

    ''' 
    ''' Description : Creates a monitor which feeds both temperature and rainfall info
    ''' Return      : Monitor object
    ''' Param       : Name of location as String
    ''' Post        : WeatherLocation with the specified location exists with monitor attached
    '''
    Public Overrides Function CreateMonitor(ByVal location As String) As Monitor
        Dim checkIndex As Integer = LocationExists(location)
        Dim monitor As Monitor
        'If location exists in the list, attach monitor
        If checkIndex >= 0 Then
            monitor = New LiveBothMonitor(selectedLocations.Item(checkIndex))
            selectedLocations.Item(checkIndex).AttachMonitor(monitor)
        Else
            Dim weatherLocation As MelbourneWeatherLocation = New MelbourneWeatherLocation(location, server)
            monitor = New LiveBothMonitor(weatherLocation)

            weatherLocation.AttachMonitor(monitor)
            selectedLocations.Add(weatherLocation)
        End If

        Return monitor
    End Function

End Class
