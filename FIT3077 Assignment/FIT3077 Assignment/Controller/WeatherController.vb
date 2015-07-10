'''
''' Project     : FIT3077 Assignment
''' Class       : WeatherController
''' Author      : Arvin Wiyono (awiy1)
''' Modified    : 20 May 2015
''' Description : An abstract class which performs the logic of the system and organizes how system requests are handled
''' Precondition: WeatherAdapter and WeatherLocation classes are required
'''

Public MustInherit Class WeatherController
    'The Adapter which is used for inializing WeatherLocations
    Protected server As WeatherAdapter

    'A list of selected locations
    Protected selectedLocations As List(Of WeatherLocation)

    ''' 
    ''' Superclass constructor
    ''' Return      : WeatherController object
    ''' Param       : None
    ''' 
    Sub New()
        selectedLocations = New List(Of WeatherLocation)
    End Sub

    ''' 
    ''' Update interval accessor
    ''' Return      : The time interval for update in milliseconds as Integer
    ''' Param       : None
    ''' 
    Public Function GetUpdateInterval() As Integer
        Return server.GetUpdateInterval()
    End Function

    ''' 
    ''' Return      : The available locations provided by the Adapter as an array of Strings
    ''' Param       : None
    '''
    Public Function GetAvailableLocations() As String()
        Return server.GetLocations()
    End Function

    ''' 
    ''' Description : Check whether a WeatherLocation with the given location name is active, i.e. exists in the selectedLocations list
    ''' Return      : The index of the location in the list if WeatherLocation with specified location exists. Else, return -1
    ''' Param       : Name of location as String
    '''
    Public Function LocationExists(ByVal l As String) As Integer
        Dim index As Integer
        For index = 0 To selectedLocations.Count - 1
            If (String.Compare(selectedLocations.Item(index).GetLocation(), l) = 0) Then
                Return index
            End If
        Next
        Return -1
    End Function

    ''' 
    ''' Description : Get the number of active WeatherLocations
    ''' Return      : The number of active WeatherLocations as Integer
    ''' Param       : None
    '''
    Public Function GetNumberOfLocations() As Integer
        Return selectedLocations.Count
    End Function

    ''' 
    ''' Description : Get all location names of currently active WeatherLocations. This function is utilized in removal functionality
    ''' Return      : The location names of currently active WeatherLocations as array of Strings
    ''' Param       : None
    '''
    Public Function GetAllSelectedLocations() As String()
        Dim returnList As List(Of String) = New List(Of String)

        For index As Integer = 0 To GetNumberOfLocations() - 1
            returnList.Add(selectedLocations.Item(index).GetLocation())
        Next
        Return returnList.ToArray()
    End Function

    ''' 
    ''' Description : Ask a particular WeatherLocation to get an update from the server and asks its monitors to pull data
    ''' Return      : None
    ''' Param       : index as Integer, which is the index of the location to be updated in the selectedLocations list
    '''
    Public Sub UpdateLocation(ByVal index As Integer)
        selectedLocations.Item(index).UpdateDataAndMonitor()
    End Sub

    ''' 
    ''' Description : Remove a WeatherLocation with the specified location name from the selectedLocations list
    ''' Return      : None
    ''' Param       : Name of location as String
    ''' Post        : WeatherLocation with the specified location together with its associated monitors are removed from the list and the system
    '''
    Public Sub RemoveLocation(ByVal l As String)
        For Each wl As WeatherLocation In selectedLocations
            If (String.Compare(wl.GetLocation, l) = 0) Then
                'Remove weather location from the selectedLocations
                selectedLocations.Remove(wl)
                Exit For
            End If
        Next
    End Sub

    'Abstract functions which must be overriden by the subclasses
    Public MustOverride Function CreateMonitor(ByVal location As String) As Monitor
    Public MustOverride Function CreateTemperatureMonitor(ByVal location As String) As Monitor
    Public MustOverride Function CreateRainfallMonitor(ByVal location As String) As Monitor
End Class
