Public Class FightScreen
    Public Visibility As Integer
    Public TotalDamage As Integer

    Public WinCond As Boolean = False
    Enum PlayerAttack
        MeleeAttack
    End Enum
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
        WinLooseLabel.Visible = False
        ExperienceGainedLabel.Visible = False
        PlayerHealth.Value = 120
        EnemyHealth.Value = 120
        ChangeVisibility(1)
        'While 
        '    PDead = False
        '    EDead = False
        'End While
        'If PlayerHealth.Value > 0 Then
        '    PDead = True
        'Else
        '    EDead = True
        'End If
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
        If PlayerHealth.Value > 0 Or EnemyHealth.Value > 0 Then
            ChangeVisibility(3)
            RollDice()
            TotalDamage = (RollD10() + RollD6()) * RollD6Num2()
            If EnemyHealthLabel.Text < TotalDamage Then
                EnemyHealth.Value = 0
                EnemyHealthLabel.Text = 0
                WinCond = True
                FightEnd()
            Else
                EnemyHealthLabel.Text -= TotalDamage
                EnemyHealth.Value -= TotalDamage
            End If
            PlayerMoves.Text = "You did " & TotalDamage & " Damage and used big hitter"

            EnemyTurn()
        Else

        End If

    End Sub

    Private Sub MeleeAttack_Click(sender As Object, e As EventArgs) Handles MeleeAttack.Click
        If PlayerHealth.Value > 0 Or EnemyHealth.Value > 0 Then
            ChangeVisibility(3)
            RollDice()
            TotalDamage = (RollD10() * RollD6())
            If EnemyHealthLabel.Text < TotalDamage Then
                EnemyHealth.Value = 0
                EnemyHealthLabel.Text = 0
                WinCond = True
                FightEnd()

            Else
                EnemyHealthLabel.Text -= TotalDamage
                EnemyHealth.Value -= TotalDamage
            End If
            PlayerMoves.Text = "You did " & TotalDamage & " Damage and used Melee attack"
            EnemyTurn()
        Else

        End If

    End Sub

    Private Sub ConfusionMove_Click(sender As Object, e As EventArgs) Handles ConfusionMove.Click
        ChangeVisibility(3)
        RollDice()
        'Chance at attacker missing turn

        EnemyTurn()
    End Sub
    Private Sub RangedAttack_Click(sender As Object, e As EventArgs) Handles RangedAttack.Click
        If PlayerHealth.Value > 0 Or EnemyHealth.Value > 0 Then
            ChangeVisibility(3)
            RollDice()
            TotalDamage = (RollD6() + RollD6Num2()) * RollD10()
            If EnemyHealthLabel.Text < TotalDamage Then
                EnemyHealth.Value = 0
                EnemyHealthLabel.Text = 0
                WinCond = True
                FightEnd()
            Else
                EnemyHealthLabel.Text -= TotalDamage
                EnemyHealth.Value -= TotalDamage
            End If
            PlayerMoves.Text = "You did " & TotalDamage & " Damage and used Ranged attack"
            EnemyTurn()
        Else

        End If

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
        If PlayerHealth.Value > 0 Or EnemyHealth.Value > 0 Then
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
        Else

        End If

    End Sub
    Public Sub EnemyMelee()
        RollDice()
        EnemyDamage = (RollD10() * RollD6())
        If PlayerHealthLabel.Text < EnemyDamage Then
            PlayerHealthLabel.Text = 0
            PlayerHealth.Value = 0
            WinCond = False
            FightEnd()
        Else
            PlayerHealthLabel.Text -= EnemyDamage
            PlayerHealth.Value -= EnemyDamage
        End If


    End Sub
    Public Sub EnemyStrongMelee()
        RollDice()
        EnemyDamage = (RollD10() + RollD6()) * RollD6Num2()
        If PlayerHealthLabel.Text < EnemyDamage Then
            PlayerHealthLabel.Text = 0
            PlayerHealth.Value = 0
            WinCond = False
            FightEnd()
        Else
            PlayerHealthLabel.Text -= EnemyDamage
            PlayerHealth.Value -= EnemyDamage
        End If
    End Sub
    Public Sub EnemyRanged()
        RollDice()
        EnemyDamage = (RollD6() + RollD6Num2()) * RollD10()
        If PlayerHealthLabel.Text < EnemyDamage Then
            PlayerHealthLabel.Text = 0
            PlayerHealth.Value = 0
            WinCond = False
            FightEnd()

        Else
            PlayerHealthLabel.Text -= EnemyDamage
            PlayerHealth.Value -= EnemyDamage
        End If
    End Sub
    Public Sub EnemyConfusion()

    End Sub
    ' END OF GAME ==========================================================================================================================
    Public Sub FightEnd()
        If WinCond = True Then
            Character.AddExperience(50)
            WinCond = False
            WinLooseLabel.Text = "You Win!!" : WinLooseLabel.Visible = True
            ExperienceGainedLabel.Text = "You are now at " & Character.PlayerExperience : ExperienceGainedLabel.Visible = True
            CharacterCreationScreen.UpdateLabels()

        Else
            WinLooseLabel.Text = "You died" : WinLooseLabel.Visible = True
        End If
    End Sub

    Private Sub FightScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FightStartup()
    End Sub
End Class