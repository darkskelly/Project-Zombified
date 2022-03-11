Public Class FightScreen


    Public Visibility As Integer
        Public TotalDamage As Integer
    Public WeaponDMG, WeaponStrength, WeaponDex, WeaponLuck, WeaponInt As Integer
    Public WinCond As Boolean = False
        Enum PlayerAttack
            MeleeAttack
        End Enum
    'Rolling Dice for combat

    Private Function RollD6() As Integer
        'General Objective 3D II)
        Randomize()
        Dim rnd As New Random
        Dim D6 As Integer = rnd.Next(1, 6)
        Return D6
    End Function
    Private Function RollD10() As Integer
        'General Objective 3D II)
        Randomize()
        Dim rnd As New Random
        Dim D10 As Integer = rnd.Next(1, 8)
        Return D10
    End Function
    Private Function RollD6Num2() As Integer
        'General Objective 3D II)
        Randomize()
        Dim rnd As New Random
        Dim D62 As Integer = rnd.Next(1, 6)
        Return D62
    End Function
    Public Sub RollDice()
        'General Objective 3D II)
        RollD6()
        RollD10()
        RollD6Num2()

    End Sub
    'Fighting Sequence ===========================================================================================================================================================================================================
    Public Sub FightStartup()
            WinLooseLabel.Visible = False
            ExperienceGainedLabel.Visible = False
        ArmourValue() 'General objective 11)
        WeaponChecker()

        PlayerHealth.Value = Character.Health
        EnemyHealth.Value = 120
        FightLoop()
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
    Public Sub ArmourValue()
        Select Case Armour.CurrantHelm
            Case Armour.ArmourClass.Wood
                Character.Health += 15
            Case Armour.ArmourClass.Metal
                Character.Health += 25
            Case Armour.ArmourClass.HardenedMetal
                Character.Health += 35
            Case Armour.ArmourClass.Special
                Character.Health += 50

        End Select
        Select Case Armour.CurrantChest
            Case Armour.ArmourClass.Wood
                Character.Health += 30
            Case Armour.ArmourClass.Metal
                Character.Health += 40
            Case Armour.ArmourClass.HardenedMetal
                Character.Health += 50
            Case Armour.ArmourClass.Special
                Character.Health += 65
        End Select
        Select Case Armour.CurrantLegs
            Case Armour.ArmourClass.Wood
                Character.Health += 5
            Case Armour.ArmourClass.Metal
                Character.Health += 10
            Case Armour.ArmourClass.HardenedMetal
                Character.Health += 15
            Case Armour.ArmourClass.Special
                Character.Health += 25
        End Select
        Select Case Armour.CurrantShoes
            Case Armour.ArmourClass.Wood
                Character.Health += 10
            Case Armour.ArmourClass.Metal
                Character.Health += 15
            Case Armour.ArmourClass.HardenedMetal
                Character.Health += 25
            Case Armour.ArmourClass.Special
                Character.Health += 40
        End Select

    End Sub
    Public Sub WeaponChecker()
        '  For i = 0 To (MapGenerator.BackPack.Equipped.Count - 1)
        '  If MapGenerator.BackPack.Equipped.Item(i - 1).Item = ItemClass.Weapon Then
        WeaponDMG = MapGenerator.BackPack.Equipped.Item(0).BaseDamage
                WeaponDex = MapGenerator.BackPack.Equipped.Item(0).Dexterity
                WeaponInt = MapGenerator.BackPack.Equipped.Item(0).Intellegence
                WeaponLuck = MapGenerator.BackPack.Equipped.Item(0).Luck
                WeaponStrength = MapGenerator.BackPack.Equipped.Item(0).Strength
            'End If

        ' Next
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
        'General Objective 3D III)
        

        If PlayerHealth.Value > 0 Or EnemyHealth.Value > 0 Then
            ChangeVisibility(3)
            RollDice()

            TotalDamage = WeaponDMG + ((WeaponStrength + MapGenerator.Player1.Strength) * RollD10())  '       (RollD10() + RollD6()) * RollD6Num2() 'Calculates all of the Dice Rolls weighted sum

            If EnemyHealthLabel.Text < TotalDamage Then ' If enemy health is less than total damage
                EnemyHealth.Value = 0 'Enemy Health 0 
                EnemyHealthLabel.Text = 0
                WinCond = True
                FightEnd()
            Else
                EnemyHealthLabel.Text -= TotalDamage 'Enemy takes damage and carries on
                EnemyHealth.Value -= TotalDamage
            End If
            PlayerMoves.Text = "You did " & TotalDamage & " Damage and used big hitter"

            EnemyTurn()
        Else

        End If

    End Sub

    Private Sub MeleeAttack_Click(sender As Object, e As EventArgs) Handles MeleeAttack.Click
        'General Objective 3D III)
        If PlayerHealth.Value > 0 Or EnemyHealth.Value > 0 Then
            ChangeVisibility(3)
            RollDice()
            TotalDamage = WeaponDMG + (WeaponStrength + WeaponDex + MapGenerator.Player1.Strength + MapGenerator.Player1.Dexterity) * RollD6Num2()
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
        'General Objective 3D III)
        If PlayerHealth.Value > 0 Or EnemyHealth.Value > 0 Then
            ChangeVisibility(3)
            RollDice()

            TotalDamage = WeaponDMG + ((WeaponDex + WeaponInt + MapGenerator.Player1.Intellegence + MapGenerator.Player1.Dexterity) * RollD6())
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
            MapGenerator.Player1.AddExperience(50) 'General Objective 3D IV),Specific Objective 11 a,d) 
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