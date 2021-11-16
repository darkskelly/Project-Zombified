Public Class DepositScreen
    Public PlayerBalance As Integer
    Private Sub DepositScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Update()
    End Sub
    Public Sub Update()
        If MapGenerator.Stone > 0 Then
            AmountOfStone.Text = MapGenerator.Stone
        End If
        If MapGenerator.Wood > 0 Then
            WoodAmount.Text = MapGenerator.Wood
        End If
        Roulette.CoinBalance.Text = Character.PlayerCoinBalance
    End Sub

    Private Sub DepositStone_Click(sender As Object, e As EventArgs) Handles DepositStone.Click
        If MapGenerator.Stone > 0 Then
            Character.PlayerCoinBalance += 25
            MapGenerator.Stone -= 1
        End If
        Update()
    End Sub

    Private Sub DepositWood_Click(sender As Object, e As EventArgs) Handles DepositWood.Click
        If MapGenerator.Wood > 0 Then
            Character.PlayerCoinBalance += 25
            MapGenerator.Wood -= 1
        End If
        Update()
    End Sub
End Class