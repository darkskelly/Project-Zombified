Public Class Armour
    Inherits MapGenerator
    Public WoodHelm As Boolean = False
    Public WoodChest As Boolean = False
    Public WoodLegs As Boolean = False
    Public WoodShoes As Boolean = False
    Public CurrantHelm, CurrantChest, CurrantLegs, CurrantShoes As String

    Private Sub Armour_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'Armour
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.ClientSize = New System.Drawing.Size(1316, 717)
        Me.Name = "Armour"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Enum ArmourClass
        Wood = 1
        Metal = 2
        HardenedMetal = 3
        Special = 4
    End Enum

    Public Sub CheckArmour()
        Select Case CurrantHelm
            Case ArmourClass.Wood
                MapGenerator.HeadSlot.BackgroundImage = My.Resources.WoodHelmInv
                MapGenerator.HeadSlot.Visible = True
            Case ArmourClass.Metal
                'MapGenerator.HeadSlot.BackgroundImage = My.Resources.MetalHelmInv
            Case ArmourClass.HardenedMetal
                'MapGenerator.HeadSlot.BackgroundImage = My.Resources.MetalHelmInv
            Case ArmourClass.Special
                'MapGenerator.HeadSlot.BackgroundImage = My.Resources.SpecialHelmInv

        End Select
        Select Case CurrantChest
            Case ArmourClass.Wood
                MapGenerator.ChestSlot.BackgroundImage = My.Resources.WoodChestInv
                MapGenerator.ChestSlot.Visible = True
            Case ArmourClass.Metal
                ' MapGenerator.ChestSlot.BackgroundImage = My.Resources.MetalChestInv
            Case ArmourClass.HardenedMetal
                ' MapGenerator.ChestSlot.BackgroundImage = My.Resources.HardenedMetalChestInv
            Case ArmourClass.Special
                ' MapGenerator.ChestSlot.BackgroundImage = My.Resources.SpeicalChestInv
        End Select
        Select Case CurrantLegs
            Case ArmourClass.Wood
                MapGenerator.LegSlot.BackgroundImage = My.Resources.WoodGlovesInv
                MapGenerator.LegSlot.Visible = True
            Case ArmourClass.Metal
                'MapGenerator.LegSlot.BackgroundImage = My.Resources.MetalGlovesInv
            Case ArmourClass.HardenedMetal
                'MapGenerator.LegSlot.BackgroundImage = My.Resources.HardenedMetalGlovesInv
            Case ArmourClass.Special
                'MapGenerator.LegSlot.BackgroundImage = My.Resources.SpeicalGlovesInv
        End Select
        Select Case CurrantShoes
            Case ArmourClass.Wood
                MapGenerator.ShoeSlot.BackgroundImage = My.Resources.WoodShoesInv
                MapGenerator.ShoeSlot.Visible = True
            Case ArmourClass.Metal
                'MapGenerator.ShoeSlot.BackgroundImage = My.Resources.MetalShoesInv
            Case ArmourClass.HardenedMetal
                 'MapGenerator.ShoeSlot.BackgroundImage = My.Resources.HardenedMetalShoesInv
            Case ArmourClass.Special
                'MapGenerator.ShoeSlot.BackgroundImage = My.Resources.SpeicalShoesInv
        End Select





    End Sub
End Class
