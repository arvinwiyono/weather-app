'''
''' Project     : FIT3077 Assignment
''' Class       : Monitor
''' Author      : Arvin Wiyono (awiy1) and Darren Wong (dwwon6)
''' Modified    : 20 May 2015
''' Description : An abstract class which plays the role of Observer and contains common attributes and methods of subclasses
''' Precondition: WeatherLocation class and InfoType enumeration are required
''' 

Public MustInherit Class Monitor
    'Common attributes that a monitor must posses
    Protected weatherLocation As MelbourneWeatherLocation
    Protected location As String
    Protected infoType As InfoType

    'This boolean attribute indicates whether the Monitor is currently keeping an up-to-date data
    Private newData As Boolean

    ''' 
    ''' Class constructor
    ''' Return      : Monitor object
    ''' Param       : None
    ''' 
    Sub New()
        'When a monitor is initialized, it must have a new set of data
        newData = True
    End Sub

    'Abstract methods which must be overriden by the subclasses
    MustOverride Sub GetInfo()
    MustOverride Function FeedData() As String()

    ''' 
    ''' Location attribute accessor
    ''' Return      : Currently observed location as String
    ''' Param       : None
    ''' 
    Public Function GetLocation() As String
        Return location
    End Function

    ''' 
    ''' Monitor type attribute accessor
    ''' Description : The type attribute is utilized for the interface to decide how data is displayed
    ''' Return      : InfoType enumeration member
    ''' Param       : None 
    ''' 
    Public Function GetMonitorType() As InfoType
        Return infoType
    End Function

    ''' 
    ''' Update status
    ''' Description : Gets new data from the observed WeatherLocation
    ''' Return      : None
    ''' Param       : None 
    '''
    Public Sub UpdateStatus()
        newData = True
        GetInfo()
    End Sub

    ''' Description : Gets new data from the observed WeatherLocation
    ''' Return      : True, if Monitor has new data which has not been 'pulled', False otherwise
    ''' Param       : None 
    '''
    Public Function HasNewData() As Boolean
        Return newData
    End Function

    ''' Description : Once data has been pulled, set the newData attribute to False
    ''' Return      : None
    ''' Param       : None 
    '''
    Protected Sub DoneFeedData()
        newData = False
    End Sub
End Class
