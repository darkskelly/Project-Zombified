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
        Me.FightButton = New System.Windows.Forms.Button()
        Me.BagButton = New System.Windows.Forms.Button()
        Me.RunButton = New System.Windows.Forms.Button()
        Me.EnemyName = New System.Windows.Forms.Label()
        Me.DecisionLabel = New System.Windows.Forms.Label()
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
        'FightScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 573)
        Me.Controls.Add(Me.DecisionLabel)
        Me.Controls.Add(Me.EnemyName)
        Me.Controls.Add(Me.RunButton)
        Me.Controls.Add(Me.BagButton)
        Me.Controls.Add(Me.FightButton)
        Me.Name = "FightScreen"
        Me.Text = "FightScreen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FightButton As Button
    Friend WithEvents BagButton As Button
    Friend WithEvents RunButton As Button
    Friend WithEvents EnemyName As Label
    Friend WithEvents DecisionLabel As Label
End Class
