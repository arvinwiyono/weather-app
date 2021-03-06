﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.18444
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Xml.Serialization

'
'This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.18444.
'
Namespace MonashTimeLapse
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="MelbourneWeatherTimeLapseSoap11Binding", [Namespace]:="http://MelbourneWeather2")>  _
    Partial Public Class MelbourneWeatherTimeLapse
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        Private getLocationsOperationCompleted As System.Threading.SendOrPostCallback
        
        Private getWeatherOperationCompleted As System.Threading.SendOrPostCallback
        
        Private useDefaultCredentialsSetExplicitly As Boolean
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = Global.FIT3077_Assignment.My.MySettings.Default.FIT3077_Assignment_MonashTimeLapse_MelbourneWeatherTimeLapse
            If (Me.IsLocalFileSystemWebService(Me.Url) = true) Then
                Me.UseDefaultCredentials = true
                Me.useDefaultCredentialsSetExplicitly = false
            Else
                Me.useDefaultCredentialsSetExplicitly = true
            End If
        End Sub
        
        Public Shadows Property Url() As String
            Get
                Return MyBase.Url
            End Get
            Set
                If (((Me.IsLocalFileSystemWebService(MyBase.Url) = true)  _
                            AndAlso (Me.useDefaultCredentialsSetExplicitly = false))  _
                            AndAlso (Me.IsLocalFileSystemWebService(value) = false)) Then
                    MyBase.UseDefaultCredentials = false
                End If
                MyBase.Url = value
            End Set
        End Property
        
        Public Shadows Property UseDefaultCredentials() As Boolean
            Get
                Return MyBase.UseDefaultCredentials
            End Get
            Set
                MyBase.UseDefaultCredentials = value
                Me.useDefaultCredentialsSetExplicitly = true
            End Set
        End Property
        
        '''<remarks/>
        Public Event getLocationsCompleted As getLocationsCompletedEventHandler
        
        '''<remarks/>
        Public Event getWeatherCompleted As getWeatherCompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:getLocations", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Bare)>  _
        Public Function getLocations() As <System.Xml.Serialization.XmlArrayAttribute("getLocationsResponse", [Namespace]:="http://MelbourneWeather2"), System.Xml.Serialization.XmlArrayItemAttribute("return")> String()
            Dim results() As Object = Me.Invoke("getLocations", New Object(-1) {})
            Return CType(results(0),String())
        End Function
        
        '''<remarks/>
        Public Overloads Sub getLocationsAsync()
            Me.getLocationsAsync(Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub getLocationsAsync(ByVal userState As Object)
            If (Me.getLocationsOperationCompleted Is Nothing) Then
                Me.getLocationsOperationCompleted = AddressOf Me.OngetLocationsOperationCompleted
            End If
            Me.InvokeAsync("getLocations", New Object(-1) {}, Me.getLocationsOperationCompleted, userState)
        End Sub
        
        Private Sub OngetLocationsOperationCompleted(ByVal arg As Object)
            If (Not (Me.getLocationsCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent getLocationsCompleted(Me, New getLocationsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("urn:getWeather", RequestNamespace:="http://MelbourneWeather2", ResponseNamespace:="http://MelbourneWeather2", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function getWeather(<System.Xml.Serialization.XmlElementAttribute(IsNullable:=true)> ByVal location As String) As <System.Xml.Serialization.XmlElementAttribute("return", IsNullable:=true)> String()
            Dim results() As Object = Me.Invoke("getWeather", New Object() {location})
            Return CType(results(0),String())
        End Function
        
        '''<remarks/>
        Public Overloads Sub getWeatherAsync(ByVal location As String)
            Me.getWeatherAsync(location, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub getWeatherAsync(ByVal location As String, ByVal userState As Object)
            If (Me.getWeatherOperationCompleted Is Nothing) Then
                Me.getWeatherOperationCompleted = AddressOf Me.OngetWeatherOperationCompleted
            End If
            Me.InvokeAsync("getWeather", New Object() {location}, Me.getWeatherOperationCompleted, userState)
        End Sub
        
        Private Sub OngetWeatherOperationCompleted(ByVal arg As Object)
            If (Not (Me.getWeatherCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent getWeatherCompleted(Me, New getWeatherCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        Public Shadows Sub CancelAsync(ByVal userState As Object)
            MyBase.CancelAsync(userState)
        End Sub
        
        Private Function IsLocalFileSystemWebService(ByVal url As String) As Boolean
            If ((url Is Nothing)  _
                        OrElse (url Is String.Empty)) Then
                Return false
            End If
            Dim wsUri As System.Uri = New System.Uri(url)
            If ((wsUri.Port >= 1024)  _
                        AndAlso (String.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) = 0)) Then
                Return true
            End If
            Return false
        End Function
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")>  _
    Public Delegate Sub getLocationsCompletedEventHandler(ByVal sender As Object, ByVal e As getLocationsCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class getLocationsCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String()
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String())
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408")>  _
    Public Delegate Sub getWeatherCompletedEventHandler(ByVal sender As Object, ByVal e As getWeatherCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.18408"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class getWeatherCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String()
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String())
            End Get
        End Property
    End Class
End Namespace
