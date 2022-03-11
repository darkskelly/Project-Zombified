Public Class KingsleyInterface

    Private Sub KingsleyInterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BuyButton_Click(sender As Object, e As EventArgs) Handles BuyButton.Click
        BuyButton.Visible = False
        SellButton.Visible = False
        BackstoryButton.Visible = False
        BuyWoodenChest.Visible = True
        BuyWoodenHelmet.Visible = True
        BuyWoodenLegs.Visible = True
        BuyWoodenShoes.Visible = True
        KingsleyLabel.Text = "What would you like to purchase?"

    End Sub

    Private Sub SellButton_Click(sender As Object, e As EventArgs) Handles SellButton.Click
        BuyButton.Visible = False
        SellButton.Visible = False
        BackstoryButton.Visible = False
        SellWood.Visible = True
        SellStone.Visible = True

    End Sub

    Private Sub BackstoryButton_Click(sender As Object, e As EventArgs) Handles BackstoryButton.Click

    End Sub

    Private Sub BuyWoodenHelmet_Click(sender As Object, e As EventArgs) Handles BuyWoodenHelmet.Click
        If MapGenerator.Player1.PlayerCoinBalance >= 250 Then
            MapGenerator.BackPack.Add(MapGenerator.WoodHelmet)

            MapGenerator.Player1.PlayerCoinBalance -= 250
        End If
    End Sub

    Private Sub BuyWoodenChest_Click(sender As Object, e As EventArgs) Handles BuyWoodenChest.Click
        If MapGenerator.Player1.PlayerCoinBalance >= 250 Then
            MapGenerator.BackPack.Add(MapGenerator.WoodChest)
            MapGenerator.Player1.PlayerCoinBalance -= 250
        End If
    End Sub

    Private Sub BuyWoodenLegs_Click(sender As Object, e As EventArgs) Handles BuyWoodenLegs.Click
        If MapGenerator.Player1.PlayerCoinBalance >= 250 Then
            MapGenerator.BackPack.Add(MapGenerator.WoodGloves)
            MapGenerator.Player1.PlayerCoinBalance -= 250
        End If
    End Sub

    Private Sub BuyWoodenShoes_Click(sender As Object, e As EventArgs) Handles BuyWoodenShoes.Click
        If MapGenerator.Player1.PlayerCoinBalance >= 250 Then
            MapGenerator.BackPack.Add(MapGenerator.WoodShoes)
            MapGenerator.Player1.PlayerCoinBalance -= 250
        End If
    End Sub

    Private Sub SellWood_Click(sender As Object, e As EventArgs) Handles SellWood.Click
        If MapGenerator.Wood > 0 Then
            MapGenerator.Player1.PlayerCoinBalance += 25
            'MapGenerator.BackPack.Add()
            MapGenerator.Wood -= 1
        End If
    End Sub

    Private Sub SellStone_Click(sender As Object, e As EventArgs) Handles SellStone.Click
        If MapGenerator.Stone > 0 Then
            MapGenerator.Player1.PlayerCoinBalance += 25
            'MapGenerator.BackPack.Add()
            MapGenerator.Stone -= 1
        End If
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        BuyButton.Visible = True
        SellButton.Visible = True
        BackstoryButton.Visible = True
        SellWood.Visible = False
        SellStone.Visible = False
        BuyWoodenChest.Visible = False
        BuyWoodenHelmet.Visible = False
        BuyWoodenLegs.Visible = False
        BuyWoodenShoes.Visible = False
    End Sub
End Class