<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CharacterCreationScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CharacterCreationScreen))
        Me.ClassLabel = New System.Windows.Forms.Label()
        Me.Class_Ranged = New System.Windows.Forms.Button()
        Me.Class_Hunter = New System.Windows.Forms.Button()
        Me.Class_Paladin = New System.Windows.Forms.Button()
        Me.Class_Tank = New System.Windows.Forms.Button()
        Me.Class_Warrior = New System.Windows.Forms.Button()
        Me.CharSelectionPic = New System.Windows.Forms.PictureBox()
        Me.CharacterLabel = New System.Windows.Forms.Label()
        Me.Character_TrackBar = New System.Windows.Forms.TrackBar()
        Me.Character_Trackbar_Label = New System.Windows.Forms.Label()
        Me.LuckBar = New System.Windows.Forms.ProgressBar()
        Me.LuckButton = New System.Windows.Forms.Button()
        Me.DexterityBar = New System.Windows.Forms.ProgressBar()
        Me.DexterityButton = New System.Windows.Forms.Button()
        Me.IntellegenceBar = New System.Windows.Forms.ProgressBar()
        Me.IntellegenceButton = New System.Windows.Forms.Button()
        Me.StrengthBar = New System.Windows.Forms.ProgressBar()
        Me.StrengthStatButton = New System.Windows.Forms.Button()
        Me.MovementSpeedBar = New System.Windows.Forms.ProgressBar()
        Me.Movement = New System.Windows.Forms.Button()
        Me.Skills_Label = New System.Windows.Forms.Label()
        Me.Comfirm_Finish = New System.Windows.Forms.Button()
        Me.CharName = New System.Windows.Forms.Label()
        Me.SkillPointsLabel = New System.Windows.Forms.Label()
        Me.PlayerLevelLabel = New System.Windows.Forms.Label()
        CType(Me.CharSelectionPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Character_TrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ClassLabel
        '
        Me.ClassLabel.AutoSize = True
        Me.ClassLabel.Font = New System.Drawing.Font("Algerian", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ClassLabel.Location = New System.Drawing.Point(12, 9)
        Me.ClassLabel.Name = "ClassLabel"
        Me.ClassLabel.Size = New System.Drawing.Size(98, 31)
        Me.ClassLabel.TabIndex = 0
        Me.ClassLabel.Text = "Class"
        '
        'Class_Ranged
        '
        Me.Class_Ranged.BackgroundImage = Global.Project_Zombified.My.Resources.Resources.MageIcon
        Me.Class_Ranged.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Class_Ranged.Location = New System.Drawing.Point(12, 128)
        Me.Class_Ranged.Name = "Class_Ranged"
        Me.Class_Ranged.Size = New System.Drawing.Size(75, 75)
        Me.Class_Ranged.TabIndex = 1
        Me.Class_Ranged.UseVisualStyleBackColor = True
        '
        'Class_Hunter
        '
        Me.Class_Hunter.BackgroundImage = CType(resources.GetObject("Class_Hunter.BackgroundImage"), System.Drawing.Image)
        Me.Class_Hunter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Class_Hunter.Location = New System.Drawing.Point(12, 47)
        Me.Class_Hunter.Name = "Class_Hunter"
        Me.Class_Hunter.Size = New System.Drawing.Size(75, 75)
        Me.Class_Hunter.TabIndex = 2
        Me.Class_Hunter.UseVisualStyleBackColor = True
        '
        'Class_Paladin
        '
        Me.Class_Paladin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Class_Paladin.Image = Global.Project_Zombified.My.Resources.Resources.PaladinIcon
        Me.Class_Paladin.Location = New System.Drawing.Point(12, 366)
        Me.Class_Paladin.Name = "Class_Paladin"
        Me.Class_Paladin.Size = New System.Drawing.Size(75, 75)
        Me.Class_Paladin.TabIndex = 3
        Me.Class_Paladin.UseVisualStyleBackColor = True
        '
        'Class_Tank
        '
        Me.Class_Tank.BackgroundImage = Global.Project_Zombified.My.Resources.Resources.TankIcon
        Me.Class_Tank.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Class_Tank.Location = New System.Drawing.Point(12, 209)
        Me.Class_Tank.Name = "Class_Tank"
        Me.Class_Tank.Size = New System.Drawing.Size(75, 75)
        Me.Class_Tank.TabIndex = 4
        Me.Class_Tank.UseVisualStyleBackColor = True
        '
        'Class_Warrior
        '
        Me.Class_Warrior.BackgroundImage = CType(resources.GetObject("Class_Warrior.BackgroundImage"), System.Drawing.Image)
        Me.Class_Warrior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Class_Warrior.Location = New System.Drawing.Point(12, 289)
        Me.Class_Warrior.Name = "Class_Warrior"
        Me.Class_Warrior.Size = New System.Drawing.Size(75, 75)
        Me.Class_Warrior.TabIndex = 5
        Me.Class_Warrior.UseVisualStyleBackColor = True
        '
        'CharSelectionPic
        '
        Me.CharSelectionPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CharSelectionPic.Location = New System.Drawing.Point(240, 64)
        Me.CharSelectionPic.Name = "CharSelectionPic"
        Me.CharSelectionPic.Size = New System.Drawing.Size(136, 136)
        Me.CharSelectionPic.TabIndex = 6
        Me.CharSelectionPic.TabStop = False
        '
        'CharacterLabel
        '
        Me.CharacterLabel.AutoSize = True
        Me.CharacterLabel.Font = New System.Drawing.Font("Algerian", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CharacterLabel.Location = New System.Drawing.Point(228, 9)
        Me.CharacterLabel.Name = "CharacterLabel"
        Me.CharacterLabel.Size = New System.Drawing.Size(175, 31)
        Me.CharacterLabel.TabIndex = 7
        Me.CharacterLabel.Text = "Character"
        '
        'Character_TrackBar
        '
        Me.Character_TrackBar.Location = New System.Drawing.Point(245, 212)
        Me.Character_TrackBar.Maximum = 6
        Me.Character_TrackBar.Minimum = 1
        Me.Character_TrackBar.Name = "Character_TrackBar"
        Me.Character_TrackBar.Size = New System.Drawing.Size(130, 56)
        Me.Character_TrackBar.TabIndex = 9
        Me.Character_TrackBar.Value = 1
        '
        'Character_Trackbar_Label
        '
        Me.Character_Trackbar_Label.AutoSize = True
        Me.Character_Trackbar_Label.Font = New System.Drawing.Font("Algerian", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Character_Trackbar_Label.Location = New System.Drawing.Point(271, 248)
        Me.Character_Trackbar_Label.Name = "Character_Trackbar_Label"
        Me.Character_Trackbar_Label.Size = New System.Drawing.Size(0, 20)
        Me.Character_Trackbar_Label.TabIndex = 10
        '
        'LuckBar
        '
        Me.LuckBar.BackColor = System.Drawing.SystemColors.MenuText
        Me.LuckBar.ForeColor = System.Drawing.Color.Lime
        Me.LuckBar.Location = New System.Drawing.Point(564, 383)
        Me.LuckBar.Name = "LuckBar"
        Me.LuckBar.Size = New System.Drawing.Size(143, 52)
        Me.LuckBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.LuckBar.TabIndex = 20
        '
        'LuckButton
        '
        Me.LuckButton.BackgroundImage = Global.Project_Zombified.My.Resources.Resources.Coin
        Me.LuckButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LuckButton.Location = New System.Drawing.Point(476, 370)
        Me.LuckButton.Name = "LuckButton"
        Me.LuckButton.Size = New System.Drawing.Size(72, 72)
        Me.LuckButton.TabIndex = 19
        Me.LuckButton.UseVisualStyleBackColor = True
        '
        'DexterityBar
        '
        Me.DexterityBar.BackColor = System.Drawing.SystemColors.MenuText
        Me.DexterityBar.ForeColor = System.Drawing.Color.Lime
        Me.DexterityBar.Location = New System.Drawing.Point(562, 302)
        Me.DexterityBar.Name = "DexterityBar"
        Me.DexterityBar.Size = New System.Drawing.Size(143, 52)
        Me.DexterityBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.DexterityBar.TabIndex = 18
        '
        'DexterityButton
        '
        Me.DexterityButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DexterityButton.Location = New System.Drawing.Point(476, 293)
        Me.DexterityButton.Name = "DexterityButton"
        Me.DexterityButton.Size = New System.Drawing.Size(72, 72)
        Me.DexterityButton.TabIndex = 17
        Me.DexterityButton.Text = "Dexterity"
        Me.DexterityButton.UseVisualStyleBackColor = True
        '
        'IntellegenceBar
        '
        Me.IntellegenceBar.BackColor = System.Drawing.SystemColors.MenuText
        Me.IntellegenceBar.ForeColor = System.Drawing.Color.Lime
        Me.IntellegenceBar.Location = New System.Drawing.Point(562, 232)
        Me.IntellegenceBar.Name = "IntellegenceBar"
        Me.IntellegenceBar.Size = New System.Drawing.Size(143, 52)
        Me.IntellegenceBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.IntellegenceBar.TabIndex = 16
        '
        'IntellegenceButton
        '
        Me.IntellegenceButton.BackgroundImage = Global.Project_Zombified.My.Resources.Resources.HumanBrainIcon
        Me.IntellegenceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.IntellegenceButton.Location = New System.Drawing.Point(476, 217)
        Me.IntellegenceButton.Name = "IntellegenceButton"
        Me.IntellegenceButton.Size = New System.Drawing.Size(72, 72)
        Me.IntellegenceButton.TabIndex = 15
        Me.IntellegenceButton.UseVisualStyleBackColor = True
        '
        'StrengthBar
        '
        Me.StrengthBar.BackColor = System.Drawing.SystemColors.MenuText
        Me.StrengthBar.ForeColor = System.Drawing.Color.Lime
        Me.StrengthBar.Location = New System.Drawing.Point(562, 148)
        Me.StrengthBar.Name = "StrengthBar"
        Me.StrengthBar.Size = New System.Drawing.Size(143, 52)
        Me.StrengthBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.StrengthBar.TabIndex = 14
        '
        'StrengthStatButton
        '
        Me.StrengthStatButton.BackgroundImage = Global.Project_Zombified.My.Resources.Resources.StrengthIcon
        Me.StrengthStatButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.StrengthStatButton.Location = New System.Drawing.Point(476, 139)
        Me.StrengthStatButton.Name = "StrengthStatButton"
        Me.StrengthStatButton.Size = New System.Drawing.Size(72, 72)
        Me.StrengthStatButton.TabIndex = 13
        Me.StrengthStatButton.UseVisualStyleBackColor = True
        '
        'MovementSpeedBar
        '
        Me.MovementSpeedBar.BackColor = System.Drawing.SystemColors.MenuText
        Me.MovementSpeedBar.ForeColor = System.Drawing.Color.Lime
        Me.MovementSpeedBar.Location = New System.Drawing.Point(562, 70)
        Me.MovementSpeedBar.Name = "MovementSpeedBar"
        Me.MovementSpeedBar.Size = New System.Drawing.Size(143, 52)
        Me.MovementSpeedBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.MovementSpeedBar.TabIndex = 12
        '
        'Movement
        '
        Me.Movement.BackgroundImage = Global.Project_Zombified.My.Resources.Resources.MovementSpeedIcon
        Me.Movement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Movement.Location = New System.Drawing.Point(476, 63)
        Me.Movement.Name = "Movement"
        Me.Movement.Size = New System.Drawing.Size(72, 72)
        Me.Movement.TabIndex = 11
        Me.Movement.UseVisualStyleBackColor = True
        '
        'Skills_Label
        '
        Me.Skills_Label.AutoSize = True
        Me.Skills_Label.Font = New System.Drawing.Font("Algerian", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Skills_Label.Location = New System.Drawing.Point(564, 9)
        Me.Skills_Label.Name = "Skills_Label"
        Me.Skills_Label.Size = New System.Drawing.Size(104, 31)
        Me.Skills_Label.TabIndex = 21
        Me.Skills_Label.Text = "Skills"
        '
        'Comfirm_Finish
        '
        Me.Comfirm_Finish.Location = New System.Drawing.Point(228, 409)
        Me.Comfirm_Finish.Name = "Comfirm_Finish"
        Me.Comfirm_Finish.Size = New System.Drawing.Size(94, 29)
        Me.Comfirm_Finish.TabIndex = 22
        Me.Comfirm_Finish.Text = "Finish"
        Me.Comfirm_Finish.UseVisualStyleBackColor = True
        '
        'CharName
        '
        Me.CharName.AutoSize = True
        Me.CharName.Font = New System.Drawing.Font("Algerian", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CharName.Location = New System.Drawing.Point(271, 40)
        Me.CharName.Name = "CharName"
        Me.CharName.Size = New System.Drawing.Size(0, 20)
        Me.CharName.TabIndex = 23
        '
        'SkillPointsLabel
        '
        Me.SkillPointsLabel.AutoSize = True
        Me.SkillPointsLabel.Font = New System.Drawing.Font("Algerian", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SkillPointsLabel.Location = New System.Drawing.Point(476, 41)
        Me.SkillPointsLabel.Name = "SkillPointsLabel"
        Me.SkillPointsLabel.Size = New System.Drawing.Size(265, 19)
        Me.SkillPointsLabel.TabIndex = 24
        Me.SkillPointsLabel.Text = "You have 10 Skill Points left"
        '
        'PlayerLevelLabel
        '
        Me.PlayerLevelLabel.AutoSize = True
        Me.PlayerLevelLabel.Font = New System.Drawing.Font("Algerian", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PlayerLevelLabel.Location = New System.Drawing.Point(203, 366)
        Me.PlayerLevelLabel.Name = "PlayerLevelLabel"
        Me.PlayerLevelLabel.Size = New System.Drawing.Size(149, 19)
        Me.PlayerLevelLabel.TabIndex = 25
        Me.PlayerLevelLabel.Text = "You are Level 0"
        '
        'CharacterCreationScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BlueViolet
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(786, 447)
        Me.Controls.Add(Me.PlayerLevelLabel)
        Me.Controls.Add(Me.SkillPointsLabel)
        Me.Controls.Add(Me.CharName)
        Me.Controls.Add(Me.Comfirm_Finish)
        Me.Controls.Add(Me.Skills_Label)
        Me.Controls.Add(Me.LuckBar)
        Me.Controls.Add(Me.LuckButton)
        Me.Controls.Add(Me.DexterityBar)
        Me.Controls.Add(Me.DexterityButton)
        Me.Controls.Add(Me.IntellegenceBar)
        Me.Controls.Add(Me.IntellegenceButton)
        Me.Controls.Add(Me.StrengthBar)
        Me.Controls.Add(Me.StrengthStatButton)
        Me.Controls.Add(Me.MovementSpeedBar)
        Me.Controls.Add(Me.Movement)
        Me.Controls.Add(Me.Character_Trackbar_Label)
        Me.Controls.Add(Me.Character_TrackBar)
        Me.Controls.Add(Me.CharacterLabel)
        Me.Controls.Add(Me.CharSelectionPic)
        Me.Controls.Add(Me.Class_Warrior)
        Me.Controls.Add(Me.Class_Tank)
        Me.Controls.Add(Me.Class_Paladin)
        Me.Controls.Add(Me.Class_Hunter)
        Me.Controls.Add(Me.Class_Ranged)
        Me.Controls.Add(Me.ClassLabel)
        Me.Name = "CharacterCreationScreen"
        Me.Text = "CharacterCreationScreen"
        CType(Me.CharSelectionPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Character_TrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ClassLabel As Label
    Friend WithEvents Class_Ranged As Button
    Friend WithEvents Class_Hunter As Button
    Friend WithEvents Class_Paladin As Button
    Friend WithEvents Class_Tank As Button
    Friend WithEvents Class_Warrior As Button
    Friend WithEvents CharSelectionPic As PictureBox
    Friend WithEvents CharacterLabel As Label
    Friend WithEvents Character_TrackBar As TrackBar
    Friend WithEvents Character_Trackbar_Label As Label
    Friend WithEvents LuckBar As ProgressBar
    Friend WithEvents LuckButton As Button
    Friend WithEvents DexterityBar As ProgressBar
    Friend WithEvents DexterityButton As Button
    Friend WithEvents IntellegenceBar As ProgressBar
    Friend WithEvents IntellegenceButton As Button
    Friend WithEvents StrengthBar As ProgressBar
    Friend WithEvents StrengthStatButton As Button
    Friend WithEvents MovementSpeedBar As ProgressBar
    Friend WithEvents Movement As Button
    Friend WithEvents Skills_Label As Label
    Friend WithEvents Comfirm_Finish As Button
    Friend WithEvents CharName As Label
    Friend WithEvents SkillPoints As Label
    Friend WithEvents SkillPointsLabel As Label
    Friend WithEvents PlayerLevelLabel As Label
End Class
