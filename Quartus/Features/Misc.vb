Imports quartus.CSDK
Imports quartus.Offsets
Imports quartus.CUsefulFuncs
Imports System.Threading

Public Class CMisc

    Private pRadarPlayer As New CBasePlayer(Nothing)

    Public Sub Bhop()
        If GetAsyncKeyState(32) And pLocalPlayer.Velocity > 20 Then
            Dim fflags As Integer = pLocalPlayer.FFlags
            If fflags < 263 And fflags <> 257 Then
                CBasePlayer.ForceJump(4)
            Else
                CBasePlayer.ForceJump(5)
            End If
        End If
    End Sub

    Public Sub Radar()
        For i = 1 To MAXPLAYERS
            pRadarPlayer.ptr = CBasePlayer.PointerByIndex(i)
            If pRadarPlayer.Spotted = 0 And pRadarPlayer.Health > 0 And Not pRadarPlayer.Dormant Then mem.WrtInt(pRadarPlayer.ptr + m_bSpotted, 1)
        Next
    End Sub

    Public Sub Noflash(value As Integer)
        If pLocalPlayer.FlashMaxAlpha <> value Then
            mem.WrtFloat(pLocalPlayer.ptr + m_flFlashMaxAlpha, value)
        End If
    End Sub

    Private Declare Sub mouse_event Lib "user32" (ByVal dwFlags As Integer, ByVal dx As Integer, ByVal dy As Integer, ByVal cButtons As Integer, ByVal dwExtraInfo As Integer)

    Public Sub AutoPistol()
        If GetAsyncKeyState(KeyBinds.APKey) Then
            mouse_event(&H2, 0, 0, 0, 0)
            mouse_event(&H4, 0, 0, 0, 0)
            Sleep(15)
        End If
    End Sub
End Class


