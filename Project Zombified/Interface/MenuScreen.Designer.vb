<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuScreen))
        Me.Credit = New System.Windows.Forms.Button()
        Me.Tutorial = New System.Windows.Forms.Button()
        Me.LoadGame = New System.Windows.Forms.Button()
        Me.NewGame = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Credit
        '
        Me.Credit.Location = New System.Drawing.Point(334, 268)
        Me.Credit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Credit.Name = "Credit"
        Me.Credit.Size = New System.Drawing.Size(119, 58)
        Me.Credit.TabIndex = 11
        Me.Credit.Text = "Credits"
        Me.Credit.UseVisualStyleBackColor = True
        '
        'Tutorial
        '
        Me.Tutorial.Location = New System.Drawing.Point(251, 172)
        Me.Tutorial.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Tutorial.Name = "Tutorial"
        Me.Tutorial.Size = New System.Drawing.Size(299, 38)
        Me.Tutorial.TabIndex = 10
        Me.Tutorial.Text = "Map Editor"
        Me.Tutorial.UseVisualStyleBackColor = True
        '
        'LoadGame
        '
        Me.LoadGame.Location = New System.Drawing.Point(251, 220)
        Me.LoadGame.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LoadGame.Name = "LoadGame"
        Me.LoadGame.Size = New System.Drawing.Size(299, 38)
        Me.LoadGame.TabIndex = 9
        Me.LoadGame.Text = "Load Game"
        Me.LoadGame.UseVisualStyleBackColor = True
        '
        'NewGame
        '
        Me.NewGame.Location = New System.Drawing.Point(251, 125)
        Me.NewGame.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NewGame.Name = "NewGame"
        Me.NewGame.Size = New System.Drawing.Size(299, 38)
        Me.NewGame.TabIndex = 8
        Me.NewGame.Text = "Start New Game"
        Me.NewGame.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1067, 517)
        Me.Controls.Add(Me.Credit)
        Me.Controls.Add(Me.Tutorial)
        Me.Controls.Add(Me.LoadGame)
        Me.Controls.Add(Me.NewGame)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Credit As Button
    Friend WithEvents Tutorial As Button
    Friend WithEvents LoadGame As Button
    Friend WithEvents NewGame As Button
End Class
