Public Class Player
    Public PlayerExperience, Experience, CharacterLevel, Health, PlayerCoinBalance As Integer
    Public Strength, Intellegence, MovementSpeed, Dexterity, Luck As Integer 'Specific Objectives 9 a-e) 


    Public Sub AddExperience(Experience As Integer)
        'Adds experience from fights. Experience is a parameter as it is passed from fightscreen
        PlayerExperience += Experience
        UpdateExperience(PlayerExperience)
        'Uses a case of to determine weather the player has leveled up or not and if not then all the expeirence is taken away.
        Experience = 0

    End Sub
    Public Sub UpdateExperience(PlayerExperience As Integer) 'General Objective 3D V)
        Select Case PlayerExperience
            Case 200 'Level 2
                CharacterLevel = 2
                CharacterCreationScreen.SkillPoint += 2
            Case 400 'Level 3
                CharacterLevel = 3
                CharacterCreationScreen.SkillPoint += 2
            Case 600 'Level 4
                CharacterLevel = 4
                CharacterCreationScreen.SkillPoint += 2
            Case 800 'Level 5 
                CharacterLevel = 5
                CharacterCreationScreen.SkillPoint += 2
            Case 1000 'Level 6
                CharacterLevel = 6
                CharacterCreationScreen.SkillPoint += 2
        End Select
    End Sub

End Class
