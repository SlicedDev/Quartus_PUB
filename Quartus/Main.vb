Imports quartus.CUsefulFuncs
Imports quartus.CSDK
Imports quartus.KeyBinds
Imports System.Management
Imports System.IO
Imports System.Windows.Forms

Public Class Main
    Public Function Prepare()
        Try
            My.Computer.FileSystem.DeleteFile(System.AppDomain.CurrentDomain.BaseDirectory & "offsets.ini")
        Catch ex As Exception
        End Try
        My.Computer.Network.DownloadFile("https://raw.githubusercontent.com/frk1/hazedumper/master/csgo.toml", System.AppDomain.CurrentDomain.BaseDirectory & "offsets.ini")
    End Function

    Public Misc_thread As Threading.Thread = New Threading.Thread(AddressOf Loop_Misc)
    Public Aimbot_thread As Threading.Thread = New Threading.Thread(AddressOf Loop_Aimbot)
    Public ESP_thread As Threading.Thread = New Threading.Thread(AddressOf Loop_Esp)

    Public Sub Loop_Misc()
        While True
            InGame = Engine.Ingame
            Caption = GetCaption()
            RestartIfCsgoNotValid()

            If GetAsyncKeyState(Keys.F5) Then
                Settings.Load()
                Console.Beep()
                Sleep(300)
            End If

            If InGame And Caption = GameCaption Then
                If Settings.Bhop Then Misc.Bhop()
                If Settings.Radar Then Misc.Radar()
                If Settings.Noflash Then Misc.Noflash(Settings.NoflashMaxAlpha)
                If Settings.Autopistol Then Misc.AutoPistol()
            End If

            Sleep(1)
        End While
    End Sub

    Public Sub Loop_Aimbot()
        While True

            If InGame And Caption = GameCaption Then
                If Settings.Aimbot Then Aimbot.Aimbot(Settings.AimMode, Settings.RageAim, Settings.FovRifles, Settings.AimSpotRifles, Settings.SmoothRifles, Settings.FovPistols, Settings.AimSpotPistols, Settings.SmoothPistols, Settings.FovSnipers, Settings.AimSpotSnipers, Settings.SmoothSnipers)

                If Settings.Trigger Then Triggerbot.Triggerbot(Settings.TriggerMode, Settings.RageMode)
            End If

            Sleep(1)
        End While
    End Sub

    Public Sub Loop_Esp()
        While True

            If InGame Then
                pLocalPlayer.ptr = CBasePlayer.LocalPlayer()
                If Settings.ESP Then ESP.GlowESP(Settings.ESP, Settings.Toggable, Settings.ESPmode)
            End If

            Sleep(1)
        End While
    End Sub

    Public Declare Function RegisterHotKey Lib "user32" (ByVal hwnd As IntPtr, ByVal id As Integer, ByVal fsModifiers As Integer, ByVal vk As Integer) As Integer
    Public Declare Function UnregisterHotKey Lib "user32" (ByVal hwnd As IntPtr, ByVal id As Integer) As Integer
    Public Const WM_HOTKEY As Integer = &H312

    Protected Overrides Sub WndProc(ByRef m As Message)
        If m.Msg = WM_HOTKEY Then
            GUI.Show()
        End If

        MyBase.WndProc(m)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Prepare()
        CheckIfAppIsAllreadyRunning()

        If Not ofs.Exists Then
            Sleep(3000)
            Environment.Exit(0)
        End If

        Settings.Load()
        Do Until mem.Setup("csgo")
            Sleep(1000)
        Loop

        Misc_thread.Start()
        Aimbot_thread.Start()
        ESP_thread.Start()

        Aimbot_thread.Priority = Threading.ThreadPriority.Highest

        Call RegisterHotKey(Me.Handle.ToInt32, 0, &H1, 38)
        Console.Beep()

    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        GUI.Show()
    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click
        SendKeys.Send("{F5}")
    End Sub

    Private Sub FlatClose1_Click(sender As Object, e As EventArgs) Handles FlatClose1.Click
        Call UnregisterHotKey(Me.Handle, 9)
        Environment.Exit(0)
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
        Call UnregisterHotKey(Me.Handle, 9)
        Environment.Exit(0)
    End Sub
End Class