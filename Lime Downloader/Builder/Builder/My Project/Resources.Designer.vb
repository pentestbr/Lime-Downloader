﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("Builder.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Friend ReadOnly Property dotNET_Reactor() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("dotNET_Reactor", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Friend ReadOnly Property PE() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("PE", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Imports System.IO
        '''Imports System
        '''Imports System.Reflection
        '''Imports System.Runtime.InteropServices
        '''Imports System.Security.Cryptography
        '''Imports System.Windows.Forms
        '''Imports System.Threading
        '''Imports Microsoft.VisualBasic
        '''
        '''&apos;%ASSEMBLY%&lt;Assembly: AssemblyTitle(&quot;%Title%&quot;)&gt; 
        '''&apos;%ASSEMBLY%&lt;Assembly: AssemblyDescription(&quot;%Description%&quot;)&gt; 
        '''&apos;%ASSEMBLY%&lt;Assembly: AssemblyCompany(&quot;%Company%&quot;)&gt; 
        '''&apos;%ASSEMBLY%&lt;Assembly: AssemblyProduct(&quot;%Product%&quot;)&gt; 
        '''&apos;%ASSEMBLY%&lt;Assembly: AssemblyCopyright(&quot;%Copyright%&quot;)&gt; 
        '''&apos;%ASS [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property Source() As String
            Get
                Return ResourceManager.GetString("Source", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
