Public Class MenuScreen

    Private Sub NewGame_Click(sender As Object, e As EventArgs) Handles NewGame.Click
        CharacterCreationScreen.Show()

        Me.Hide()

    End Sub

    Private Sub LoadGame_Click(sender As Object, e As EventArgs) Handles LoadGame.Click

    End Sub

    Private Sub Tutorial_Click(sender As Object, e As EventArgs) Handles Tutorial.Click
        MapEditor.Show()
        MapEditor.StartGame()
        Me.Hide()

    End Sub

    Private Sub Credit_Click(sender As Object, e As EventArgs) Handles Credit.Click
        Credits.Show()
    End Sub


    Private Sub NewGame_Click_1(sender As Object, e As EventArgs) Handles NewGame.Click

    End Sub

    Private Sub NewGame_Click_2(sender As Object, e As EventArgs) Handles NewGame.Click

    End Sub
End Class
