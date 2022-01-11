Public Class DiceRoller
    Private Function RollD6() As Integer
        Randomize()
        Dim rnd As New Random
        Dim D6 As Integer = rnd.Next(1, 6)
        Return D6
    End Function
    Private Function RollD10() As Integer
        Randomize()
        Dim rnd As New Random
        Dim D10 As Integer = rnd.Next(1, 8)
        Return D10
    End Function
    Private Function RollD6Num2() As Integer
        Randomize()
        Dim rnd As New Random
        Dim D62 As Integer = rnd.Next(1, 6)
        Return D62
    End Function
    Public Sub RollDice()
        RollD6()
        RollD10()
        RollD6Num2()

    End Sub
End Class
