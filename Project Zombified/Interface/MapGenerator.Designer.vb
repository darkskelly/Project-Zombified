<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MapGenerator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.CharModel5 = New System.Windows.Forms.Button()
        Me.CharModel4 = New System.Windows.Forms.Button()
        Me.CharModel3 = New System.Windows.Forms.Button()
        Me.CharModel2 = New System.Windows.Forms.Button()
        Me.CharModel1 = New System.Windows.Forms.Button()
        Me.lblFile = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CmdRandom = New System.Windows.Forms.Button()
        Me.SaveName = New System.Windows.Forms.TextBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.Stats = New System.Windows.Forms.Button()
        Me.RouletteNPCTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'CharModel5
        '
        Me.CharModel5.Location = New System.Drawing.Point(1156, 394)
        Me.CharModel5.Name = "CharModel5"
        Me.CharModel5.Size = New System.Drawing.Size(83, 34)
        Me.CharModel5.TabIndex = 20
        Me.CharModel5.TabStop = False
        Me.CharModel5.Text = "Princess"
        Me.CharModel5.UseVisualStyleBackColor = True
        '
        'CharModel4
        '
        Me.CharModel4.Location = New System.Drawing.Point(1156, 429)
        Me.CharModel4.Name = "CharModel4"
        Me.CharModel4.Size = New System.Drawing.Size(83, 34)
        Me.CharModel4.TabIndex = 19
        Me.CharModel4.TabStop = False
        Me.CharModel4.Text = "Kingsley"
        Me.CharModel4.UseVisualStyleBackColor = True
        '
        'CharModel3
        '
        Me.CharModel3.Location = New System.Drawing.Point(1156, 464)
        Me.CharModel3.Name = "CharModel3"
        Me.CharModel3.Size = New System.Drawing.Size(83, 34)
        Me.CharModel3.TabIndex = 18
        Me.CharModel3.TabStop = False
        Me.CharModel3.Text = "Paladin"
        Me.CharModel3.UseVisualStyleBackColor = True
        '
        'CharModel2
        '
        Me.CharModel2.Location = New System.Drawing.Point(1156, 499)
        Me.CharModel2.Name = "CharModel2"
        Me.CharModel2.Size = New System.Drawing.Size(83, 34)
        Me.CharModel2.TabIndex = 17
        Me.CharModel2.TabStop = False
        Me.CharModel2.Text = "Mage"
        Me.CharModel2.UseVisualStyleBackColor = True
        '
        'CharModel1
        '
        Me.CharModel1.Location = New System.Drawing.Point(1156, 528)
        Me.CharModel1.Name = "CharModel1"
        Me.CharModel1.Size = New System.Drawing.Size(83, 34)
        Me.CharModel1.TabIndex = 16
        Me.CharModel1.TabStop = False
        Me.CharModel1.Text = "Warrior"
        Me.CharModel1.UseVisualStyleBackColor = True
        '
        'lblFile
        '
        Me.lblFile.AutoSize = True
        Me.lblFile.Location = New System.Drawing.Point(1131, 572)
        Me.lblFile.Name = "lblFile"
        Me.lblFile.Size = New System.Drawing.Size(117, 20)
        Me.lblFile.TabIndex = 15
        Me.lblFile.Text = "No File Selected"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1145, 595)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 34)
        Me.Button1.TabIndex = 14
        Me.Button1.TabStop = False
        Me.Button1.Text = "Load Map"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CmdRandom
        '
        Me.CmdRandom.Location = New System.Drawing.Point(1086, 635)
        Me.CmdRandom.Name = "CmdRandom"
        Me.CmdRandom.Size = New System.Drawing.Size(153, 34)
        Me.CmdRandom.TabIndex = 21
        Me.CmdRandom.TabStop = False
        Me.CmdRandom.Text = "Load Random Map"
        Me.CmdRandom.UseVisualStyleBackColor = True
        '
        'SaveName
        '
        Me.SaveName.AcceptsTab = True
        Me.SaveName.Location = New System.Drawing.Point(1107, 258)
        Me.SaveName.Name = "SaveName"
        Me.SaveName.Size = New System.Drawing.Size(125, 27)
        Me.SaveName.TabIndex = 23
        Me.SaveName.TabStop = False
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(1107, 302)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(132, 51)
        Me.SaveButton.TabIndex = 22
        Me.SaveButton.TabStop = False
        Me.SaveButton.Text = "Save Map"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'Stats
        '
        Me.Stats.Location = New System.Drawing.Point(1145, 359)
        Me.Stats.Name = "Stats"
        Me.Stats.Size = New System.Drawing.Size(94, 29)
        Me.Stats.TabIndex = 26
        Me.Stats.TabStop = False
        Me.Stats.Text = "Stats"
        Me.Stats.UseVisualStyleBackColor = True
        '
        'RouletteNPCTimer
        '
        Me.RouletteNPCTimer.Enabled = True
        Me.RouletteNPCTimer.Interval = 1000
        '
        'MapGenerator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1251, 699)
        Me.Controls.Add(Me.Stats)
        Me.Controls.Add(Me.SaveName)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.CmdRandom)
        Me.Controls.Add(Me.CharModel5)
        Me.Controls.Add(Me.CharModel4)
        Me.Controls.Add(Me.CharModel3)
        Me.Controls.Add(Me.CharModel2)
        Me.Controls.Add(Me.CharModel1)
        Me.Controls.Add(Me.lblFile)
        Me.Controls.Add(Me.Button1)
        Me.Name = "MapGenerator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "MapGenerator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents CharModel5 As Button
    Friend WithEvents CharModel4 As Button
    Friend WithEvents CharModel3 As Button
    Friend WithEvents CharModel2 As Button
    Friend WithEvents CharModel1 As Button
    Friend WithEvents lblFile As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents CmdRandom As Button
    Friend WithEvents SaveName As TextBox
    Friend WithEvents SaveButton As Button
    Friend WithEvents Stats As Button
    Friend WithEvents RouletteNPCTimer As Timer
End Class
