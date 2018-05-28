Imports System.Drawing
Imports quartus.CConfig
Imports quartus.CSDK
Public Class CSettings

    '<<< AIMBOT >>>'
    Public Aimbot As Boolean = True
    Public AimMode As Integer = 1
    Public RageAim As Integer = 0
    Public RangeBased As Boolean = False
    Public FovRifles As Integer = 30
    Public SmoothRifles As Integer = 150
    Public AimSpotRifles As Integer = 6
    Public FovPistols As Integer = 30
    Public SmoothPistols As Integer = 150
    Public AimSpotPistols As Integer = 6
    Public FovSnipers As Integer = 30
    Public SmoothSnipers As Integer = 150
    Public AimSpotSnipers As Integer = 6
    Public SleepTime As Integer = 100

    '<<< ESP >>>'
    Public ESP As Boolean = True
    Public Toggable As Boolean = False
    Public ESPmode As Integer = 1

    '<<< TRIGGER >>>'
    Public Trigger As Boolean = True
    Public TriggerMode As Integer = 1
    Public RageMode As Integer = 0
    Public DelayTime As Integer = 20
    Public DelayAfterShotTime As Integer = 20

    '<<< MISC >>>'
    Public Bhop As Boolean = True
    Public Radar As Boolean = True
    Public Noflash As Boolean = True
    Public NoflashMaxAlpha As Integer = 20
    Public Autopistol As Boolean = True

    Public Function Load()
        Try

            '<<< AIMBOT >>>'
            Aimbot = My.Settings.Aimbot
            AimMode = My.Settings.AimMode
            RageAim = My.Settings.RageAim
            RangeBased = My.Settings.RangeBased
            FovRifles = My.Settings.FovRifles
            SmoothRifles = My.Settings.SmoothRifles
            AimSpotRifles = My.Settings.AimSpotRifles
            FovPistols = My.Settings.FovPistols
            SmoothPistols = My.Settings.SmoothPistols
            AimSpotPistols = My.Settings.AimSpotPistols
            FovSnipers = My.Settings.FovSnipers
            SmoothSnipers = My.Settings.SmoothSnipers
            AimSpotSnipers = My.Settings.AimSpotSnipers
            SleepTime = My.Settings.SleepTime

            '<<< ESP >>>'
            ESP = My.Settings.ESP
            Toggable = My.Settings.Toggable
            ESPmode = My.Settings.ESPmode

            '<<< TRIGGER >>>'
            Trigger = My.Settings.Trigger
            TriggerMode = My.Settings.TriggerMode
            RageMode = My.Settings.RageMode
            DelayTime = My.Settings.DelayTime
            DelayAfterShotTime = My.Settings.DelayAfterShotTime

            '<<< MISC >>>'
            Bhop = My.Settings.Bhop
            Radar = My.Settings.Radar
            Noflash = My.Settings.Noflash
            NoflashMaxAlpha = My.Settings.NoflashMaxAlpha
            Autopistol = My.Settings.Autopistol

            '<<< KEYS >>>'
            KeyBinds.TriggerKey = My.Settings.TriggerKey
            KeyBinds.ESPKey = My.Settings.ESPKey
            KeyBinds.AimKey = My.Settings.AimKey
            KeyBinds.APKey = My.Settings.APKey

        Catch ex As Exception
            CUsefulFuncs.Wl(ex.ToString)
        End Try
#Disable Warning BC42105 ' Die Funktion gibt nicht für alle Codepfade einen Wert zurück.
    End Function
#Enable Warning BC42105 ' Die Funktion gibt nicht für alle Codepfade einen Wert zurück.
End Class
