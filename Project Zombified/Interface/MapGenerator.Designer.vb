<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MapGenerator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.RouletteNPCTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ShoeSlot = New System.Windows.Forms.PictureBox()
        Me.LegSlot = New System.Windows.Forms.PictureBox()
        Me.ChestSlot = New System.Windows.Forms.PictureBox()
        Me.HeadSlot = New System.Windows.Forms.PictureBox()
        Me.Stats = New System.Windows.Forms.Button()
        Me.SaveName = New System.Windows.Forms.TextBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.CmdRandom = New System.Windows.Forms.Button()
        Me.CharModel5 = New System.Windows.Forms.Button()
        Me.CharModel4 = New System.Windows.Forms.Button()
        Me.CharModel3 = New System.Windows.Forms.Button()
        Me.CharModel2 = New System.Windows.Forms.Button()
        Me.CharModel1 = New System.Windows.Forms.Button()
        Me.lblFile = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Inv31 = New System.Windows.Forms.PictureBox()
        Me.Inv21 = New System.Windows.Forms.PictureBox()
        Me.Inv11 = New System.Windows.Forms.PictureBox()
        Me.Inv32 = New System.Windows.Forms.PictureBox()
        Me.Inv22 = New System.Windows.Forms.PictureBox()
        Me.Inv12 = New System.Windows.Forms.PictureBox()
        Me.Inv33 = New System.Windows.Forms.PictureBox()
        Me.Inv23 = New System.Windows.Forms.PictureBox()
        Me.Inv13 = New System.Windows.Forms.PictureBox()
        Me.Inv11Count = New System.Windows.Forms.Label()
        Me.Inv12Count = New System.Windows.Forms.Label()
        Me.Inv13Count = New System.Windows.Forms.Label()
        Me.Inv23Count = New System.Windows.Forms.Label()
        Me.Inv22Count = New System.Windows.Forms.Label()
        Me.Inv21Count = New System.Windows.Forms.Label()
        Me.Inv33Count = New System.Windows.Forms.Label()
        Me.Inv32Count = New System.Windows.Forms.Label()
        Me.Inv31Count = New System.Windows.Forms.Label()
        Me.Inv11TT = New System.Windows.Forms.ToolTip(Me.components)
        Me.Inv12TT = New System.Windows.Forms.ToolTip(Me.components)
        Me.Inv13TT = New System.Windows.Forms.ToolTip(Me.components)
        Me.Inv21TT = New System.Windows.Forms.ToolTip(Me.components)
        Me.Inv22TT = New System.Windows.Forms.ToolTip(Me.components)
        Me.Inv23TT = New System.Windows.Forms.ToolTip(Me.components)
        Me.Inv31TT = New System.Windows.Forms.ToolTip(Me.components)
        Me.Inv32TT = New System.Windows.Forms.ToolTip(Me.components)
        Me.Inv33TT = New System.Windows.Forms.ToolTip(Me.components)
        Me.WeaponSlot = New System.Windows.Forms.PictureBox()
        Me.PotionSlot = New System.Windows.Forms.PictureBox()
        CType(Me.ShoeSlot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LegSlot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChestSlot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeadSlot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inv31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inv21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inv11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inv32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inv22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inv12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inv33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inv23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inv13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WeaponSlot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PotionSlot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'RouletteNPCTimer
        '
        Me.RouletteNPCTimer.Enabled = True
        Me.RouletteNPCTimer.Interval = 1000
        '
        'ShoeSlot
        '
        Me.ShoeSlot.BackColor = System.Drawing.Color.Transparent
        Me.ShoeSlot.BackgroundImage = Global.Project_Zombified.My.Resources.Resources.ShoeSlot
        Me.ShoeSlot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ShoeSlot.Enabled = False
        Me.ShoeSlot.Location = New System.Drawing.Point(11, 513)
        Me.ShoeSlot.Name = "ShoeSlot"
        Me.ShoeSlot.Size = New System.Drawing.Size(48, 48)
        Me.ShoeSlot.TabIndex = 45
        Me.ShoeSlot.TabStop = False
        '
        'LegSlot
        '
        Me.LegSlot.BackColor = System.Drawing.Color.Transparent
        Me.LegSlot.BackgroundImage = Global.Project_Zombified.My.Resources.Resources.GloveSlot
        Me.LegSlot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LegSlot.Enabled = False
        Me.LegSlot.Location = New System.Drawing.Point(11, 459)
        Me.LegSlot.Name = "LegSlot"
        Me.LegSlot.Size = New System.Drawing.Size(48, 48)
        Me.LegSlot.TabIndex = 44
        Me.LegSlot.TabStop = False
        '
        'ChestSlot
        '
        Me.ChestSlot.BackColor = System.Drawing.Color.Transparent
        Me.ChestSlot.BackgroundImage = Global.Project_Zombified.My.Resources.Resources.ChestSlot
        Me.ChestSlot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ChestSlot.Enabled = False
        Me.ChestSlot.Location = New System.Drawing.Point(11, 405)
        Me.ChestSlot.Name = "ChestSlot"
        Me.ChestSlot.Size = New System.Drawing.Size(48, 48)
        Me.ChestSlot.TabIndex = 43
        Me.ChestSlot.TabStop = False
        '
        'HeadSlot
        '
        Me.HeadSlot.BackColor = System.Drawing.Color.Transparent
        Me.HeadSlot.BackgroundImage = Global.Project_Zombified.My.Resources.Resources.HelmSlot
        Me.HeadSlot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HeadSlot.Enabled = False
        Me.HeadSlot.Location = New System.Drawing.Point(11, 351)
        Me.HeadSlot.Name = "HeadSlot"
        Me.HeadSlot.Size = New System.Drawing.Size(48, 48)
        Me.HeadSlot.TabIndex = 42
        Me.HeadSlot.TabStop = False
        '
        'Stats
        '
        Me.Stats.Location = New System.Drawing.Point(1210, 304)
        Me.Stats.Name = "Stats"
        Me.Stats.Size = New System.Drawing.Size(94, 29)
        Me.Stats.TabIndex = 56
        Me.Stats.TabStop = False
        Me.Stats.Text = "Stats"
        Me.Stats.UseVisualStyleBackColor = True
        '
        'SaveName
        '
        Me.SaveName.AcceptsTab = True
        Me.SaveName.Location = New System.Drawing.Point(1172, 214)
        Me.SaveName.Name = "SaveName"
        Me.SaveName.Size = New System.Drawing.Size(125, 27)
        Me.SaveName.TabIndex = 55
        Me.SaveName.TabStop = False
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(1172, 247)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(132, 51)
        Me.SaveButton.TabIndex = 54
        Me.SaveButton.TabStop = False
        Me.SaveButton.Text = "Save Map"
        Me.SaveButton.UseMnemonic = False
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'CmdRandom
        '
        Me.CmdRandom.Location = New System.Drawing.Point(1160, 625)
        Me.CmdRandom.Name = "CmdRandom"
        Me.CmdRandom.Size = New System.Drawing.Size(153, 34)
        Me.CmdRandom.TabIndex = 53
        Me.CmdRandom.TabStop = False
        Me.CmdRandom.Text = "Load Random Map"
        Me.CmdRandom.UseVisualStyleBackColor = True
        '
        'CharModel5
        '
        Me.CharModel5.Location = New System.Drawing.Point(1221, 339)
        Me.CharModel5.Name = "CharModel5"
        Me.CharModel5.Size = New System.Drawing.Size(83, 34)
        Me.CharModel5.TabIndex = 52
        Me.CharModel5.TabStop = False
        Me.CharModel5.Text = "Princess"
        Me.CharModel5.UseVisualStyleBackColor = True
        '
        'CharModel4
        '
        Me.CharModel4.Location = New System.Drawing.Point(1221, 379)
        Me.CharModel4.Name = "CharModel4"
        Me.CharModel4.Size = New System.Drawing.Size(83, 34)
        Me.CharModel4.TabIndex = 51
        Me.CharModel4.TabStop = False
        Me.CharModel4.Text = "Kingsley"
        Me.CharModel4.UseVisualStyleBackColor = True
        '
        'CharModel3
        '
        Me.CharModel3.Location = New System.Drawing.Point(1221, 419)
        Me.CharModel3.Name = "CharModel3"
        Me.CharModel3.Size = New System.Drawing.Size(83, 34)
        Me.CharModel3.TabIndex = 50
        Me.CharModel3.TabStop = False
        Me.CharModel3.Text = "Paladin"
        Me.CharModel3.UseVisualStyleBackColor = True
        '
        'CharModel2
        '
        Me.CharModel2.Location = New System.Drawing.Point(1221, 459)
        Me.CharModel2.Name = "CharModel2"
        Me.CharModel2.Size = New System.Drawing.Size(83, 34)
        Me.CharModel2.TabIndex = 49
        Me.CharModel2.TabStop = False
        Me.CharModel2.Text = "Mage"
        Me.CharModel2.UseVisualStyleBackColor = True
        '
        'CharModel1
        '
        Me.CharModel1.Location = New System.Drawing.Point(1221, 499)
        Me.CharModel1.Name = "CharModel1"
        Me.CharModel1.Size = New System.Drawing.Size(83, 34)
        Me.CharModel1.TabIndex = 48
        Me.CharModel1.TabStop = False
        Me.CharModel1.Text = "Warrior"
        Me.CharModel1.UseVisualStyleBackColor = True
        '
        'lblFile
        '
        Me.lblFile.AutoSize = True
        Me.lblFile.Location = New System.Drawing.Point(1196, 536)
        Me.lblFile.Name = "lblFile"
        Me.lblFile.Size = New System.Drawing.Size(117, 20)
        Me.lblFile.TabIndex = 47
        Me.lblFile.Text = "No File Selected"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1210, 576)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 34)
        Me.Button1.TabIndex = 46
        Me.Button1.TabStop = False
        Me.Button1.Text = "Load Map"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Inv31
        '
        Me.Inv31.BackColor = System.Drawing.Color.Transparent
        Me.Inv31.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Inv31.Location = New System.Drawing.Point(11, 117)
        Me.Inv31.Name = "Inv31"
        Me.Inv31.Size = New System.Drawing.Size(48, 48)
        Me.Inv31.TabIndex = 59
        Me.Inv31.TabStop = False
        '
        'Inv21
        '
        Me.Inv21.BackColor = System.Drawing.Color.Transparent
        Me.Inv21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Inv21.Location = New System.Drawing.Point(11, 63)
        Me.Inv21.Name = "Inv21"
        Me.Inv21.Size = New System.Drawing.Size(48, 48)
        Me.Inv21.TabIndex = 58
        Me.Inv21.TabStop = False
        '
        'Inv11
        '
        Me.Inv11.BackColor = System.Drawing.Color.Transparent
        Me.Inv11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Inv11.Location = New System.Drawing.Point(11, 9)
        Me.Inv11.Name = "Inv11"
        Me.Inv11.Size = New System.Drawing.Size(48, 48)
        Me.Inv11.TabIndex = 57
        Me.Inv11.TabStop = False
        '
        'Inv32
        '
        Me.Inv32.BackColor = System.Drawing.Color.Transparent
        Me.Inv32.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Inv32.Location = New System.Drawing.Point(65, 117)
        Me.Inv32.Name = "Inv32"
        Me.Inv32.Size = New System.Drawing.Size(48, 48)
        Me.Inv32.TabIndex = 62
        Me.Inv32.TabStop = False
        '
        'Inv22
        '
        Me.Inv22.BackColor = System.Drawing.Color.Transparent
        Me.Inv22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Inv22.Location = New System.Drawing.Point(65, 63)
        Me.Inv22.Name = "Inv22"
        Me.Inv22.Size = New System.Drawing.Size(48, 48)
        Me.Inv22.TabIndex = 61
        Me.Inv22.TabStop = False
        '
        'Inv12
        '
        Me.Inv12.BackColor = System.Drawing.Color.Transparent
        Me.Inv12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Inv12.Location = New System.Drawing.Point(65, 9)
        Me.Inv12.Name = "Inv12"
        Me.Inv12.Size = New System.Drawing.Size(48, 48)
        Me.Inv12.TabIndex = 60
        Me.Inv12.TabStop = False
        '
        'Inv33
        '
        Me.Inv33.BackColor = System.Drawing.Color.Transparent
        Me.Inv33.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Inv33.Location = New System.Drawing.Point(119, 117)
        Me.Inv33.Name = "Inv33"
        Me.Inv33.Size = New System.Drawing.Size(48, 48)
        Me.Inv33.TabIndex = 65
        Me.Inv33.TabStop = False
        '
        'Inv23
        '
        Me.Inv23.BackColor = System.Drawing.Color.Transparent
        Me.Inv23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Inv23.Location = New System.Drawing.Point(119, 63)
        Me.Inv23.Name = "Inv23"
        Me.Inv23.Size = New System.Drawing.Size(48, 48)
        Me.Inv23.TabIndex = 64
        Me.Inv23.TabStop = False
        '
        'Inv13
        '
        Me.Inv13.AccessibleDescription = ""
        Me.Inv13.AccessibleName = ""
        Me.Inv13.BackColor = System.Drawing.Color.Transparent
        Me.Inv13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Inv13.Location = New System.Drawing.Point(119, 9)
        Me.Inv13.Name = "Inv13"
        Me.Inv13.Size = New System.Drawing.Size(48, 48)
        Me.Inv13.TabIndex = 63
        Me.Inv13.TabStop = False
        '
        'Inv11Count
        '
        Me.Inv11Count.AutoSize = True
        Me.Inv11Count.BackColor = System.Drawing.SystemColors.Info
        Me.Inv11Count.Enabled = False
        Me.Inv11Count.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Inv11Count.Location = New System.Drawing.Point(49, 45)
        Me.Inv11Count.Name = "Inv11Count"
        Me.Inv11Count.Size = New System.Drawing.Size(0, 12)
        Me.Inv11Count.TabIndex = 66
        Me.Inv11Count.Visible = False
        '
        'Inv12Count
        '
        Me.Inv12Count.AutoSize = True
        Me.Inv12Count.BackColor = System.Drawing.SystemColors.Info
        Me.Inv12Count.Enabled = False
        Me.Inv12Count.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Inv12Count.Location = New System.Drawing.Point(103, 45)
        Me.Inv12Count.Name = "Inv12Count"
        Me.Inv12Count.Size = New System.Drawing.Size(0, 12)
        Me.Inv12Count.TabIndex = 67
        Me.Inv12Count.Visible = False
        '
        'Inv13Count
        '
        Me.Inv13Count.AutoSize = True
        Me.Inv13Count.BackColor = System.Drawing.SystemColors.Info
        Me.Inv13Count.Enabled = False
        Me.Inv13Count.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Inv13Count.Location = New System.Drawing.Point(157, 45)
        Me.Inv13Count.Name = "Inv13Count"
        Me.Inv13Count.Size = New System.Drawing.Size(0, 12)
        Me.Inv13Count.TabIndex = 68
        Me.Inv13Count.Visible = False
        '
        'Inv23Count
        '
        Me.Inv23Count.AutoSize = True
        Me.Inv23Count.BackColor = System.Drawing.SystemColors.Info
        Me.Inv23Count.Enabled = False
        Me.Inv23Count.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Inv23Count.Location = New System.Drawing.Point(157, 99)
        Me.Inv23Count.Name = "Inv23Count"
        Me.Inv23Count.Size = New System.Drawing.Size(0, 12)
        Me.Inv23Count.TabIndex = 71
        Me.Inv23Count.Visible = False
        '
        'Inv22Count
        '
        Me.Inv22Count.AutoSize = True
        Me.Inv22Count.BackColor = System.Drawing.SystemColors.Info
        Me.Inv22Count.Enabled = False
        Me.Inv22Count.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Inv22Count.Location = New System.Drawing.Point(103, 99)
        Me.Inv22Count.Name = "Inv22Count"
        Me.Inv22Count.Size = New System.Drawing.Size(0, 12)
        Me.Inv22Count.TabIndex = 70
        Me.Inv22Count.Visible = False
        '
        'Inv21Count
        '
        Me.Inv21Count.AutoSize = True
        Me.Inv21Count.BackColor = System.Drawing.SystemColors.Info
        Me.Inv21Count.Enabled = False
        Me.Inv21Count.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Inv21Count.Location = New System.Drawing.Point(49, 99)
        Me.Inv21Count.Name = "Inv21Count"
        Me.Inv21Count.Size = New System.Drawing.Size(0, 12)
        Me.Inv21Count.TabIndex = 69
        Me.Inv21Count.Visible = False
        '
        'Inv33Count
        '
        Me.Inv33Count.AutoSize = True
        Me.Inv33Count.BackColor = System.Drawing.SystemColors.Info
        Me.Inv33Count.Enabled = False
        Me.Inv33Count.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Inv33Count.Location = New System.Drawing.Point(157, 153)
        Me.Inv33Count.Name = "Inv33Count"
        Me.Inv33Count.Size = New System.Drawing.Size(0, 12)
        Me.Inv33Count.TabIndex = 74
        Me.Inv33Count.Visible = False
        '
        'Inv32Count
        '
        Me.Inv32Count.AutoSize = True
        Me.Inv32Count.BackColor = System.Drawing.SystemColors.Info
        Me.Inv32Count.Enabled = False
        Me.Inv32Count.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Inv32Count.Location = New System.Drawing.Point(103, 153)
        Me.Inv32Count.Name = "Inv32Count"
        Me.Inv32Count.Size = New System.Drawing.Size(0, 12)
        Me.Inv32Count.TabIndex = 73
        Me.Inv32Count.Visible = False
        '
        'Inv31Count
        '
        Me.Inv31Count.AutoSize = True
        Me.Inv31Count.BackColor = System.Drawing.SystemColors.Info
        Me.Inv31Count.Enabled = False
        Me.Inv31Count.Font = New System.Drawing.Font("Segoe UI", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Inv31Count.Location = New System.Drawing.Point(49, 153)
        Me.Inv31Count.Name = "Inv31Count"
        Me.Inv31Count.Size = New System.Drawing.Size(0, 12)
        Me.Inv31Count.TabIndex = 72
        Me.Inv31Count.Visible = False
        '
        'WeaponSlot
        '
        Me.WeaponSlot.BackColor = System.Drawing.Color.Transparent
        Me.WeaponSlot.BackgroundImage = Global.Project_Zombified.My.Resources.Resources.WeaponSlot
        Me.WeaponSlot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.WeaponSlot.Enabled = False
        Me.WeaponSlot.Location = New System.Drawing.Point(11, 563)
        Me.WeaponSlot.Name = "WeaponSlot"
        Me.WeaponSlot.Size = New System.Drawing.Size(48, 88)
        Me.WeaponSlot.TabIndex = 75
        Me.WeaponSlot.TabStop = False
        '
        'PotionSlot
        '
        Me.PotionSlot.BackColor = System.Drawing.Color.Transparent
        Me.PotionSlot.BackgroundImage = Global.Project_Zombified.My.Resources.Resources.PotSlot
        Me.PotionSlot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PotionSlot.Enabled = False
        Me.PotionSlot.Location = New System.Drawing.Point(12, 657)
        Me.PotionSlot.Name = "PotionSlot"
        Me.PotionSlot.Size = New System.Drawing.Size(48, 48)
        Me.PotionSlot.TabIndex = 76
        Me.PotionSlot.TabStop = False
        '
        'MapGenerator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1316, 717)
        Me.Controls.Add(Me.PotionSlot)
        Me.Controls.Add(Me.WeaponSlot)
        Me.Controls.Add(Me.Inv33Count)
        Me.Controls.Add(Me.Inv32Count)
        Me.Controls.Add(Me.Inv31Count)
        Me.Controls.Add(Me.Inv23Count)
        Me.Controls.Add(Me.Inv22Count)
        Me.Controls.Add(Me.Inv21Count)
        Me.Controls.Add(Me.Inv13Count)
        Me.Controls.Add(Me.Inv12Count)
        Me.Controls.Add(Me.Inv11Count)
        Me.Controls.Add(Me.Inv33)
        Me.Controls.Add(Me.Inv23)
        Me.Controls.Add(Me.Inv13)
        Me.Controls.Add(Me.Inv32)
        Me.Controls.Add(Me.Inv22)
        Me.Controls.Add(Me.Inv12)
        Me.Controls.Add(Me.Inv31)
        Me.Controls.Add(Me.Inv21)
        Me.Controls.Add(Me.Inv11)
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
        Me.Controls.Add(Me.ShoeSlot)
        Me.Controls.Add(Me.LegSlot)
        Me.Controls.Add(Me.ChestSlot)
        Me.Controls.Add(Me.HeadSlot)
        Me.Name = "MapGenerator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Project Zombified"
        CType(Me.ShoeSlot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LegSlot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChestSlot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeadSlot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inv31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inv21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inv11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inv32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inv22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inv12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inv33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inv23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inv13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WeaponSlot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PotionSlot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents RouletteNPCTimer As Timer
    Friend WithEvents ShoeSlot As PictureBox
    Friend WithEvents LegSlot As PictureBox
    Friend WithEvents ChestSlot As PictureBox
    Friend WithEvents HeadSlot As PictureBox
    Friend WithEvents Stats As Button
    Friend WithEvents SaveName As TextBox
    Friend WithEvents SaveButton As Button
    Friend WithEvents CmdRandom As Button
    Friend WithEvents CharModel5 As Button
    Friend WithEvents CharModel4 As Button
    Friend WithEvents CharModel3 As Button
    Friend WithEvents CharModel2 As Button
    Friend WithEvents CharModel1 As Button
    Friend WithEvents lblFile As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Inv31 As PictureBox
    Friend WithEvents Inv21 As PictureBox
    Friend WithEvents Inv11 As PictureBox
    Friend WithEvents Inv32 As PictureBox
    Friend WithEvents Inv22 As PictureBox
    Friend WithEvents Inv12 As PictureBox
    Friend WithEvents Inv33 As PictureBox
    Friend WithEvents Inv23 As PictureBox
    Friend WithEvents Inv13 As PictureBox
    Friend WithEvents Inv11Count As Label
    Friend WithEvents Inv12Count As Label
    Friend WithEvents Inv13Count As Label
    Friend WithEvents Inv23Count As Label
    Friend WithEvents Inv22Count As Label
    Friend WithEvents Inv21Count As Label
    Friend WithEvents Inv33Count As Label
    Friend WithEvents Inv32Count As Label
    Friend WithEvents Inv31Count As Label
    Friend WithEvents Inv11TT As ToolTip
    Friend WithEvents Inv12TT As ToolTip
    Friend WithEvents Inv13TT As ToolTip
    Friend WithEvents Inv21TT As ToolTip
    Friend WithEvents Inv22TT As ToolTip
    Friend WithEvents Inv23TT As ToolTip
    Friend WithEvents Inv31TT As ToolTip
    Friend WithEvents Inv32TT As ToolTip
    Friend WithEvents Inv33TT As ToolTip
    Friend WithEvents WeaponSlot As PictureBox
    Friend WithEvents PotionSlot As PictureBox
End Class
