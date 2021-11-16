<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KingsleyInterface
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BuyButton = New System.Windows.Forms.Button()
        Me.SellButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(-2, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(641, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hi there, welcome to my store please have a look at my supplies"
        '
        'BuyButton
        '
        Me.BuyButton.BackColor = System.Drawing.Color.Chocolate
        Me.BuyButton.Location = New System.Drawing.Point(298, 159)
        Me.BuyButton.Name = "BuyButton"
        Me.BuyButton.Size = New System.Drawing.Size(138, 29)
        Me.BuyButton.TabIndex = 1
        Me.BuyButton.Text = "Buy Items"
        Me.BuyButton.UseVisualStyleBackColor = False
        '
        'SellButton
        '
        Me.SellButton.BackColor = System.Drawing.Color.Chocolate
        Me.SellButton.Location = New System.Drawing.Point(298, 194)
        Me.SellButton.Name = "SellButton"
        Me.SellButton.Size = New System.Drawing.Size(138, 29)
        Me.SellButton.TabIndex = 2
        Me.SellButton.Text = "Sell Items"
        Me.SellButton.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Chocolate
        Me.Button1.Location = New System.Drawing.Point(298, 229)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(164, 29)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Ask about Zombies"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'KingsleyInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Project_Zombified.My.Resources.Resources.KingsleyStoreBackground
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.SellButton)
        Me.Controls.Add(Me.BuyButton)
        Me.Controls.Add(Me.Label1)
        Me.Name = "KingsleyInterface"
        Me.Text = "KingsleyInterface"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BuyButton As Button
    Friend WithEvents SellButton As Button
    Friend WithEvents Button1 As Button
End Class
