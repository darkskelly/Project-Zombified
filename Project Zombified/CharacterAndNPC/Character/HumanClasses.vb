Public Class HumanClasses


    Public Sub ClassAbilities()
        Select Case CharacterCreationScreen.CharClass
            Case "Hunter"
                FightScreen.RangedAttack.Text = "Bow Shot"
                FightScreen.MeleeAttack.Text = "Dagger"
                FightScreen.StrongMelee.Text = "Pet attack" 'Increase for each pet level
                FightScreen.ConfusionMove.Text = "Side Step"
            Case "Paladin"
                FightScreen.RangedAttack.Text = "Smite"
                FightScreen.MeleeAttack.Text = "Hammer"
                FightScreen.StrongMelee.Text = "Divine Wind"
                FightScreen.ConfusionMove.Text = "Summon God"
            Case "Ranged"
                FightScreen.RangedAttack.Text = "Fireball"
                FightScreen.MeleeAttack.Text = "Ice Knife"
                FightScreen.StrongMelee.Text = "Thorn Whip"
                FightScreen.ConfusionMove.Text = "Summon Shadow Clones"
            Case "Tank"
                FightScreen.RangedAttack.Text = "Throw axe"
                FightScreen.MeleeAttack.Text = "Shield Bash"
                FightScreen.StrongMelee.Text = "Berserk"
                FightScreen.ConfusionMove.Text = "Earthquake"
            Case "Warrior"
                FightScreen.RangedAttack.Text = "Throw knifes"
                FightScreen.MeleeAttack.Text = "Slash"
                FightScreen.StrongMelee.Text = "Charge"
                FightScreen.ConfusionMove.Text = "Side step"
        End Select
    End Sub
    '
    Public Sub ClassWeapon()
        Select Case CharacterCreationScreen.CharClass
            Case "Hunter"
                Dim Bow As New Items
                'Bow: 1 Strength, 3 Intellegence, 5 Dexterity 
                With Bow
                    .Item = ItemClass.Weapon
                    .Name = "Hunter's Bow"
                    .Description = "You must not only aim right, but draw the bow with all your might"
                    .IsStackable = False
                    .ImageAsset = My.Resources.HuntIcon
                    .Strength = 1
                    .Intellegence = 3
                    .Dexterity = 5
                    .BaseDamage = 20
                End With
                MapGenerator.BackPack.Add(Bow)
            Case "Paladin"
                Dim Hammer As New Items
                'Hammer: 3 Strength, 2 Intellegence, -1 Dexterity , 2 Luck
                With Hammer
                    .Item = ItemClass.Weapon
                    .Name = "Paladins Hammer"
                    .Description = ""
                    .IsStackable = False
                    .ImageAsset = My.Resources.PaladinIcon
                    .Strength = 3
                    .Intellegence = 2
                    .Dexterity = -1
                    .Luck = 2
                    .BaseDamage = 25
                End With
                MapGenerator.BackPack.Add(Hammer)
            Case "Ranged"

                Dim Staff As New Items
                'Staff: -1 Strength, 5 Intellegence, 2 Dexterity, 3 Luck
                With Staff
                    .Item = ItemClass.Weapon
                    .Name = "Mage Staff"
                    .Description = ""
                    .IsStackable = False
                    .ImageAsset = My.Resources.Mage
                    .Strength = -1
                    .Intellegence = 5
                    .Dexterity = 2
                    .Luck = 3
                    .BaseDamage = 15
                End With
                MapGenerator.BackPack.Add(Staff)
            Case "Tank"
                Dim Shield As New Items
                'Shield: 6 Strength, -2 Dexterity, -2 MovementSpeed
                With Shield
                    .Item = ItemClass.Weapon
                    .Name = "Tank's Shield"
                    .Description = ""
                    .IsStackable = False
                    .ImageAsset = My.Resources.TankIcon
                    .Strength = 6
                    .Dexterity = -2
                    .MovementSpeed = -2
                    .BaseDamage = 15
                End With
                MapGenerator.BackPack.Add(Shield)
            Case "Warrior"
                Dim Sword As New Items
                'Sword: 3 Strength, 2 Dexterity, 1 movementSpeed, -2 Intellegence
                With Sword
                    .Item = ItemClass.Weapon
                    .Name = "Warrior's Sword"
                    .Description = ""
                    .IsStackable = False
                    '.ImageAsset = My.Resources.sword
                    .Strength = 3
                    .Dexterity = 2
                    .MovementSpeed = 1
                    .Intellegence = -2
                    .BaseDamage = 20
                End With
                MapGenerator.BackPack.Add(Sword)

        End Select
    End Sub
End Class
