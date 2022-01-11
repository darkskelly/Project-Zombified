Public Class InvInterface
    Public Sub UpdateInv()
        If MapGenerator.Stone > 0 Then

            inv11.Image = My.Resources.Stone
            StoneAmount.Text = MapGenerator.Stone
        End If
        If MapGenerator.Wood > 0 Then
            inv12.Image = My.Resources.Wood
            WoodAmount.Text = MapGenerator.Wood
        End If
        If Character.PlayerCoinBalance > 0 Then
            inv13.Image = My.Resources.Coin
            CoinBalance.Text = Character.PlayerCoinBalance
        End If
        If Character.HasSword = True Then

        End If
    End Sub
    Private Sub InvInterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateInv()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub InvInterface_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Select Case e.KeyChar
            Case "i"
                Me.Hide()
                UpdateInv()
        End Select
    End Sub

    Private Sub inv11_Click(sender As Object, e As EventArgs) Handles inv11.Click

    End Sub
End Class