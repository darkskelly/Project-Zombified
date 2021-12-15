Public Class FightScreen
    Public Visibility As Integer
    Public TotalDamage As Integer
    Public TurnOver As Boolean = False
    'Rolling Dice for combat
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
    'Fighting Sequence ===========================================================================================================================================================================================================
    Public Sub FightStartup()
        ChangeVisibility(1)
    End Sub
    Public Sub ChangeVisibility(Visibility)
        Select Case Visibility
            Case 1
                MeleeAttack.Visible = False
                StrongMelee.Visible = False
                RangedAttack.Visible = False
                ConfusionMove.Visible = False
            Case 2
                MeleeAttack.Visible = True
                StrongMelee.Visible = True
                RangedAttack.Visible = True
                ConfusionMove.Visible = True
                BagButton.Visible = False
                RunButton.Visible = False
                FightButton.Visible = False
            Case 3
                MeleeAttack.Visible = False
                StrongMelee.Visible = False
                RangedAttack.Visible = False
                ConfusionMove.Visible = False
                BagButton.Visible = True
                RunButton.Visible = True
                FightButton.Visible = True
        End Select
    End Sub
    Public Sub FightLoop()
        PlayerHealth.Value = PlayerHealthLabel.Text
        EnemyHealth.Value = EnemyHealthLabel.Text
    End Sub
    'Initial Decisions ===========================================================================================================================================================================================================
    Private Sub FightButton_Click(sender As Object, e As EventArgs) Handles FightButton.Click
        ChangeVisibility(2)
    End Sub

    Private Sub BagButton_Click(sender As Object, e As EventArgs) Handles BagButton.Click

    End Sub

    Private Sub RunButton_Click(sender As Object, e As EventArgs) Handles RunButton.Click

    End Sub
    'Fight Moves ===========================================================================================================================================================================================================
    Private Sub StrongMelee_Click(sender As Object, e As EventArgs) Handles StrongMelee.Click
        ChangeVisibility(3)
        RollDice()
        TotalDamage = (RollD10() + RollD6()) * RollD6Num2()
        EnemyHealthLabel.Text -= TotalDamage
        EnemyTurn()
    End Sub

    Private Sub MeleeAttack_Click(sender As Object, e As EventArgs) Handles MeleeAttack.Click
        ChangeVisibility(3)
        RollDice()
        TotalDamage = (RollD10() * RollD6())
        EnemyHealthLabel.Text -= TotalDamage
        EnemyTurn()
    End Sub

    Private Sub ConfusionMove_Click(sender As Object, e As EventArgs) Handles ConfusionMove.Click
        ChangeVisibility(3)
        RollDice()
        'Chance at attacker missing turn
        EnemyTurn()
    End Sub

    Private Sub RangedAttack_Click(sender As Object, e As EventArgs) Handles RangedAttack.Click
        ChangeVisibility(3)
        RollDice()
        TotalDamage = (RollD6() + RollD6Num2()) * RollD10()
        EnemyHealthLabel.Text -= TotalDamage
        EnemyTurn()
    End Sub
    'Enemy attack =============================================================================================================================================================================================================
    Dim EnemyDamage As Integer
    Private Function RandAttack() As Integer
        Randomize()
        Dim rnd As New Random
        Dim D62 As Integer = rnd.Next(1, 4)
        Return D62
    End Function
    Public Sub EnemyTurn()
        RandAttack()
        Select Case RandAttack()
            Case 1
                EnemyMelee()
                EnemyMoveLabel.Text = "Enemy did " & EnemyDamage & " Damage and used Melee"
            Case 2
                EnemyRanged()
                EnemyMoveLabel.Text = "Enemy did " & EnemyDamage & " Damage and used Ranged attack"
            Case 3
                EnemyStrongMelee()
                EnemyMoveLabel.Text = "Enemy did " & EnemyDamage & " Damage and used Big hitter"
            Case 4
                EnemyConfusion()
                EnemyMoveLabel.Text = "Enemy did " & EnemyDamage & " Damage and used Confusion"
        End Select
        EnemyMoveLabel.Visible = True
    End Sub
    Public Sub EnemyMelee()
        RollDice()
        EnemyDamage = (RollD10() * RollD6())
        PlayerHealthLabel.Text -= EnemyDamage
    End Sub
    Public Sub EnemyStrongMelee()
        RollDice()
        EnemyDamage = (RollD10() + RollD6()) * RollD6Num2()
        PlayerHealthLabel.Text -= EnemyDamage
    End Sub
    Public Sub EnemyRanged()
        RollDice()
        EnemyDamage = (RollD6() + RollD6Num2()) * RollD10()
        PlayerHealthLabel.Text -= EnemyDamage
    End Sub
    Public Sub EnemyConfusion()

    End Sub
End Class