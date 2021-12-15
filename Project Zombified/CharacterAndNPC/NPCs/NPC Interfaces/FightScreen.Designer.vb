<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FightScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FightScreen))
        Me.FightButton = New System.Windows.Forms.Button()
        Me.BagButton = New System.Windows.Forms.Button()
        Me.RunButton = New System.Windows.Forms.Button()
        Me.EnemyName = New System.Windows.Forms.Label()
        Me.DecisionLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.EnemyHealth = New System.Windows.Forms.ProgressBar()
        Me.PlayerHealth = New System.Windows.Forms.ProgressBar()
        Me.PlayerHealthLabel = New System.Windows.Forms.Label()
        Me.EnemyHealthLabel = New System.Windows.Forms.Label()
        Me.RangedAttack = New System.Windows.Forms.Button()
        Me.ConfusionMove = New System.Windows.Forms.Button()
        Me.StrongMelee = New System.Windows.Forms.Button()
        Me.MeleeAttack = New System.Windows.Forms.Button()
        Me.EnemyMoveLabel = New System.Windows.Forms.Label()
        Me.PlayerMoves = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FightButton
        '
        Me.FightButton.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FightButton.Location = New System.Drawing.Point(550, 424)
        Me.FightButton.Name = "FightButton"
        Me.FightButton.Size = New System.Drawing.Size(122, 49)
        Me.FightButton.TabIndex = 0
        Me.FightButton.Text = "Fight"
        Me.FightButton.UseVisualStyleBackColor = True
        '
        'BagButton
        '
        Me.BagButton.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BagButton.Location = New System.Drawing.Point(678, 394)
        Me.BagButton.Name = "BagButton"
        Me.BagButton.Size = New System.Drawing.Size(122, 49)
        Me.BagButton.TabIndex = 1
        Me.BagButton.Text = "Bag"
        Me.BagButton.UseVisualStyleBackColor = True
        '
        'RunButton
        '
        Me.RunButton.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RunButton.Location = New System.Drawing.Point(678, 449)
        Me.RunButton.Name = "RunButton"
        Me.RunButton.Size = New System.Drawing.Size(122, 49)
        Me.RunButton.TabIndex = 3
        Me.RunButton.Text = "Run"
        Me.RunButton.UseVisualStyleBackColor = True
        '
        'EnemyName
        '
        Me.EnemyName.AutoSize = True
        Me.EnemyName.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.EnemyName.Location = New System.Drawing.Point(550, 282)
        Me.EnemyName.Name = "EnemyName"
        Me.EnemyName.Size = New System.Drawing.Size(83, 29)
        Me.EnemyName.TabIndex = 4
        Me.EnemyName.Text = "Zombie"
        '
        'DecisionLabel
        '
        Me.DecisionLabel.AutoSize = True
        Me.DecisionLabel.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DecisionLabel.Location = New System.Drawing.Point(596, 367)
        Me.DecisionLabel.Name = "DecisionLabel"
        Me.DecisionLabel.Size = New System.Drawing.Size(172, 24)
        Me.DecisionLabel.TabIndex = 5
        Me.DecisionLabel.Text = "What you gonna do?"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Project_Zombified.My.Resources.Resources.MageBattleScreenEnemy
        Me.PictureBox1.Location = New System.Drawing.Point(596, 76)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(160, 192)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(150, 360)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(160, 192)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'EnemyHealth
        '
        Me.EnemyHealth.Location = New System.Drawing.Point(596, 250)
        Me.EnemyHealth.Maximum = 120
        Me.EnemyHealth.Name = "EnemyHealth"
        Me.EnemyHealth.Size = New System.Drawing.Size(160, 29)
        Me.EnemyHealth.TabIndex = 8
        '
        'PlayerHealth
        '
        Me.PlayerHealth.Location = New System.Drawing.Point(316, 482)
        Me.PlayerHealth.Maximum = 120
        Me.PlayerHealth.Name = "PlayerHealth"
        Me.PlayerHealth.Size = New System.Drawing.Size(160, 29)
        Me.PlayerHealth.TabIndex = 9
        '
        'PlayerHealthLabel
        '
        Me.PlayerHealthLabel.AutoSize = True
        Me.PlayerHealthLabel.Font = New System.Drawing.Font("Lucida Bright", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PlayerHealthLabel.Location = New System.Drawing.Point(364, 482)
        Me.PlayerHealthLabel.Name = "PlayerHealthLabel"
        Me.PlayerHealthLabel.Size = New System.Drawing.Size(42, 20)
        Me.PlayerHealthLabel.TabIndex = 10
        Me.PlayerHealthLabel.Text = "120"
        '
        'EnemyHealthLabel
        '
        Me.EnemyHealthLabel.AutoSize = True
        Me.EnemyHealthLabel.Font = New System.Drawing.Font("Lucida Bright", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.EnemyHealthLabel.Location = New System.Drawing.Point(641, 250)
        Me.EnemyHealthLabel.Name = "EnemyHealthLabel"
        Me.EnemyHealthLabel.Size = New System.Drawing.Size(42, 20)
        Me.EnemyHealthLabel.TabIndex = 11
        Me.EnemyHealthLabel.Text = "120"
        '
        'RangedAttack
        '
        Me.RangedAttack.Location = New System.Drawing.Point(550, 394)
        Me.RangedAttack.Name = "RangedAttack"
        Me.RangedAttack.Size = New System.Drawing.Size(122, 49)
        Me.RangedAttack.TabIndex = 12
        Me.RangedAttack.Text = "Gliz Shot"
        Me.RangedAttack.UseVisualStyleBackColor = True
        Me.RangedAttack.Visible = False
        '
        'ConfusionMove
        '
        Me.ConfusionMove.Location = New System.Drawing.Point(550, 449)
        Me.ConfusionMove.Name = "ConfusionMove"
        Me.ConfusionMove.Size = New System.Drawing.Size(122, 49)
        Me.ConfusionMove.TabIndex = 13
        Me.ConfusionMove.Text = "Buss a move"
        Me.ConfusionMove.UseVisualStyleBackColor = True
        Me.ConfusionMove.Visible = False
        '
        'StrongMelee
        '
        Me.StrongMelee.Location = New System.Drawing.Point(678, 394)
        Me.StrongMelee.Name = "StrongMelee"
        Me.StrongMelee.Size = New System.Drawing.Size(122, 49)
        Me.StrongMelee.TabIndex = 14
        Me.StrongMelee.Text = "Robo Backhand"
        Me.StrongMelee.UseVisualStyleBackColor = True
        Me.StrongMelee.Visible = False
        '
        'MeleeAttack
        '
        Me.MeleeAttack.Location = New System.Drawing.Point(678, 449)
        Me.MeleeAttack.Name = "MeleeAttack"
        Me.MeleeAttack.Size = New System.Drawing.Size(122, 49)
        Me.MeleeAttack.TabIndex = 15
        Me.MeleeAttack.Text = "Slice"
        Me.MeleeAttack.UseVisualStyleBackColor = True
        Me.MeleeAttack.Visible = False
        '
        'EnemyMoveLabel
        '
        Me.EnemyMoveLabel.AutoSize = True
        Me.EnemyMoveLabel.Location = New System.Drawing.Point(423, 76)
        Me.EnemyMoveLabel.Name = "EnemyMoveLabel"
        Me.EnemyMoveLabel.Size = New System.Drawing.Size(53, 20)
        Me.EnemyMoveLabel.TabIndex = 16
        Me.EnemyMoveLabel.Text = "Label1"
        Me.EnemyMoveLabel.Visible = False
        '
        'PlayerMoves
        '
        Me.PlayerMoves.AutoSize = True
        Me.PlayerMoves.Location = New System.Drawing.Point(138, 337)
        Me.PlayerMoves.Name = "PlayerMoves"
        Me.PlayerMoves.Size = New System.Drawing.Size(0, 20)
        Me.PlayerMoves.TabIndex = 17
        '
        'FightScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Project_Zombified.My.Resources.Resources.BattleScreen
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(856, 573)
        Me.Controls.Add(Me.PlayerMoves)
        Me.Controls.Add(Me.EnemyMoveLabel)
        Me.Controls.Add(Me.MeleeAttack)
        Me.Controls.Add(Me.StrongMelee)
        Me.Controls.Add(Me.ConfusionMove)
        Me.Controls.Add(Me.RangedAttack)
        Me.Controls.Add(Me.EnemyHealthLabel)
        Me.Controls.Add(Me.PlayerHealthLabel)
        Me.Controls.Add(Me.PlayerHealth)
        Me.Controls.Add(Me.EnemyHealth)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DecisionLabel)
        Me.Controls.Add(Me.EnemyName)
        Me.Controls.Add(Me.RunButton)
        Me.Controls.Add(Me.BagButton)
        Me.Controls.Add(Me.FightButton)
        Me.DoubleBuffered = True
        Me.Name = "FightScreen"
        Me.Text = "FightScreen"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FightButton As Button
    Friend WithEvents BagButton As Button
    Friend WithEvents RunButton As Button
    Friend WithEvents EnemyName As Label
    Friend WithEvents DecisionLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents EnemyHealth As ProgressBar
    Friend WithEvents PlayerHealth As ProgressBar
    Friend WithEvents PlayerHealthLabel As Label
    Friend WithEvents EnemyHealthLabel As Label
    Friend WithEvents RangedAttack As Button
    Friend WithEvents ConfusionMove As Button
    Friend WithEvents StrongMelee As Button
    Friend WithEvents MeleeAttack As Button
    Friend WithEvents EnemyMoveLabel As Label
    Friend WithEvents PlayerMoves As Label
End Class
