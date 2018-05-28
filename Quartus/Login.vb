Imports System.Management
Imports System.Security.Cryptography
Imports System.Data.SqlClient
Imports System.Drawing

Public Class Login

    Dim p() As Process

    Private Sub CheckIfRunning()
        p = Process.GetProcessesByName("csgo")
        If p.Count > 0 Then
            FlatLabel1.Hide()
            FlatButton1.Enabled = True
        Else
            FlatLabel1.Show()
            FlatButton1.Enabled = False
            FlatButton1.BaseColor = Color.Gray
        End If
    End Sub

    Public Class ClsComputerInfo

        Friend Function GetProcessorId() As String
            Dim strProcessorId As String = String.Empty
            Dim query As New SelectQuery("Win32_processor")
            Dim search As New ManagementObjectSearcher(query)
            Dim info As ManagementObject

            For Each info In search.Get()
                strProcessorId = info("processorId").ToString()
            Next
            Return strProcessorId

        End Function

        Friend Function GetMACAddress() As String

            Dim mc As ManagementClass = New ManagementClass("Win32_NetworkAdapterConfiguration")
            Dim moc As ManagementObjectCollection = mc.GetInstances()
            Dim MACAddress As String = String.Empty
            For Each mo As ManagementObject In moc

                If (MACAddress.Equals(String.Empty)) Then
                    If CBool(mo("IPEnabled")) Then MACAddress = mo("MacAddress").ToString()

                    mo.Dispose()
                End If
                MACAddress = MACAddress.Replace(":", String.Empty)

            Next
            Return MACAddress
        End Function

        Friend Function GetVolumeSerial(Optional ByVal strDriveLetter As String = "C") As String

            Dim disk As ManagementObject = New ManagementObject(String.Format("win32_logicaldisk.deviceid=""{0}:""", strDriveLetter))
            disk.Get()
            Return disk("VolumeSerialNumber").ToString()
        End Function

        Friend Function GetMotherBoardID() As String

            Dim strMotherBoardID As String = String.Empty
            Dim query As New SelectQuery("Win32_BaseBoard")
            Dim search As New ManagementObjectSearcher(query)
            Dim info As ManagementObject
            For Each info In search.Get()

                strMotherBoardID = info("product").ToString()

            Next
            Return strMotherBoardID

        End Function

        Friend Function GetGPUID() As String
            Dim strGPU As String = String.Empty
            Dim query As New SelectQuery("Win32_VideoController")
            Dim search As New ManagementObjectSearcher(query)
            Dim info As ManagementObject
            For Each info In search.Get()
                strGPU = info("DeviceId").ToString()
            Next
            Return strGPU
        End Function

    End Class

    Private Function GetMD5Hash(ByVal strToHash As String) As String
        Dim md5Obj As New MD5CryptoServiceProvider
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)

        bytesToHash = md5Obj.ComputeHash(bytesToHash)

        Dim strResult As String = ""

        For Each b As Byte In bytesToHash
            strResult += b.ToString("x2")
        Next

        Return strResult
    End Function

    Private Function AESD(ByVal ciphertext As String, ByVal key As String) As String
        Dim AES As New RijndaelManaged
        Dim SHA256 As New SHA256Cng
        Dim plaintext As String = ""
        Dim iv As String = ""
        Try
            Dim ivct = ciphertext.Split({"=="}, StringSplitOptions.None)
            iv = ivct(0) & "=="
            ciphertext = If(ivct.Length = 3, ivct(1) & "==", ivct(1))

            AES.Key = SHA256.ComputeHash(System.Text.Encoding.ASCII.GetBytes(key))
            AES.IV = Convert.FromBase64String(iv)
            AES.Mode = CipherMode.CBC
            Dim DESDecrypter As ICryptoTransform = AES.CreateDecryptor
            Dim Buffer As Byte() = Convert.FromBase64String(ciphertext)
            plaintext = System.Text.Encoding.ASCII.GetString(DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return plaintext
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckIfRunning()
        UsernameBox.Text = My.Settings.UNAME
        PasswordBox.Text = My.Settings.PASSWD
        Refresh()
    End Sub

    Dim ConnectorString As String
    Dim HashedPass As String

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click

        Dim hw As New ClsComputerInfo
        Dim hdd As String
        Dim cpu As String
        Dim mb As String
        Dim mac As String
        Dim hwid As String
        Dim gpu As String
        Dim hashedHWID As String
        cpu = hw.GetProcessorId()
        hdd = hw.GetVolumeSerial("C")
        mb = hw.GetMotherBoardID()
        mac = hw.GetMACAddress()
        gpu = hw.GetGPUID()
        hwid = cpu + hdd + mb + mac + gpu
        Dim hwidEncrypted As String = UCase(GetMD5Hash(cpu & hdd & mb & mac & gpu))
        hashedHWID = hwidEncrypted

        HashedPass = GetMD5Hash(PasswordBox.Text)

        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim myConnectionString As String
        Dim Password As String
        Dim userName As String
        Dim SQLHWID As String

        Try
            myConnectionString = "Server=tcp :somemssqlserver.database.windows.net, 1433;" _
            & "Initial Catalog=database_name;" _
            & "Persist Security Info=False;" _
            & "User ID=database_user;" _
            & "Password=" & AESD("ENCRYPTEDTEXT", "YOURKEY") & ";" _
            & "MultipleActiveResultSets = False;" _
            & "Encrypt=True;" _
            & "TrustServerCertificate=False;" _
            & "Connection Timeout=30;"

            con.ConnectionString = myConnectionString
            con.Open()

            cmd.Connection = con
            cmd.CommandText = "Select username,
                                        passwd,
                                          hwid
                               FROM   logins
                               WHERE  (username = '" & UsernameBox.Text & "')
                               AND            (passwd = '" & HashedPass & "')
                               AND              (hwid = '" & hashedHWID & "')"

            Dim lrd As SqlDataReader = cmd.ExecuteReader()
            If lrd.HasRows Then
                While lrd.Read()
                    Password = lrd("passwd").ToString()
                    userName = lrd("username").ToString()
                    SQLHWID = lrd("hwid").ToString()
                    If Password = HashedPass And userName = UsernameBox.Text And SQLHWID = hashedHWID Then
                        My.Settings.UNAME = UsernameBox.Text
                        My.Settings.PASSWD = PasswordBox.Text
                        My.Settings.Save()
                        Main.Show()
                        Me.Hide()
                    End If
                End While
            Else
                MsgBox("FAIL.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Form3_FormClosing(ByVal sender As Object, ByVal e As Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Environment.Exit(0)
    End Sub
End Class