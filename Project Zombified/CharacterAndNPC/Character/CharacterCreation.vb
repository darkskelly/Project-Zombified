Public Class CharacterCreation
    Private Sub MovementSpeedBar_Click(sender As Object, e As EventArgs) Handles MovementSpeedBar.Click

    End Sub

    Private Sub Movement_Click(sender As Object, e As EventArgs) Handles Movement.Click
        MovementSpeedBar.Value += 10
        'MapGenerator.MovementSpeed += 2

    End Sub

    Private Sub StrengthStatButton_Click(sender As Object, e As EventArgs) Handles StrengthStatButton.Click
        StrengthBar.Value += 10
    End Sub

    Private Sub IntellegenceButton_Click(sender As Object, e As EventArgs) Handles IntellegenceButton.Click
        IntellegenceBar.Value += 10
    End Sub

    Private Sub DexterityButton_Click(sender As Object, e As EventArgs) Handles DexterityButton.Click
        DexterityBar.Value += 10
    End Sub

    Private Sub LuckButton_Click(sender As Object, e As EventArgs) Handles LuckButton.Click
        LuckBar.Value += 10
        If LuckBar.Value < 10 Then

        End If
    End Sub
End Class