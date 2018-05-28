Imports System.Drawing
Imports System.Windows.Forms
Imports quartus.CSDK
Imports quartus.ENUMS

Public Class ColorSelector

    Dim cmd As ClickedButtonEvent

    Public Sub New(command As ClickedButtonEvent)
        InitializeComponent()
        cmd = command
    End Sub

    Private Sub ColorSelector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        PictureBox1.BackColor = Color.FromArgb(AlpCol.Value, RedCol.Value, GreCol.Value, BluCol.Value)
        If (cmd = ClickedButtonEvent.Enemy) Then
            AlpCol.Value = My.Settings.ESPcolorEnemyA
            RedCol.Value = My.Settings.ESPcolorEnemyR
            GreCol.Value = My.Settings.ESPcolorEnemyG
            BluCol.Value = My.Settings.ESPcolorEnemyB
        ElseIf (cmd = ClickedButtonEvent.VisibleEnemy) Then
            AlpCol.Value = My.Settings.ESPcolorEnemyVisA
            RedCol.Value = My.Settings.ESPcolorEnemyVisR
            GreCol.Value = My.Settings.ESPcolorEnemyVisG
            BluCol.Value = My.Settings.ESPcolorEnemyVisB
        ElseIf (cmd = ClickedButtonEvent.Team) Then
            AlpCol.Value = My.Settings.ESPcolorTeammateA
            RedCol.Value = My.Settings.ESPcolorTeammateR
            GreCol.Value = My.Settings.ESPcolorTeammateG
            BluCol.Value = My.Settings.ESPcolorTeammateB
        ElseIf (cmd = ClickedButtonEvent.Weapon) Then
            AlpCol.Value = My.Settings.ESPcolorWeaponsA
            RedCol.Value = My.Settings.ESPcolorWeaponsR
            GreCol.Value = My.Settings.ESPcolorWeaponsG
            BluCol.Value = My.Settings.ESPcolorWeaponsB
        ElseIf (cmd = ClickedButtonEvent.Grenade) Then
            AlpCol.Value = My.Settings.ESPcolorGrenadesA
            RedCol.Value = My.Settings.ESPcolorGrenadesR
            GreCol.Value = My.Settings.ESPcolorGrenadesG
            BluCol.Value = My.Settings.ESPcolorGrenadesB
        ElseIf (cmd = ClickedButtonEvent.Bomb) Then
            AlpCol.Value = My.Settings.ESPcolorBombA
            RedCol.Value = My.Settings.ESPcolorBombR
            GreCol.Value = My.Settings.ESPcolorBombG
            BluCol.Value = My.Settings.ESPcolorBombB
        ElseIf (cmd = ClickedButtonEvent.Chicken) Then
            AlpCol.Value = My.Settings.ESPcolorChickenA
            RedCol.Value = My.Settings.ESPcolorChickenR
            GreCol.Value = My.Settings.ESPcolorChickenG
            BluCol.Value = My.Settings.ESPcolorChickenB
        End If
    End Sub

    Private Sub AlpCol_Scroll(sender As Object) Handles AlpCol.Scroll
        If (cmd = ClickedButtonEvent.Enemy) Then
            My.Settings.ESPcolorEnemyA = AlpCol.Value
        ElseIf (cmd = ClickedButtonEvent.VisibleEnemy) Then
            My.Settings.ESPcolorEnemyVisA = AlpCol.Value
        ElseIf (cmd = ClickedButtonEvent.Team) Then
            My.Settings.ESPcolorTeammateA = AlpCol.Value
        ElseIf (cmd = ClickedButtonEvent.Weapon) Then
            My.Settings.ESPcolorWeaponsA = AlpCol.Value
        ElseIf (cmd = ClickedButtonEvent.Grenade) Then
            My.Settings.ESPcolorGrenadesA = AlpCol.Value
        ElseIf (cmd = ClickedButtonEvent.Bomb) Then
            My.Settings.ESPcolorBombA = AlpCol.Value
        ElseIf (cmd = ClickedButtonEvent.Chicken) Then
            My.Settings.ESPcolorChickenA = AlpCol.Value
        End If
        PictureBox1.BackColor = Color.FromArgb(AlpCol.Value, RedCol.Value, GreCol.Value, BluCol.Value)
        Refresh()
        My.Settings.Save()
        Settings.Load()
    End Sub

    Private Sub RedCol_Scroll(sender As Object) Handles RedCol.Scroll
        If (cmd = ClickedButtonEvent.Enemy) Then
            My.Settings.ESPcolorEnemyR = RedCol.Value
        ElseIf (cmd = ClickedButtonEvent.VisibleEnemy) Then
            My.Settings.ESPcolorEnemyVisR = RedCol.Value
        ElseIf (cmd = ClickedButtonEvent.Team) Then
            My.Settings.ESPcolorTeammateR = RedCol.Value
        ElseIf (cmd = ClickedButtonEvent.Weapon) Then
            My.Settings.ESPcolorWeaponsR = RedCol.Value
        ElseIf (cmd = ClickedButtonEvent.Grenade) Then
            My.Settings.ESPcolorGrenadesR = RedCol.Value
        ElseIf (cmd = ClickedButtonEvent.Bomb) Then
            My.Settings.ESPcolorBombR = RedCol.Value
        ElseIf (cmd = ClickedButtonEvent.Chicken) Then
            My.Settings.ESPcolorChickenR = RedCol.Value
        End If
        PictureBox1.BackColor = Color.FromArgb(AlpCol.Value, RedCol.Value, GreCol.Value, BluCol.Value)
        Refresh()
        My.Settings.Save()
        Settings.Load()
    End Sub

    Private Sub GreCol_Scroll(sender As Object) Handles GreCol.Scroll
        If (cmd = ClickedButtonEvent.Enemy) Then
            My.Settings.ESPcolorEnemyG = GreCol.Value
        ElseIf (cmd = ClickedButtonEvent.VisibleEnemy) Then
            My.Settings.ESPcolorEnemyVisG = GreCol.Value
        ElseIf (cmd = ClickedButtonEvent.Team) Then
            My.Settings.ESPcolorTeammateG = GreCol.Value
        ElseIf (cmd = ClickedButtonEvent.Weapon) Then
            My.Settings.ESPcolorWeaponsG = GreCol.Value
        ElseIf (cmd = ClickedButtonEvent.Grenade) Then
            My.Settings.ESPcolorGrenadesG = GreCol.Value
        ElseIf (cmd = ClickedButtonEvent.Bomb) Then
            My.Settings.ESPcolorBombG = GreCol.Value
        ElseIf (cmd = ClickedButtonEvent.Chicken) Then
            My.Settings.ESPcolorChickenG = GreCol.Value
        End If
        PictureBox1.BackColor = Color.FromArgb(AlpCol.Value, RedCol.Value, GreCol.Value, BluCol.Value)
        Refresh()
        My.Settings.Save()
        Settings.Load()
    End Sub

    Private Sub BluCol_Scroll(sender As Object) Handles BluCol.Scroll
        If (cmd = ClickedButtonEvent.Enemy) Then
            My.Settings.ESPcolorEnemyB = BluCol.Value
        ElseIf (cmd = ClickedButtonEvent.VisibleEnemy) Then
            My.Settings.ESPcolorEnemyVisB = BluCol.Value
        ElseIf (cmd = ClickedButtonEvent.Team) Then
            My.Settings.ESPcolorTeammateB = BluCol.Value
        ElseIf (cmd = ClickedButtonEvent.Weapon) Then
            My.Settings.ESPcolorWeaponsB = BluCol.Value
        ElseIf (cmd = ClickedButtonEvent.Grenade) Then
            My.Settings.ESPcolorGrenadesB = BluCol.Value
        ElseIf (cmd = ClickedButtonEvent.Bomb) Then
            My.Settings.ESPcolorBombB = BluCol.Value
        ElseIf (cmd = ClickedButtonEvent.Chicken) Then
            My.Settings.ESPcolorChickenB = BluCol.Value
        End If
        PictureBox1.BackColor = Color.FromArgb(AlpCol.Value, RedCol.Value, GreCol.Value, BluCol.Value)
        Refresh()
        My.Settings.Save()
        Settings.Load()
    End Sub

    Private Sub FlatButton3_Click(sender As Object, e As EventArgs) Handles FlatButton3.Click
        Me.Close()
    End Sub
End Class