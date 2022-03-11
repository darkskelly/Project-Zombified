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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KingsleyInterface))
        Me.KingsleyLabel = New System.Windows.Forms.Label()
        Me.BuyButton = New System.Windows.Forms.Button()
        Me.SellButton = New System.Windows.Forms.Button()
        Me.BackstoryButton = New System.Windows.Forms.Button()
        Me.BuyWoodenChest = New System.Windows.Forms.Button()
        Me.BuyWoodenLegs = New System.Windows.Forms.Button()
        Me.BuyWoodenShoes = New System.Windows.Forms.Button()
        Me.BuyWoodenHelmet = New System.Windows.Forms.Button()
        Me.SellWood = New System.Windows.Forms.Button()
        Me.SellStone = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'KingsleyLabel
        '
        Me.KingsleyLabel.AutoSize = True
        Me.KingsleyLabel.Font = New System.Drawing.Font("Algerian", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.KingsleyLabel.Location = New System.Drawing.Point(12, 419)
        Me.KingsleyLabel.Name = "KingsleyLabel"
        Me.KingsleyLabel.Size = New System.Drawing.Size(752, 22)
        Me.KingsleyLabel.TabIndex = 0
        Me.KingsleyLabel.Text = "Hi there, welcome to my store please have a look at my supplies"
        Me.KingsleyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'BackstoryButton
        '
        Me.BackstoryButton.BackColor = System.Drawing.Color.Chocolate
        Me.BackstoryButton.Location = New System.Drawing.Point(293, 229)
        Me.BackstoryButton.Name = "BackstoryButton"
        Me.BackstoryButton.Size = New System.Drawing.Size(164, 29)
        Me.BackstoryButton.TabIndex = 3
        Me.BackstoryButton.Text = "Ask about Zombies"
        Me.BackstoryButton.UseVisualStyleBackColor = False
        '
        'BuyWoodenChest
        '
        Me.BuyWoodenChest.BackgroundImage = Global.Project_Zombified.My.Resources.Resources.WoodChestInv
        Me.BuyWoodenChest.Location = New System.Drawing.Point(314, 176)
        Me.BuyWoodenChest.Name = "BuyWoodenChest"
        Me.BuyWoodenChest.Size = New System.Drawing.Size(64, 64)
        Me.BuyWoodenChest.TabIndex = 5
        Me.BuyWoodenChest.UseVisualStyleBackColor = True
        Me.BuyWoodenChest.Visible = False
        '
        'BuyWoodenLegs
        '
        Me.BuyWoodenLegs.BackgroundImage = Global.Project_Zombified.My.Resources.Resources.WoodGlovesInv
        Me.BuyWoodenLegs.Location = New System.Drawing.Point(384, 176)
        Me.BuyWoodenLegs.Name = "BuyWoodenLegs"
        Me.BuyWoodenLegs.Size = New System.Drawing.Size(64, 64)
        Me.BuyWoodenLegs.TabIndex = 6
        Me.BuyWoodenLegs.UseVisualStyleBackColor = True
        Me.BuyWoodenLegs.Visible = False
        '
        'BuyWoodenShoes
        '
        Me.BuyWoodenShoes.BackgroundImage = Global.Project_Zombified.My.Resources.Resources.WoodShoesInv
        Me.BuyWoodenShoes.Location = New System.Drawing.Point(454, 176)
        Me.BuyWoodenShoes.Name = "BuyWoodenShoes"
        Me.BuyWoodenShoes.Size = New System.Drawing.Size(64, 64)
        Me.BuyWoodenShoes.TabIndex = 7
        Me.BuyWoodenShoes.UseVisualStyleBackColor = True
        Me.BuyWoodenShoes.Visible = False
        '
        'BuyWoodenHelmet
        '
        Me.BuyWoodenHelmet.BackgroundImage = Global.Project_Zombified.My.Resources.Resources.WoodHelmInv
        Me.BuyWoodenHelmet.Location = New System.Drawing.Point(244, 176)
        Me.BuyWoodenHelmet.Name = "BuyWoodenHelmet"
        Me.BuyWoodenHelmet.Size = New System.Drawing.Size(64, 64)
        Me.BuyWoodenHelmet.TabIndex = 4
        Me.BuyWoodenHelmet.UseVisualStyleBackColor = True
        Me.BuyWoodenHelmet.Visible = False
        '
        'SellWood
        '
        Me.SellWood.BackColor = System.Drawing.Color.Transparent
        Me.SellWood.BackgroundImage = Global.Project_Zombified.My.Resources.Resources.Wood
        Me.SellWood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SellWood.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SellWood.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.SellWood.Location = New System.Drawing.Point(298, 264)
        Me.SellWood.Name = "SellWood"
        Me.SellWood.Size = New System.Drawing.Size(64, 64)
        Me.SellWood.TabIndex = 8
        Me.SellWood.UseVisualStyleBackColor = False
        Me.SellWood.Visible = False
        '
        'SellStone
        '
        Me.SellStone.BackColor = System.Drawing.Color.Transparent
        Me.SellStone.BackgroundImage = CType(resources.GetObject("SellStone.BackgroundImage"), System.Drawing.Image)
        Me.SellStone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SellStone.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SellStone.Location = New System.Drawing.Point(393, 264)
        Me.SellStone.Name = "SellStone"
        Me.SellStone.Size = New System.Drawing.Size(64, 64)
        Me.SellStone.TabIndex = 9
        Me.SellStone.UseVisualStyleBackColor = False
        Me.SellStone.Visible = False
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.Chocolate
        Me.BackButton.Location = New System.Drawing.Point(626, 374)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(138, 29)
        Me.BackButton.TabIndex = 10
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = False
        Me.BackButton.Visible = False
        '
        'KingsleyInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Project_Zombified.My.Resources.Resources.KingsleyStoreBackground
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.SellStone)
        Me.Controls.Add(Me.SellWood)
        Me.Controls.Add(Me.BuyWoodenShoes)
        Me.Controls.Add(Me.BuyWoodenLegs)
        Me.Controls.Add(Me.BuyWoodenChest)
        Me.Controls.Add(Me.BuyWoodenHelmet)
        Me.Controls.Add(Me.BackstoryButton)
        Me.Controls.Add(Me.SellButton)
        Me.Controls.Add(Me.BuyButton)
        Me.Controls.Add(Me.KingsleyLabel)
        Me.Name = "KingsleyInterface"
        Me.Text = "KingsleyInterface"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents KingsleyLabel As Label
    Friend WithEvents BuyButton As Button
    Friend WithEvents SellButton As Button
    Friend WithEvents BackstoryButton As Button
    Friend WithEvents BuyWoodenChest As Button
    Friend WithEvents BuyWoodenLegs As Button
    Friend WithEvents BuyWoodenShoes As Button
    Friend WithEvents BuyWoodenHelmet As Button
    Friend WithEvents SellWood As Button
    Friend WithEvents SellStone As Button
    Friend WithEvents BackButton As Button
End Class
