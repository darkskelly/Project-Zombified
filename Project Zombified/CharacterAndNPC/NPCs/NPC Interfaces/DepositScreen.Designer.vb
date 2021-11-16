<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DepositScreen
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
        Me.DepositStone = New System.Windows.Forms.Button()
        Me.DepositWood = New System.Windows.Forms.Button()
        Me.AmountOfStone = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.WoodPic = New System.Windows.Forms.PictureBox()
        Me.WoodAmount = New System.Windows.Forms.Label()
        Me.PriceKey = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BalanceLabel = New System.Windows.Forms.Label()
        Me.Balance = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WoodPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DepositStone
        '
        Me.DepositStone.Location = New System.Drawing.Point(45, 162)
        Me.DepositStone.Name = "DepositStone"
        Me.DepositStone.Size = New System.Drawing.Size(135, 29)
        Me.DepositStone.TabIndex = 0
        Me.DepositStone.Text = "Deposit 1 Stone"
        Me.DepositStone.UseVisualStyleBackColor = True
        '
        'DepositWood
        '
        Me.DepositWood.Location = New System.Drawing.Point(204, 162)
        Me.DepositWood.Name = "DepositWood"
        Me.DepositWood.Size = New System.Drawing.Size(129, 29)
        Me.DepositWood.TabIndex = 1
        Me.DepositWood.Text = "Deposit 1 Wood"
        Me.DepositWood.UseVisualStyleBackColor = True
        '
        'AmountOfStone
        '
        Me.AmountOfStone.AutoSize = True
        Me.AmountOfStone.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.AmountOfStone.Location = New System.Drawing.Point(94, 75)
        Me.AmountOfStone.Name = "AmountOfStone"
        Me.AmountOfStone.Size = New System.Drawing.Size(0, 31)
        Me.AmountOfStone.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Project_Zombified.My.Resources.Resources.Stone
        Me.PictureBox1.Location = New System.Drawing.Point(117, 122)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(31, 34)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'WoodPic
        '
        Me.WoodPic.Image = Global.Project_Zombified.My.Resources.Resources.Wood
        Me.WoodPic.Location = New System.Drawing.Point(258, 122)
        Me.WoodPic.Name = "WoodPic"
        Me.WoodPic.Size = New System.Drawing.Size(31, 34)
        Me.WoodPic.TabIndex = 7
        Me.WoodPic.TabStop = False
        '
        'WoodAmount
        '
        Me.WoodAmount.AutoSize = True
        Me.WoodAmount.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.WoodAmount.Location = New System.Drawing.Point(244, 88)
        Me.WoodAmount.Name = "WoodAmount"
        Me.WoodAmount.Size = New System.Drawing.Size(0, 31)
        Me.WoodAmount.TabIndex = 6
        '
        'PriceKey
        '
        Me.PriceKey.AutoSize = True
        Me.PriceKey.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PriceKey.Location = New System.Drawing.Point(12, 231)
        Me.PriceKey.Name = "PriceKey"
        Me.PriceKey.Size = New System.Drawing.Size(116, 31)
        Me.PriceKey.TabIndex = 8
        Me.PriceKey.Text = "Stone - 25"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(12, 272)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 31)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Wood - 25"
        '
        'BalanceLabel
        '
        Me.BalanceLabel.AutoSize = True
        Me.BalanceLabel.Location = New System.Drawing.Point(12, 9)
        Me.BalanceLabel.Name = "BalanceLabel"
        Me.BalanceLabel.Size = New System.Drawing.Size(61, 20)
        Me.BalanceLabel.TabIndex = 10
        Me.BalanceLabel.Text = "Balance"
        '
        'Balance
        '
        Me.Balance.AutoSize = True
        Me.Balance.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Balance.Location = New System.Drawing.Point(12, 29)
        Me.Balance.Name = "Balance"
        Me.Balance.Size = New System.Drawing.Size(0, 31)
        Me.Balance.TabIndex = 11
        '
        'DepositScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Balance)
        Me.Controls.Add(Me.BalanceLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PriceKey)
        Me.Controls.Add(Me.WoodPic)
        Me.Controls.Add(Me.WoodAmount)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.AmountOfStone)
        Me.Controls.Add(Me.DepositWood)
        Me.Controls.Add(Me.DepositStone)
        Me.Name = "DepositScreen"
        Me.Text = "DepositScreen"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WoodPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DepositStone As Button
    Friend WithEvents DepositWood As Button
    Friend WithEvents AmountOfStone As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents WoodPic As PictureBox
    Friend WithEvents WoodAmount As Label
    Friend WithEvents PriceKey As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BalanceLabel As Label
    Friend WithEvents Balance As Label
End Class
