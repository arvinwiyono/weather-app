'''
''' Project     : FIT3077 Assignment
''' Class       : TimeLapseWeatherController
''' Author      : Arvin Wiyono (awiy1)
''' Modified    : 21 May 2015
''' Description : Subclass of WeatherController which handles system requests regarding WeatherLocations which use services provided by the TimeLapseAdapter
''' Required    : TimeLapseAdapter, Monitor, TimeLapseBothMonitor, TimeLapseTemperatureMonitor, TimeLapseRainfallMonitor, WeatherLocation, WeatherController
'''


Public Class TimeLapseWeatherController
    Inherits WeatherController

    ''' 
    ''' Class constructor
    ''' Return      : TimeLapseWeatherController object
    ''' Param       : None
    ''' 
    Sub New()
        'Triggers superclass constructor
        MyBase.New()
        'Use services provided by the TimeLapseAdapter
        server = New TimeLapseAdapter()
    End Sub

    ''' 
    ''' Description : Creates a monitor which feeds both temperature and rainfall info
    ''' Return      : Monitor object
    ''' Param       : Name of location as String
    ''' Post        : WeatherLocation with the specified location exists with monitor attached
    '''
    Public Overrides Function CreateMonitor(location As String) As Monitor
        Dim checkIndex As Integer = LocationExists(location)
        Dim monitor As Monitor
        'If location exists in the list, attach monitor
        If checkIndex >= 0 Then
            monitor = New TimeLapseBothMonitor(selectedLocations.Item(checkIndex))
            selectedLocations.Item(checkIndex).AttachMonitor(monitor)
        Else
            Dim weatherLocation As MelbourneWeatherLocation = New MelbourneWeatherLocation(location, server)
            monitor = New TimeLapseBothMonitor(weatherLocation)

            weatherLocation.AttachMonitor(monitor)
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
    Public Overrides Function CreateRainfallMonitor(location As String) As Monitor
        Dim checkIndex As Integer = LocationExists(location)
        Dim monitor As Monitor
        'If location exists in the list, attach monitor
        If checkIndex >= 0 Then
            monitor = New TimeLapseRainfallMonitor(selectedLocations.Item(checkIndex))
            selectedLocations.Item(checkIndex).AttachMonitor(monitor)

        Else
            Dim weatherLocation As MelbourneWeatherLocation = New MelbourneWeatherLocation(location, server)
            monitor = New TimeLapseRainfallMonitor(weatherLocation)

            weatherLocation.AttachMonitor(monitor)
            'Add a new location to the selected location list
            selectedLocations.Add(weatherLocation)

        End If
        Return monitor
    End Function

    ''' 
    ''' Description : Creates a monitor which feeds only temperature info
    ''' Return      : Monitor object
    ''' Param       : Name of location as String
    ''' Post        : WeatherLocation with the specified location exists with monitor attached
    '''
    Public Overrides Function CreateTemperatureMonitor(location As String) As Monitor
        Dim checkIndex As Integer = LocationExists(location)
        Dim monitor As Monitor

        'If location exists in the list, attach monitor
        If checkIndex >= 0 Then
            monitor = New TimeLapseTemperatureMonitor(selectedLocations.Item(checkIndex))
            selectedLocations.Item(checkIndex).AttachMonitor(monitor)
        Else
            Dim weatherLocation As MelbourneWeatherLocation = New MelbourneWeatherLocation(location, server)
            monitor = New TimeLapseTemperatureMonitor(weatherLocation)

            'Attach the monitor to the weather location
            weatherLocation.AttachMonitor(monitor)
            'Add a new location to the selected location list
            selectedLocations.Add(weatherLocation)
        End If

        Return monitor
    End Function
End Class
