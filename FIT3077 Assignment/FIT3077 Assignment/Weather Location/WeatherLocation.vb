'''
''' Project     : FIT3077 Assignment
''' Class       : WeatherLocation
''' Author      : Arvin Wiyono (awiy1) and Darren Wong (dwwon6)
''' Modified    : 19 May 2015
''' Description : An abstract class which plays the role of Subject and contains common attributes and methods of subclasses
''' Precondition: WeatherAdapter and Monitor classes are required
''' 

Public MustInherit Class WeatherLocation

    'Superclass attributes
    Protected server As WeatherAdapter

    'WeatherLocation has a list of monitors
    Protected monitorList As List(Of Monitor)

    'Every weather location has at least location attribute
    Protected location As String

    ''' 
    ''' Class constructor
    ''' Return      : MelbourneWeatherLocation object
    ''' Param       : Location name As String - WeatherAdapter, from which the data will be requested
    ''' 
    Public Sub New(ByVal l As String, ByVal s As WeatherAdapter)
        location = l
        server = s
        monitorList = New List(Of Monitor)
    End Sub

    'Location accessor
    Public Function GetLocation() As String
        Return location
    End Function

    ''' 
    ''' Description : Add a monitor to the list of monitors
    ''' Return      : None
    ''' Param       : Monitor, the Monitor object to be attached
    '''
    Public Sub AttachMonitor(ByVal m As Monitor)
        monitorList.Add(m)
    End Sub

    ''' 
    ''' Description : Remove a monitor from the list of monitors
    ''' Return      : None
    ''' Param       : Monitor, the Monitor object to be detached
    '''
    Public Sub DetachMonitor(ByVal m As Monitor)
        monitorList.Remove(m)
    End Sub

    ''' 
    ''' Description : This function will update each monitor as necessary - CheckData() is used to compare the old and the new data
    ''' Return      : None
    ''' Param       : None
    ''' Post        : Observing monitors are updated 
    Public Sub UpdateDataAndMonitor()
        If CheckData() Then
            For Each m As Monitor In monitorList
                m.UpdateStatus()
            Next
        End If
    End Sub

    'Abstract methods which must be derived by the subclass
    Public MustOverride Function CheckData() As Boolean
    Public MustOverride Sub GetData()
End Class
