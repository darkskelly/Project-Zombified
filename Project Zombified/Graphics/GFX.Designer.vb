<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GFX
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GFX))
        Me.pbGFX = New System.Windows.Forms.PictureBox()
        Me.PaladinGFX = New System.Windows.Forms.PictureBox()
        Me.KingsleyGFX = New System.Windows.Forms.PictureBox()
        Me.WarriorGFX = New System.Windows.Forms.PictureBox()
        Me.PrincessGFX = New System.Windows.Forms.PictureBox()
        Me.MageGFX = New System.Windows.Forms.PictureBox()
        Me.ItemsGraphics = New System.Windows.Forms.PictureBox()
        Me.InventoryScreen = New System.Windows.Forms.PictureBox()
        Me.StonePB = New System.Windows.Forms.PictureBox()
        Me.GUI = New System.Windows.Forms.PictureBox()
        CType(Me.pbGFX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaladinGFX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KingsleyGFX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WarriorGFX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrincessGFX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MageGFX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemsGraphics, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StonePB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GUI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbGFX
        '
        Me.pbGFX.BackgroundImage = CType(resources.GetObject("pbGFX.BackgroundImage"), System.Drawing.Image)
        Me.pbGFX.ErrorImage = CType(resources.GetObject("pbGFX.ErrorImage"), System.Drawing.Image)
        Me.pbGFX.InitialImage = CType(resources.GetObject("pbGFX.InitialImage"), System.Drawing.Image)
        Me.pbGFX.Location = New System.Drawing.Point(-1, 3)
        Me.pbGFX.Name = "pbGFX"
        Me.pbGFX.Size = New System.Drawing.Size(317, 268)
        Me.pbGFX.TabIndex = 0
        Me.pbGFX.TabStop = False
        '
        'PaladinGFX
        '
        Me.PaladinGFX.BackgroundImage = CType(resources.GetObject("PaladinGFX.BackgroundImage"), System.Drawing.Image)
        Me.PaladinGFX.Location = New System.Drawing.Point(432, 339)
        Me.PaladinGFX.Name = "PaladinGFX"
        Me.PaladinGFX.Size = New System.Drawing.Size(32, 32)
        Me.PaladinGFX.TabIndex = 1
        Me.PaladinGFX.TabStop = False
        '
        'KingsleyGFX
        '
        Me.KingsleyGFX.BackgroundImage = CType(resources.GetObject("KingsleyGFX.BackgroundImage"), System.Drawing.Image)
        Me.KingsleyGFX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.KingsleyGFX.Location = New System.Drawing.Point(464, 277)
        Me.KingsleyGFX.Name = "KingsleyGFX"
        Me.KingsleyGFX.Size = New System.Drawing.Size(32, 32)
        Me.KingsleyGFX.TabIndex = 2
        Me.KingsleyGFX.TabStop = False
        '
        'WarriorGFX
        '
        Me.WarriorGFX.BackgroundImage = CType(resources.GetObject("WarriorGFX.BackgroundImage"), System.Drawing.Image)
        Me.WarriorGFX.Image = CType(resources.GetObject("WarriorGFX.Image"), System.Drawing.Image)
        Me.WarriorGFX.Location = New System.Drawing.Point(470, 339)
        Me.WarriorGFX.Name = "WarriorGFX"
        Me.WarriorGFX.Size = New System.Drawing.Size(31, 34)
        Me.WarriorGFX.TabIndex = 3
        Me.WarriorGFX.TabStop = False
        '
        'PrincessGFX
        '
        Me.PrincessGFX.BackgroundImage = CType(resources.GetObject("PrincessGFX.BackgroundImage"), System.Drawing.Image)
        Me.PrincessGFX.Image = CType(resources.GetObject("PrincessGFX.Image"), System.Drawing.Image)
        Me.PrincessGFX.Location = New System.Drawing.Point(394, 337)
        Me.PrincessGFX.Name = "PrincessGFX"
        Me.PrincessGFX.Size = New System.Drawing.Size(32, 32)
        Me.PrincessGFX.TabIndex = 4
        Me.PrincessGFX.TabStop = False
        '
        'MageGFX
        '
        Me.MageGFX.BackgroundImage = CType(resources.GetObject("MageGFX.BackgroundImage"), System.Drawing.Image)
        Me.MageGFX.Image = CType(resources.GetObject("MageGFX.Image"), System.Drawing.Image)
        Me.MageGFX.Location = New System.Drawing.Point(357, 337)
        Me.MageGFX.Name = "MageGFX"
        Me.MageGFX.Size = New System.Drawing.Size(31, 34)
        Me.MageGFX.TabIndex = 5
        Me.MageGFX.TabStop = False
        '
        'ItemsGraphics
        '
        Me.ItemsGraphics.BackgroundImage = CType(resources.GetObject("ItemsGraphics.BackgroundImage"), System.Drawing.Image)
        Me.ItemsGraphics.ErrorImage = CType(resources.GetObject("ItemsGraphics.ErrorImage"), System.Drawing.Image)
        Me.ItemsGraphics.Image = Global.Project_Zombified.My.Resources.Resources.Items
        Me.ItemsGraphics.Location = New System.Drawing.Point(366, 35)
        Me.ItemsGraphics.Name = "ItemsGraphics"
        Me.ItemsGraphics.Size = New System.Drawing.Size(130, 32)
        Me.ItemsGraphics.TabIndex = 6
        Me.ItemsGraphics.TabStop = False
        '
        'InventoryScreen
        '
        Me.InventoryScreen.BackgroundImage = CType(resources.GetObject("InventoryScreen.BackgroundImage"), System.Drawing.Image)
        Me.InventoryScreen.ErrorImage = CType(resources.GetObject("InventoryScreen.ErrorImage"), System.Drawing.Image)
        Me.InventoryScreen.Image = Global.Project_Zombified.My.Resources.Resources.Inventory_Screen
        Me.InventoryScreen.Location = New System.Drawing.Point(409, 115)
        Me.InventoryScreen.Name = "InventoryScreen"
        Me.InventoryScreen.Size = New System.Drawing.Size(92, 92)
        Me.InventoryScreen.TabIndex = 7
        Me.InventoryScreen.TabStop = False
        '
        'StonePB
        '
        Me.StonePB.Image = Global.Project_Zombified.My.Resources.Resources.Stone
        Me.StonePB.Location = New System.Drawing.Point(409, 236)
        Me.StonePB.Name = "StonePB"
        Me.StonePB.Size = New System.Drawing.Size(34, 35)
        Me.StonePB.TabIndex = 8
        Me.StonePB.TabStop = False
        '
        'GUI
        '
        Me.GUI.BackgroundImage = Global.Project_Zombified.My.Resources.Resources.GUI
        Me.GUI.Location = New System.Drawing.Point(-1, 265)
        Me.GUI.Name = "GUI"
        Me.GUI.Size = New System.Drawing.Size(331, 179)
        Me.GUI.TabIndex = 9
        Me.GUI.TabStop = False
        '
        'GFX
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 400)
        Me.Controls.Add(Me.GUI)
        Me.Controls.Add(Me.StonePB)
        Me.Controls.Add(Me.InventoryScreen)
        Me.Controls.Add(Me.ItemsGraphics)
        Me.Controls.Add(Me.MageGFX)
        Me.Controls.Add(Me.PrincessGFX)
        Me.Controls.Add(Me.WarriorGFX)
        Me.Controls.Add(Me.KingsleyGFX)
        Me.Controls.Add(Me.PaladinGFX)
        Me.Controls.Add(Me.pbGFX)
        Me.Name = "GFX"
        Me.Text = "GFX"
        CType(Me.pbGFX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaladinGFX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KingsleyGFX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WarriorGFX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrincessGFX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MageGFX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemsGraphics, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryScreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StonePB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GUI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents pbGFX As PictureBox
    Friend WithEvents PaladinGFX As PictureBox
    Friend WithEvents KingsleyGFX As PictureBox
    Friend WithEvents WarriorGFX As PictureBox
    Friend WithEvents PrincessA As PictureBox
    Friend WithEvents PrincessGFX As PictureBox
    Friend WithEvents MageGFX As PictureBox
    Public WithEvents ItemsGraphics As PictureBox
    Public WithEvents InventoryScreen As PictureBox
    Friend WithEvents StonePB As PictureBox
    Friend WithEvents GUI As PictureBox
End Class
