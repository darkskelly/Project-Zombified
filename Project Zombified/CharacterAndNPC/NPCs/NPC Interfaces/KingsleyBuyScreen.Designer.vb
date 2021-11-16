<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KingsleyBuyScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KingsleyBuyScreen))
        Me.BuySword = New System.Windows.Forms.Button()
        Me.BuyHealthPot = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BuySword
        '
        Me.BuySword.Image = CType(resources.GetObject("BuySword.Image"), System.Drawing.Image)
        Me.BuySword.Location = New System.Drawing.Point(39, 37)
        Me.BuySword.Name = "BuySword"
        Me.BuySword.Size = New System.Drawing.Size(33, 36)
        Me.BuySword.TabIndex = 0
        Me.BuySword.UseVisualStyleBackColor = True
        '
        'BuyHealthPot
        '
        Me.BuyHealthPot.Image = CType(resources.GetObject("BuyHealthPot.Image"), System.Drawing.Image)
        Me.BuyHealthPot.Location = New System.Drawing.Point(78, 37)
        Me.BuyHealthPot.Name = "BuyHealthPot"
        Me.BuyHealthPot.Size = New System.Drawing.Size(33, 36)
        Me.BuyHealthPot.TabIndex = 1
        Me.BuyHealthPot.UseVisualStyleBackColor = True
        '
        'KingsleyBuyScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BuyHealthPot)
        Me.Controls.Add(Me.BuySword)
        Me.Name = "KingsleyBuyScreen"
        Me.Text = "KingsleyBuyScreen"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BuySword As Button
    Friend WithEvents BuyHealthPot As Button
End Class
