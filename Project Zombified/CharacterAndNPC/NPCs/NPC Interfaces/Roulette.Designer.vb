<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Roulette
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
        Me.CollectWinnings = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.EvenBetAmount = New System.Windows.Forms.Label()
        Me.OddBetAmount = New System.Windows.Forms.Label()
        Me.RedBetAmount = New System.Windows.Forms.Label()
        Me.BlackBetAmount = New System.Windows.Forms.Label()
        Me.CoinBalance = New System.Windows.Forms.Label()
        Me.SpinNumber = New System.Windows.Forms.Label()
        Me.SpinColour = New System.Windows.Forms.Label()
        Me.REven = New System.Windows.Forms.Button()
        Me.ROdd = New System.Windows.Forms.Button()
        Me.RRed = New System.Windows.Forms.Button()
        Me.RBlack = New System.Windows.Forms.Button()
        Me.BetAmountLabel = New System.Windows.Forms.Label()
        Me.BetAmount = New System.Windows.Forms.TextBox()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.SpinWheel = New System.Windows.Forms.Button()
        Me.Deposit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CollectWinnings
        '
        Me.CollectWinnings.Enabled = False
        Me.CollectWinnings.Location = New System.Drawing.Point(716, 442)
        Me.CollectWinnings.Name = "CollectWinnings"
        Me.CollectWinnings.Size = New System.Drawing.Size(147, 29)
        Me.CollectWinnings.TabIndex = 38
        Me.CollectWinnings.Text = "Collect Winnings"
        Me.CollectWinnings.UseVisualStyleBackColor = True
        '
        'EvenBetAmount
        '
        Me.EvenBetAmount.AutoSize = True
        Me.EvenBetAmount.Location = New System.Drawing.Point(173, 412)
        Me.EvenBetAmount.Name = "EvenBetAmount"
        Me.EvenBetAmount.Size = New System.Drawing.Size(0, 20)
        Me.EvenBetAmount.TabIndex = 37
        '
        'OddBetAmount
        '
        Me.OddBetAmount.AutoSize = True
        Me.OddBetAmount.Location = New System.Drawing.Point(692, 412)
        Me.OddBetAmount.Name = "OddBetAmount"
        Me.OddBetAmount.Size = New System.Drawing.Size(0, 20)
        Me.OddBetAmount.TabIndex = 36
        '
        'RedBetAmount
        '
        Me.RedBetAmount.AutoSize = True
        Me.RedBetAmount.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RedBetAmount.Location = New System.Drawing.Point(319, 408)
        Me.RedBetAmount.Name = "RedBetAmount"
        Me.RedBetAmount.Size = New System.Drawing.Size(0, 20)
        Me.RedBetAmount.TabIndex = 35
        '
        'BlackBetAmount
        '
        Me.BlackBetAmount.AutoSize = True
        Me.BlackBetAmount.Location = New System.Drawing.Point(483, 408)
        Me.BlackBetAmount.Name = "BlackBetAmount"
        Me.BlackBetAmount.Size = New System.Drawing.Size(0, 20)
        Me.BlackBetAmount.TabIndex = 34
        '
        'CoinBalance
        '
        Me.CoinBalance.AutoSize = True
        Me.CoinBalance.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CoinBalance.Location = New System.Drawing.Point(41, 40)
        Me.CoinBalance.Name = "CoinBalance"
        Me.CoinBalance.Size = New System.Drawing.Size(0, 41)
        Me.CoinBalance.TabIndex = 33
        '
        'SpinNumber
        '
        Me.SpinNumber.AutoSize = True
        Me.SpinNumber.Font = New System.Drawing.Font("Comic Sans MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SpinNumber.ForeColor = System.Drawing.SystemColors.Control
        Me.SpinNumber.Location = New System.Drawing.Point(454, 9)
        Me.SpinNumber.Name = "SpinNumber"
        Me.SpinNumber.Size = New System.Drawing.Size(0, 31)
        Me.SpinNumber.TabIndex = 32
        '
        'SpinColour
        '
        Me.SpinColour.AutoSize = True
        Me.SpinColour.Location = New System.Drawing.Point(395, 17)
        Me.SpinColour.Name = "SpinColour"
        Me.SpinColour.Size = New System.Drawing.Size(0, 20)
        Me.SpinColour.TabIndex = 31
        '
        'REven
        '
        Me.REven.Location = New System.Drawing.Point(126, 380)
        Me.REven.Name = "REven"
        Me.REven.Size = New System.Drawing.Size(94, 29)
        Me.REven.TabIndex = 30
        Me.REven.Text = "Even"
        Me.REven.UseVisualStyleBackColor = True
        '
        'ROdd
        '
        Me.ROdd.Location = New System.Drawing.Point(642, 380)
        Me.ROdd.Name = "ROdd"
        Me.ROdd.Size = New System.Drawing.Size(94, 29)
        Me.ROdd.TabIndex = 29
        Me.ROdd.Text = "Odd"
        Me.ROdd.UseVisualStyleBackColor = True
        '
        'RRed
        '
        Me.RRed.Location = New System.Drawing.Point(278, 376)
        Me.RRed.Name = "RRed"
        Me.RRed.Size = New System.Drawing.Size(94, 29)
        Me.RRed.TabIndex = 28
        Me.RRed.Text = "Red"
        Me.RRed.UseVisualStyleBackColor = True
        '
        'RBlack
        '
        Me.RBlack.Location = New System.Drawing.Point(463, 376)
        Me.RBlack.Name = "RBlack"
        Me.RBlack.Size = New System.Drawing.Size(94, 29)
        Me.RBlack.TabIndex = 27
        Me.RBlack.Text = "Black"
        Me.RBlack.UseVisualStyleBackColor = True
        '
        'BetAmountLabel
        '
        Me.BetAmountLabel.AutoSize = True
        Me.BetAmountLabel.Location = New System.Drawing.Point(210, -1)
        Me.BetAmountLabel.Name = "BetAmountLabel"
        Me.BetAmountLabel.Size = New System.Drawing.Size(84, 20)
        Me.BetAmountLabel.TabIndex = 26
        Me.BetAmountLabel.Text = "BetAmount"
        '
        'BetAmount
        '
        Me.BetAmount.Location = New System.Drawing.Point(194, 22)
        Me.BetAmount.Name = "BetAmount"
        Me.BetAmount.Size = New System.Drawing.Size(125, 27)
        Me.BetAmount.TabIndex = 25
        '
        'SpinWheel
        '
        Me.SpinWheel.Location = New System.Drawing.Point(210, 55)
        Me.SpinWheel.Name = "SpinWheel"
        Me.SpinWheel.Size = New System.Drawing.Size(84, 29)
        Me.SpinWheel.TabIndex = 24
        Me.SpinWheel.Text = "Spin"
        Me.SpinWheel.UseVisualStyleBackColor = True
        '
        'Deposit
        '
        Me.Deposit.Location = New System.Drawing.Point(0, 8)
        Me.Deposit.Name = "Deposit"
        Me.Deposit.Size = New System.Drawing.Size(94, 29)
        Me.Deposit.TabIndex = 39
        Me.Deposit.Text = "Deposit"
        Me.Deposit.UseVisualStyleBackColor = True
        '
        'Roulette
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = Global.Project_Zombified.My.Resources.Resources.Roulette
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(875, 483)
        Me.Controls.Add(Me.Deposit)
        Me.Controls.Add(Me.CollectWinnings)
        Me.Controls.Add(Me.EvenBetAmount)
        Me.Controls.Add(Me.OddBetAmount)
        Me.Controls.Add(Me.RedBetAmount)
        Me.Controls.Add(Me.BlackBetAmount)
        Me.Controls.Add(Me.CoinBalance)
        Me.Controls.Add(Me.SpinNumber)
        Me.Controls.Add(Me.SpinColour)
        Me.Controls.Add(Me.REven)
        Me.Controls.Add(Me.ROdd)
        Me.Controls.Add(Me.RRed)
        Me.Controls.Add(Me.RBlack)
        Me.Controls.Add(Me.BetAmountLabel)
        Me.Controls.Add(Me.BetAmount)
        Me.Controls.Add(Me.SpinWheel)
        Me.Name = "Roulette"
        Me.Text = "Roulette"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CollectWinnings As Button
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents EvenBetAmount As Label
    Friend WithEvents OddBetAmount As Label
    Friend WithEvents RedBetAmount As Label
    Friend WithEvents BlackBetAmount As Label
    Friend WithEvents CoinBalance As Label
    Friend WithEvents SpinNumber As Label
    Friend WithEvents SpinColour As Label
    Friend WithEvents REven As Button
    Friend WithEvents ROdd As Button
    Friend WithEvents RRed As Button
    Friend WithEvents RBlack As Button
    Friend WithEvents BetAmountLabel As Label
    Friend WithEvents BetAmount As TextBox
    Friend WithEvents Timer3 As Timer
    Friend WithEvents SpinWheel As Button
    Friend WithEvents Deposit As Button
End Class
