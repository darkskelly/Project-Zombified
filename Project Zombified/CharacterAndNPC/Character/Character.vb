Public Class Character
    Inherits MapGenerator
    Public BmpChar As Bitmap
    Public GUI As Bitmap
    Public CharModel, tick As Integer
    Public BmpNPC As Bitmap
    Public PlayerCoinBalance As Integer
    Public HasSword As Boolean

    Enum CharacterModel
        CasinoMan = 35
        Kingsley = 29
        Princess = 31
        Paladin = 33
        Firemage = 34
    End Enum
    Enum ItemModel
        Sword = 32
        HealthPot
    End Enum
    'Drawing Character
    Public Sub New()

    End Sub
    Public Sub Startup()
        GetCharModel()
        DrawChar()
    End Sub
    Public Sub DrawChar()
        BmpChar.MakeTransparent(Color.Magenta)
        MapGenerator.G.DrawImage(BmpChar, 18 * Tilesize, 11 * Tilesize, SRect, GraphicsUnit.Pixel) 'c
    End Sub
    Public Sub GetCharModel()
        SRect = New Rectangle(0, 0, Tilesize, Tilesize)

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


        End Select
    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'Character
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.ClientSize = New System.Drawing.Size(1251, 699)
        Me.Name = "Character"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Public Sub TickCounter()


        If tSec = TimeOfDay.Second Then
            tTicks = tTicks + 1
        Else
            MaxTicks = tTicks
            tTicks = 0
            tSec = TimeOfDay.Second
        End If
    End Sub



End Class
