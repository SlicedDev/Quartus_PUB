Imports quartus.Offsets
Imports quartus.CSDK
Public Class CEngine

    Public Function Clientstate() As Integer
        Return mem.RdInt(mem.EngineDLL + dwClientState)
    End Function

    Public Function Ingame() As Boolean
        Return mem.RdInt(Clientstate() + m_dwInGame) > 5
    End Function

    Public Function MaxPlayers() As Integer
        Return mem.RdInt(Clientstate() + &H308)
    End Function

    Public Sub SetAngles(ang As Vec3)
        Dim clienstate As Integer = Clientstate()
        mem.WrtFloat(clienstate + dwViewAngles, ang.x)
        mem.WrtFloat(clienstate + dwViewAngles + &H4, ang.y)
    End Sub

    Public Function ViewAngles() As Vec3
        Return mem.ReadMemory(Of Vec3)(Clientstate() + dwViewAngles)
    End Function

    Public Sub Fullupdate()
        mem.WrtInt(Clientstate() + &H174, -1)
    End Sub
End Class
