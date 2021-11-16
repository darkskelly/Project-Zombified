<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CharacterCreation
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
        Me.Movement = New System.Windows.Forms.Button()
        Me.MovementSpeedBar = New System.Windows.Forms.ProgressBar()
        Me.StrengthBar = New System.Windows.Forms.ProgressBar()
        Me.StrengthStatButton = New System.Windows.Forms.Button()
        Me.IntellegenceBar = New System.Windows.Forms.ProgressBar()
        Me.IntellegenceButton = New System.Windows.Forms.Button()
        Me.DexterityBar = New System.Windows.Forms.ProgressBar()
        Me.DexterityButton = New System.Windows.Forms.Button()
        Me.LuckBar = New System.Windows.Forms.ProgressBar()
        Me.LuckButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Movement
        '
        Me.Movement.Location = New System.Drawing.Point(12, 25)
        Me.Movement.Name = "Movement"
        Me.Movement.Size = New System.Drawing.Size(157, 52)
        Me.Movement.TabIndex = 0
        Me.Movement.Text = "Movement Speed"
        Me.Movement.UseVisualStyleBackColor = True
        '
        'MovementSpeedBar
        '
        Me.MovementSpeedBar.BackColor = System.Drawing.SystemColors.MenuText
        Me.MovementSpeedBar.Location = New System.Drawing.Point(198, 25)
        Me.MovementSpeedBar.Name = "MovementSpeedBar"
        Me.MovementSpeedBar.Size = New System.Drawing.Size(143, 52)
        Me.MovementSpeedBar.TabIndex = 1
        '
        'StrengthBar
        '
        Me.StrengthBar.BackColor = System.Drawing.SystemColors.MenuText
        Me.StrengthBar.Location = New System.Drawing.Point(198, 101)
        Me.StrengthBar.Name = "StrengthBar"
        Me.StrengthBar.Size = New System.Drawing.Size(143, 52)
        Me.StrengthBar.TabIndex = 3
        '
        'StrengthStatButton
        '
        Me.StrengthStatButton.Location = New System.Drawing.Point(12, 101)
        Me.StrengthStatButton.Name = "StrengthStatButton"
        Me.StrengthStatButton.Size = New System.Drawing.Size(157, 52)
        Me.StrengthStatButton.TabIndex = 2
        Me.StrengthStatButton.Text = "Strength"
        Me.StrengthStatButton.UseVisualStyleBackColor = True
        '
        'IntellegenceBar
        '
        Me.IntellegenceBar.BackColor = System.Drawing.SystemColors.MenuText
        Me.IntellegenceBar.Location = New System.Drawing.Point(198, 179)
        Me.IntellegenceBar.Name = "IntellegenceBar"
        Me.IntellegenceBar.Size = New System.Drawing.Size(143, 52)
        Me.IntellegenceBar.TabIndex = 5
        '
        'IntellegenceButton
        '
        Me.IntellegenceButton.Location = New System.Drawing.Point(12, 179)
        Me.IntellegenceButton.Name = "IntellegenceButton"
        Me.IntellegenceButton.Size = New System.Drawing.Size(157, 52)
        Me.IntellegenceButton.TabIndex = 4
        Me.IntellegenceButton.Text = "Intellegence"
        Me.IntellegenceButton.UseVisualStyleBackColor = True
        '
        'DexterityBar
        '
        Me.DexterityBar.BackColor = System.Drawing.SystemColors.MenuText
        Me.DexterityBar.Location = New System.Drawing.Point(198, 255)
        Me.DexterityBar.Name = "DexterityBar"
        Me.DexterityBar.Size = New System.Drawing.Size(143, 52)
        Me.DexterityBar.TabIndex = 7
        '
        'DexterityButton
        '
        Me.DexterityButton.Location = New System.Drawing.Point(12, 255)
        Me.DexterityButton.Name = "DexterityButton"
        Me.DexterityButton.Size = New System.Drawing.Size(157, 52)
        Me.DexterityButton.TabIndex = 6
        Me.DexterityButton.Text = "Dexterity"
        Me.DexterityButton.UseVisualStyleBackColor = True
        '
        'LuckBar
        '
        Me.LuckBar.BackColor = System.Drawing.SystemColors.MenuText
        Me.LuckBar.Location = New System.Drawing.Point(198, 332)
        Me.LuckBar.Name = "LuckBar"
        Me.LuckBar.Size = New System.Drawing.Size(143, 52)
        Me.LuckBar.TabIndex = 9
        '
        'LuckButton
        '
        Me.LuckButton.Location = New System.Drawing.Point(12, 332)
        Me.LuckButton.Name = "LuckButton"
        Me.LuckButton.Size = New System.Drawing.Size(157, 52)
        Me.LuckButton.TabIndex = 8
        Me.LuckButton.Text = "Luck"
        Me.LuckButton.UseVisualStyleBackColor = True
        '
        'CharacterCreation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 553)
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
        Me.Name = "CharacterCreation"
        Me.Text = "CharacterCreation"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Movement As Button
    Friend WithEvents MovementSpeedBar As ProgressBar
    Friend WithEvents StrengthBar As ProgressBar
    Friend WithEvents StrengthStatButton As Button
    Friend WithEvents IntellegenceBar As ProgressBar
    Friend WithEvents IntellegenceButton As Button
    Friend WithEvents DexterityBar As ProgressBar
    Friend WithEvents DexterityButton As Button
    Friend WithEvents LuckBar As ProgressBar
    Friend WithEvents LuckButton As Button
End Class
