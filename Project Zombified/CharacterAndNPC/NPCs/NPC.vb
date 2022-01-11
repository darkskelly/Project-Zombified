Public Class NPC
    Inherits MapGenerator
    Public Sub BigHouseGenerator(ByVal x, y)
        For l = 0 To 10
            For i = 0 To 10
                MapGenerator.Map(x + i, y + l, 0) = blockID.WoodPlank
            Next

        Next
        For i = 0 To 10
            MapGenerator.Map(x + i, y, 0) = blockID.Cobblestone
            MapGenerator.Map(x + i, y + 10, 0) = blockID.Cobblestone
            MapGenerator.Map(x, y + i, 0) = blockID.Cobblestone
            MapGenerator.Map(x + 10, y + i, 0) = blockID.Cobblestone
        Next
        MapGenerator.Map(x + 5, y, 0) = blockID.WoodPlank

    End Sub
    Public Sub DrawNPC(ByVal x, y, CharacterModel, NPCState, HouseType)
        Select Case HouseType
            Case "Casino"
                CasinoGenerator(x - 1, y - 1)
            Case "Normal"
                BigHouseGenerator(x - 1, y - 1)
            Case "Merchant"
        End Select
        Select Case MapGenerator.MoveTime
            Case 0
                MapGenerator.Map(x, y, 0) = CharacterModel
                MapGenerator.Map(x, y, 4) = NPCState 'ID
                'SNOC
                MapGenerator.Map(x, y + 1, 0) = blockID.WoodPlank
                MapGenerator.Map(x, y + 1, 4) = 0
            Case 1
                MapGenerator.Map(x + 1, y, 0) = CharacterModel
                MapGenerator.Map(x + 1, y, 4) = NPCState
                MapGenerator.Map(x, y, 0) = blockID.WoodPlank
                MapGenerator.Map(x, y, 4) = 0

            Case 2
                MapGenerator.Map(x + 1, y + 1, 0) = CharacterModel
                MapGenerator.Map(x + 1, y + 1, 4) = NPCState
                MapGenerator.Map(x + 1, y, 0) = blockID.WoodPlank
                MapGenerator.Map(x = 1, y, 4) = 0
            Case 3
                MapGenerator.Map(x, y + 1, 0) = CharacterModel
                MapGenerator.Map(x, y + 1, 4) = NPCState
                MapGenerator.Map(x + 1, y + 1, 0) = blockID.WoodPlank
                MapGenerator.Map(x + 1, y + 1, 4) = 0

        End Select


    End Sub



    Public Sub DrawSwordHouse()
        HouseGenerator(50, 45)
        MapGenerator.Map(52, 44, 0) = Character.ItemModel.Sword
        MapGenerator.Map(52, 44, 4) = 4
        MapGenerator.Map(51, 44, 0) = blockID.WoodPlank
        MapGenerator.Map(51, 43, 0) = blockID.WoodPlank
        MapGenerator.Map(52, 43, 0) = blockID.WoodPlank

    End Sub
    Public Sub DrawMerchantHouse()

        HouseGenerator(99, 102)
    End Sub
    Public Sub HouseGenerator(ByVal x, y)
        'Backside
        MapGenerator.Map(x, y, 0) = blockID.Cobblestone
        MapGenerator.Map(x + 1, y, 0) = blockID.Cobblestone
        MapGenerator.Map(x + 2, y, 0) = blockID.Cobblestone
        'RightSide
        MapGenerator.Map(x + 3, y, 0) = blockID.Cobblestone
        MapGenerator.Map(x + 3, y - 1, 0) = blockID.Cobblestone
        MapGenerator.Map(x + 3, y - 2, 0) = blockID.Cobblestone
        MapGenerator.Map(x + 3, y - 3, 0) = blockID.Cobblestone
        'FrontSide
        MapGenerator.Map(x + 2, y - 3, 0) = blockID.Cobblestone
        MapGenerator.Map(x, y - 3, 0) = blockID.Cobblestone
        'LeftSide
        MapGenerator.Map(x, y - 2, 0) = blockID.Cobblestone
        MapGenerator.Map(x, y - 1, 0) = blockID.Cobblestone
        MapGenerator.Map(x, y, 0) = blockID.Cobblestone
    End Sub
    Public Sub CasinoGenerator(ByVal x, y)
        For l = 0 To 10
            For i = 0 To 10
                MapGenerator.Map(x + i, y + l, 0) = blockID.WoodPlank
            Next

        Next
        'Casino Man Standing at x + 2 , y + 1
        MapGenerator.Map(x + 2, y + 2, 0) = blockID.Table

        MapGenerator.Map(x + 3, y + 2, 0) = blockID.RouletteWheel
        For i = 0 To 10
            MapGenerator.Map(x + i, y, 0) = blockID.Cobblestone
            MapGenerator.Map(x + i, y + 10, 0) = blockID.Cobblestone
            MapGenerator.Map(x, y + i, 0) = blockID.Cobblestone
            MapGenerator.Map(x + 10, y + i, 0) = blockID.Cobblestone
        Next
        MapGenerator.Map(x + 5, y, 0) = blockID.WoodPlank

    End Sub
    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'NPC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.ClientSize = New System.Drawing.Size(1251, 699)
        Me.Name = "NPC"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


End Class






