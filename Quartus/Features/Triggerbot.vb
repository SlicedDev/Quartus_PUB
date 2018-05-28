Imports quartus.CSDK
Imports quartus.Offsets
Imports quartus.CUsefulFuncs
Public Class CTriggerbot

    Private pTriggerPlayer As New CBasePlayer(Nothing)

    Public Sub Triggerbot(Mode As Integer, Rage As Integer)
        If GetAsyncKeyState(KeyBinds.TriggerKey) Then
            If Mode = 1 Then
                Aimbot.GetNextEnemyToCrosshair(8, pTriggerPlayer.ptr)
                If pTriggerPlayer.Health > 0 And Not pTriggerPlayer.Dormant Then

                    Dim bBone As Vec3 = pTriggerPlayer.BonePosition(8) + New Vec3(0, 0, 3)
                    Dim BottomHitboxHead As Vec3 = New Vec3(bBone.x - 2.54F, bBone.y - 4.145F, bBone.z - 7.0F)
                    Dim TopHitboxHead As Vec3 = New Vec3(bBone.x + 2.54F, bBone.y + 4.145F, bBone.z + 3.0F)

                    Dim viewDirection As Vec3 = Cray.AngleToDirection(Engine.ViewAngles())
                    Dim viewRay As New Cray(pLocalPlayer.OriginVec + pLocalPlayer.ViewOffset, viewDirection)
                    Dim distance As Single
                    Dim IncrossIndex As Integer = pLocalPlayer.IncrossIndex

                    If Rage = 0 Then
                        If IncrossIndex > 0 And IncrossIndex < 65 Then
                            pTriggerPlayer.ptr = CBasePlayer.PointerByIndex(IncrossIndex)
                            If viewRay.Trace(BottomHitboxHead, TopHitboxHead, distance) Then
                                Dim WeaponId As Integer = pLocalPlayer.ActiveWeapon.ID
                                If WeaponId <> ENUMS.ItemDefinitionIndex.TASER Then
                                    Sleep(My.Settings.DelayTime)
                                    CBasePlayer.ForceAttack(0, 12, 10)
                                    Sleep(My.Settings.DelayAfterShotTime)
                                ElseIf WeaponId = ENUMS.ItemDefinitionIndex.TASER And GetDistance(pLocalPlayer.OriginVec, pTriggerPlayer.OriginVec) <= 128 Then
                                    Sleep(My.Settings.DelayTime)
                                    CBasePlayer.ForceAttack(0, 12, 10)
                                    Sleep(My.Settings.DelayAfterShotTime)
                                End If
                            End If
                        End If

                    ElseIf Rage = 1 Then
                        If viewRay.Trace(BottomHitboxHead, TopHitboxHead, distance) Then
                            Dim WeaponId As Integer = pLocalPlayer.ActiveWeapon.ID
                            If WeaponId <> ENUMS.ItemDefinitionIndex.TASER Then
                                Sleep(My.Settings.DelayTime)
                                CBasePlayer.ForceAttack(0, 12, 10)
                                Sleep(My.Settings.DelayAfterShotTime)
                            ElseIf WeaponId = ENUMS.ItemDefinitionIndex.TASER And GetDistance(pLocalPlayer.OriginVec, pTriggerPlayer.OriginVec) <= 128 Then
                                Sleep(My.Settings.DelayTime)
                                CBasePlayer.ForceAttack(0, 12, 10)
                                Sleep(My.Settings.DelayAfterShotTime)
                            End If
                        End If
                    End If
                End If

            ElseIf Mode = 2 Then
                Dim IncrossIndex As Integer = pLocalPlayer.IncrossIndex
                If IncrossIndex > 0 And IncrossIndex < 65 Then
                    pTriggerPlayer.ptr = CBasePlayer.PointerByIndex(IncrossIndex)
                    If Not pTriggerPlayer.Team = pLocalPlayer.Team Then
                        Dim WeaponId As Integer = pLocalPlayer.ActiveWeapon.ID
                        If WeaponId <> ENUMS.ItemDefinitionIndex.TASER Then
                            Sleep(My.Settings.DelayTime)
                            CBasePlayer.ForceAttack(0, 12, 10)
                            Sleep(My.Settings.DelayAfterShotTime)
                        ElseIf WeaponId = ENUMS.ItemDefinitionIndex.TASER And GetDistance(pLocalPlayer.OriginVec, pTriggerPlayer.OriginVec) <= 128 Then
                            Sleep(Settings.DelayAfterShotTime)
                            CBasePlayer.ForceAttack(0, 12, 10)
                            Sleep(My.Settings.DelayAfterShotTime)
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Function GetDistance(v1 As Vec3, v2 As Vec3) As Single
        Return Math.Sqrt((v1.x - v2.x) * (v1.x - v2.x) + (v1.y - v2.y) * (v1.y - v2.y) + (v1.z - v2.z) * (v1.z - v2.z))
    End Function

End Class
