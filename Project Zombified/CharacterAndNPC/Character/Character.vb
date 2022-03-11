Public Class Character
    Inherits MapGenerator
    Public BmpChar As Bitmap
    Public GUI As Bitmap
    Public CharModel, tick As Integer
    Public BmpNPC As Bitmap
    Public PlayerCoinBalance As Integer

    Public Health As Integer
    Public CharacterLevel As Integer
    Public PlayerExperience As Integer
    Public Experience As Integer
    '   Public Player1Class As New HumanClasses



    Enum CharacterModel
        CasinoMan = 35
        Kingsley = 29
        Princess = 31
        Paladin = 33
        Firemage = 34
        Florance = 35
    End Enum
    Enum ItemModel
        Sword = 32
        HealthPot
    End Enum
    'Drawing Character

    Public Sub Startup()
        GetCharModel()
        DrawChar()
        ' Player1Class.ClassAbilities()
        'Player1Class.ClassWeapon()

    End Sub

    Public Sub DrawChar()
        BmpChar.MakeTransparent(Color.Magenta)
        MapGenerator.G.DrawImage(BmpChar, 18 * Tilesize, 11 * Tilesize, SRect, GraphicsUnit.Pixel) 'c
    End Sub

    Public Sub GetCharModel()
        SRect = New Rectangle(0, 0, Tilesize, Tilesize)
        'This gets the currantly selected character model 
        Select Case CharModel
            Case 0
                BmpChar = New Bitmap(GFX.WarriorGFX.BackgroundImage)

            Case 1
                BmpChar = New Bitmap(GFX.MageGFX.BackgroundImage)

            Case 2
                BmpChar = New Bitmap(GFX.PaladinGFX.BackgroundImage)

            Case 3
                BmpChar = New Bitmap(GFX.KingsleyGFX.BackgroundImage)

            Case 4
                BmpChar = New Bitmap(GFX.PrincessGFX.BackgroundImage)
            Case 5
                BmpChar = New Bitmap(GFX.FloranceGFX.BackgroundImage)

        End Select
    End Sub


End Class
