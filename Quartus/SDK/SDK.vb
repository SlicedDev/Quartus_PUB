Imports quartus.Offsets
Imports System.IO
Imports System.Text
Imports System.Net

Public Class CSDK

    Public Const MAXPLAYERS = 32
    Public Const GameCaption As String = "Counter-Strike: Global Offensive"

    Public Shared Caption As String = String.Empty
    Public Shared InGame As Boolean
    Public Shared TabX As Boolean

    Public Shared mem As New CMemoryManager
    Public Shared Engine As New CEngine
    Public Shared Settings As New CSettings
    Public Shared FindPattern As New CFindPattern
    Public Shared ofs As New CConfig(System.AppDomain.CurrentDomain.BaseDirectory & "offsets.ini")

    Public Shared Misc As New CMisc
    Public Shared Aimbot As New CAimbot
    Public Shared ESP As New CESP
    Public Shared Triggerbot As New CTriggerbot

    Public Shared pLocalPlayer As New CBasePlayer(Nothing)
    Private Shared reply As String
End Class
