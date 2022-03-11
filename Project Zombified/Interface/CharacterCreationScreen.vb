Public Class CharacterCreationScreen
    Public CharClass As String
    Public CharModelName As String
    Public SkillPoint As Integer

    Private Sub CharacterCreationScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SkillPoint += 10
    End Sub

    Private Sub Character_Trackbar_Label_Click(sender As Object, e As EventArgs) Handles Character_Trackbar_Label.Click

    End Sub
    Private Sub MovementSpeedBar_Click(sender As Object, e As EventArgs) Handles MovementSpeedBar.Click

    End Sub

    Private Sub Movement_Click(sender As Object, e As EventArgs) Handles Movement.Click
        If MovementSpeedBar.Value >= 100 Then
        Else
            If SkillPoint > 0 Then
                SkillPoint -= 1
                MovementSpeedBar.Value += 10
                MapGenerator.Player1.MovementSpeed += 1

                UpdateLabels()
            End If

        End If

        'MapGenerator.MovementSpeed += 2

    End Sub

    Private Sub StrengthStatButton_Click(sender As Object, e As EventArgs) Handles StrengthStatButton.Click
        If StrengthBar.Value >= 100 Then
        Else
            If SkillPoint > 0 Then
                SkillPoint -= 1

                StrengthBar.Value += 10
                MapGenerator.Player1.Strength += 1
                UpdateLabels()
            End If

        End If

    End Sub

    Private Sub IntellegenceButton_Click(sender As Object, e As EventArgs) Handles IntellegenceButton.Click

        If IntellegenceBar.Value >= 100 Then
        Else
            If SkillPoint > 0 Then
                SkillPoint -= 1
                IntellegenceBar.Value += 10
                MapGenerator.Player1.Intellegence += 1

                UpdateLabels()
            End If

        End If
    End Sub

    Private Sub DexterityButton_Click(sender As Object, e As EventArgs) Handles DexterityButton.Click
        If DexterityBar.Value >= 100 Then
        Else
            If SkillPoint > 0 Then
                SkillPoint -= 1
                DexterityBar.Value += 10
                MapGenerator.Player1.Dexterity += 1
                UpdateLabels()
            End If

        End If

    End Sub

    Private Sub LuckButton_Click(sender As Object, e As EventArgs) Handles LuckButton.Click

        If LuckBar.Value >= 100 Then

        Else
            If SkillPoint > 0 Then
                SkillPoint -= 1
                LuckBar.Value += 10
                UpdateLabels()
                MapGenerator.Player1.Luck += 1
            End If

        End If
        If LuckBar.Value < 10 Then

        End If
    End Sub

    Private Sub Comfirm_Finish_Click(sender As Object, e As EventArgs) Handles Comfirm_Finish.Click

        MapGenerator.Show()
        MapGenerator.StartGame()
        Me.Hide()

        Me.ShowInTaskbar = False
        Me.WindowState = FormWindowState.Minimized
        Me.Opacity = 0
    End Sub

    Private Sub Character_TrackBar_Scroll(sender As Object, e As EventArgs) Handles Character_TrackBar.Scroll
        Select Case Character_TrackBar.Value
            Case 1
                Character.CharModel = 0
                CharSelectionPic.BackgroundImage = My.Resources.WarriorChar
                CharModelName = "Warrior"
            Case 2
                Character.CharModel = 1
                CharSelectionPic.BackgroundImage = My.Resources.PaladinCharMenu1
                CharModelName = "Paladin"
            Case 3
                Character.CharModel = 2
                CharSelectionPic.BackgroundImage = My.Resources.Mage
                CharModelName = "Mage"
            Case 4
                Character.CharModel = 3
                CharSelectionPic.BackgroundImage = My.Resources.Kingsley
                CharModelName = "Kingsley"
            Case 5
                Character.CharModel = 4
                CharSelectionPic.BackgroundImage = My.Resources.PrincessLeggy
                CharModelName = "Princess"
            Case 6
                Character.CharModel = 5
                CharSelectionPic.BackgroundImage = My.Resources.Florance
                CharModelName = "Florance"
        End Select

        CharName.Text = CharModelName

    End Sub
    Public Sub UpdateLabels()
        SkillPointsLabel.Text = "You have " & SkillPoint & " Skill Points left!"
        PlayerLevelLabel.Text = "You are level " & Character.CharacterLevel
    End Sub

    Private Sub Class_Hunter_Click(sender As Object, e As EventArgs) Handles Class_Hunter.Click
        CharClass = "Hunter"
        Character_Trackbar_Label.Text = CharClass
    End Sub

    Private Sub Class_Paladin_Click(sender As Object, e As EventArgs) Handles Class_Paladin.Click
        CharClass = "Paladin"
        Character_Trackbar_Label.Text = CharClass
    End Sub

    Private Sub Class_Ranged_Click(sender As Object, e As EventArgs) Handles Class_Ranged.Click
        CharClass = "Ranged"
        Character_Trackbar_Label.Text = CharClass
    End Sub

    Private Sub Class_Tank_Click(sender As Object, e As EventArgs) Handles Class_Tank.Click
        CharClass = "Tank"
        Character_Trackbar_Label.Text = CharClass
    End Sub

    Private Sub Class_Warrior_Click(sender As Object, e As EventArgs) Handles Class_Warrior.Click
        CharClass = "Warrior"
        Character_Trackbar_Label.Text = CharClass
    End Sub

    Private Sub CharSelectionPic_Click(sender As Object, e As EventArgs) Handles CharSelectionPic.Click

    End Sub


End Class