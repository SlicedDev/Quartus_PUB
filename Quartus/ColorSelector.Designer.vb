<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ColorSelector
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ColorSelector))
        Me.FormSkin1 = New quartus.FormSkin()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.AlpCol = New quartus.FlatTrackBar()
        Me.FlatLabel4 = New quartus.FlatLabel()
        Me.GreCol = New quartus.FlatTrackBar()
        Me.GreEnCol1231 = New quartus.FlatLabel()
        Me.BluCol = New quartus.FlatTrackBar()
        Me.BluEnColText = New quartus.FlatLabel()
        Me.RedCol = New quartus.FlatTrackBar()
        Me.FlatLabel1 = New quartus.FlatLabel()
        Me.FlatButton3 = New quartus.FlatButton()
        Me.FormSkin1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.PictureBox1)
        Me.FormSkin1.Controls.Add(Me.AlpCol)
        Me.FormSkin1.Controls.Add(Me.FlatLabel4)
        Me.FormSkin1.Controls.Add(Me.GreCol)
        Me.FormSkin1.Controls.Add(Me.GreEnCol1231)
        Me.FormSkin1.Controls.Add(Me.BluCol)
        Me.FormSkin1.Controls.Add(Me.BluEnColText)
        Me.FormSkin1.Controls.Add(Me.RedCol)
        Me.FormSkin1.Controls.Add(Me.FlatLabel1)
        Me.FormSkin1.Controls.Add(Me.FlatButton3)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(474, 240)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "Color Mixer"
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(305, 73)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(155, 148)
        Me.PictureBox1.TabIndex = 103
        Me.PictureBox1.TabStop = False
        '
        'AlpCol
        '
        Me.AlpCol.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.AlpCol.HatchColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.AlpCol.Location = New System.Drawing.Point(16, 198)
        Me.AlpCol.Maximum = 255
        Me.AlpCol.Minimum = 0
        Me.AlpCol.Name = "AlpCol"
        Me.AlpCol.ShowValue = True
        Me.AlpCol.Size = New System.Drawing.Size(255, 23)
        Me.AlpCol.Style = quartus.FlatTrackBar._Style.Slider
        Me.AlpCol.TabIndex = 102
        Me.AlpCol.Text = "FlatTrackBar1"
        Me.AlpCol.TrackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.AlpCol.Value = 0
        '
        'FlatLabel4
        '
        Me.FlatLabel4.AutoSize = True
        Me.FlatLabel4.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel4.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel4.ForeColor = System.Drawing.Color.White
        Me.FlatLabel4.Location = New System.Drawing.Point(13, 181)
        Me.FlatLabel4.Name = "FlatLabel4"
        Me.FlatLabel4.Size = New System.Drawing.Size(37, 13)
        Me.FlatLabel4.TabIndex = 101
        Me.FlatLabel4.Text = "Alpha"
        '
        'GreCol
        '
        Me.GreCol.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.GreCol.HatchColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.GreCol.Location = New System.Drawing.Point(16, 112)
        Me.GreCol.Maximum = 255
        Me.GreCol.Minimum = 0
        Me.GreCol.Name = "GreCol"
        Me.GreCol.ShowValue = True
        Me.GreCol.Size = New System.Drawing.Size(255, 23)
        Me.GreCol.Style = quartus.FlatTrackBar._Style.Slider
        Me.GreCol.TabIndex = 100
        Me.GreCol.Text = "FlatTrackBar1"
        Me.GreCol.TrackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.GreCol.Value = 0
        '
        'GreEnCol1231
        '
        Me.GreEnCol1231.AutoSize = True
        Me.GreEnCol1231.BackColor = System.Drawing.Color.Transparent
        Me.GreEnCol1231.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.GreEnCol1231.ForeColor = System.Drawing.Color.White
        Me.GreEnCol1231.Location = New System.Drawing.Point(13, 95)
        Me.GreEnCol1231.Name = "GreEnCol1231"
        Me.GreEnCol1231.Size = New System.Drawing.Size(38, 13)
        Me.GreEnCol1231.TabIndex = 99
        Me.GreEnCol1231.Text = "Green"
        '
        'BluCol
        '
        Me.BluCol.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.BluCol.HatchColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BluCol.Location = New System.Drawing.Point(16, 155)
        Me.BluCol.Maximum = 255
        Me.BluCol.Minimum = 0
        Me.BluCol.Name = "BluCol"
        Me.BluCol.ShowValue = True
        Me.BluCol.Size = New System.Drawing.Size(255, 23)
        Me.BluCol.Style = quartus.FlatTrackBar._Style.Slider
        Me.BluCol.TabIndex = 98
        Me.BluCol.Text = "FlatTrackBar1"
        Me.BluCol.TrackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.BluCol.Value = 0
        '
        'BluEnColText
        '
        Me.BluEnColText.AutoSize = True
        Me.BluEnColText.BackColor = System.Drawing.Color.Transparent
        Me.BluEnColText.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.BluEnColText.ForeColor = System.Drawing.Color.White
        Me.BluEnColText.Location = New System.Drawing.Point(13, 138)
        Me.BluEnColText.Name = "BluEnColText"
        Me.BluEnColText.Size = New System.Drawing.Size(30, 13)
        Me.BluEnColText.TabIndex = 97
        Me.BluEnColText.Text = "Blue"
        '
        'RedCol
        '
        Me.RedCol.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.RedCol.HatchColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.RedCol.Location = New System.Drawing.Point(16, 73)
        Me.RedCol.Maximum = 255
        Me.RedCol.Minimum = 0
        Me.RedCol.Name = "RedCol"
        Me.RedCol.ShowValue = True
        Me.RedCol.Size = New System.Drawing.Size(255, 23)
        Me.RedCol.Style = quartus.FlatTrackBar._Style.Slider
        Me.RedCol.TabIndex = 96
        Me.RedCol.Text = "FlatTrackBar1"
        Me.RedCol.TrackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.RedCol.Value = 0
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel1.ForeColor = System.Drawing.Color.White
        Me.FlatLabel1.Location = New System.Drawing.Point(13, 56)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(27, 13)
        Me.FlatLabel1.TabIndex = 95
        Me.FlatLabel1.Text = "Red"
        '
        'FlatButton3
        '
        Me.FlatButton3.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton3.Location = New System.Drawing.Point(442, 12)
        Me.FlatButton3.Name = "FlatButton3"
        Me.FlatButton3.Rounded = False
        Me.FlatButton3.Size = New System.Drawing.Size(18, 18)
        Me.FlatButton3.TabIndex = 94
        Me.FlatButton3.Text = "X"
        Me.FlatButton3.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'ColorSelector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 240)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ColorSelector"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BbColor"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormSkin1 As FormSkin
    Friend WithEvents FlatButton3 As FlatButton
    Friend WithEvents AlpCol As FlatTrackBar
    Friend WithEvents FlatLabel4 As FlatLabel
    Friend WithEvents GreCol As FlatTrackBar
    Friend WithEvents GreEnCol1231 As FlatLabel
    Friend WithEvents BluCol As FlatTrackBar
    Friend WithEvents BluEnColText As FlatLabel
    Friend WithEvents RedCol As FlatTrackBar
    Friend WithEvents FlatLabel1 As FlatLabel
    Friend WithEvents PictureBox1 As Windows.Forms.PictureBox
End Class
