Public Class MapGenerator
    Dim Box(12, 12) As PictureBox
    'Mouse Locations
    Public MouseX, MouseY As Integer
    Public mMapX, mMapY As Integer
    'Fps Counter
    Public tSec As Integer = TimeOfDay.Second
    Public timer As Integer
    Public tTicks As Integer = 0
    Public MaxTicks As Integer = 0
    'Map Variables
    Public MapWidth As Integer = 300
    Public MapHeight As Integer = 300
    Public Map(MapWidth, MapHeight, 6) As Integer

    Public MapX As Integer = 150
    Public MapY As Integer = 150
    Public Tilesize As Integer = 32
    Public x As Object
    Public y As Object
    'Npc Variables
    Public Seconds As Integer
    Public MoveTime As Integer
    Dim RandX As Integer = Int((150 * Rnd()) + 1)
    Dim RandY As Integer = Int((160 * Rnd()) + 1)

    'Graphics Variables
    Public G As Graphics
    Public BBG As Graphics 'To stop flickering with characters
    Public BmpTile, BB As Bitmap
    Public SRect, DRect As Rectangle
    'Game running
    Public IsRunning As Boolean = True
    'Character Variables
    Dim CharacterFile As String = ""
    Public Player1 As New PlayerStorage
    Public Sword, HealthPot, PowerFlower As Bitmap
    Public InventoryScreen As Bitmap
    Public XPos As Integer = 18
    Public YPos As Integer = 11
    Public CharX As Integer = (MapX + 18) * Tilesize
    Public CharY As Integer = (MapY + 11) * Tilesize
    Public Turn As Integer
    Public MovementSpeed As Integer = 8
    Public dir, LastDir As Integer
    Public BlockHit As Boolean = False
    Public BlocksBroken As Integer
    Public ItemPickedUp As Boolean = False
    Public Stone, Wood, Flowers, Cactus As Integer
    Public BlockInHand As String
    'Key Detection
    Public KeyPushed As Short = 0
    'Random Numbers
    Dim IntStart As Integer = 1
    Dim IntEnd As Integer = 12
    Dim InvOpen As Boolean = False
    Dim Biome As Integer
    'Screen manager

    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
        Me.Focus()
        GenerateRandomMap()
        'intiialising Game
        G = Me.CreateGraphics
        BB = New Bitmap(Me.Width, Me.Height)
        BmpTile = New Bitmap(GFX.pbGFX.BackgroundImage)
        Fonts.Load()


    End Sub

    Public Overridable Sub StartGame()


        Do While IsRunning = True
            Movement(dir)
            Application.DoEvents()
            Character.TickCounter()
            BuildMap()
            timer += 1
        Loop
    End Sub

    Public Overridable Sub BuildMap()

        For x = -1 To 96
            For y = -1 To 96
                GetSourceBlock(MapX + x, MapY + y, Tilesize)

                DRect = New Rectangle((x * Tilesize) + XPos, (y * Tilesize) + YPos, Tilesize, Tilesize)
                G.DrawImage(BmpTile, DRect, SRect, GraphicsUnit.Pixel)
            Next
        Next

        'Shows how many tiles player can move
        If mMapX = XPos And mMapY = YPos Then
            G.DrawRectangle(Pens.Purple, (XPos + 1) * Tilesize, (YPos) * Tilesize, Tilesize, Tilesize)
            G.DrawRectangle(Pens.Purple, (XPos - 1) * Tilesize, (YPos) * Tilesize, Tilesize, Tilesize)
            G.DrawRectangle(Pens.Purple, (XPos) * Tilesize, (YPos + 1) * Tilesize, Tilesize, Tilesize)
            G.DrawRectangle(Pens.Purple, (XPos) * Tilesize, (YPos - 1) * Tilesize, Tilesize, Tilesize)
        End If
        'Menu
        G.DrawRectangle(Pens.Red, MouseX * Tilesize, MouseY * Tilesize, Tilesize, Tilesize)
        'Character.DrawCharacterInfo()
        G.DrawString("Ticks: " & tTicks & vbCrLf &
                  "TPS: " & MaxTicks & vbCrLf &
                  "Map X: " & mMapX & vbCrLf &
                 " Y: " & mMapY & vbCrLf &
                 "Char X pos: " & (CharX / Tilesize) - 6 & vbCrLf &
                 "Char Y pos: " & (CharY / Tilesize) - 9 & vbCrLf &
                 "Turn: " & Turn & vbCrLf &
                 "Stone: " & Stone & vbCrLf &
                 "Wood: " & Wood & vbCrLf &
                 "", Me.Font, Brushes.Black, 1050, 0)
        'Drawing Character
        Character.Startup()
        Randomize()

        NPC.DrawNPC(140, 40, Character.CharacterModel.CasinoMan, 1, True)
        NPC.DrawNPC(RandX, RandY, Character.CharacterModel.Kingsley, 2, True)




        'DRAW CONTENTS OF SCREENMANAGER
        'BaseScreen.Draw()




        'Copy back buffer to graphics object
        G = Graphics.FromImage(BB)
        'Draw Backbuffer screen
        BBG = Me.CreateGraphics
        BBG.DrawImage(BB, 0, 0, Me.Width, Me.Height)
        G.Clear(Color.DarkGreen)




    End Sub

    'Private Sub TickCounter()

    '    If tSec = TimeOfDay.Second Then
    '        tTicks = tTicks + 1
    '    Else
    '        MaxTicks = tTicks
    '        tTicks = 0
    '        tSec = TimeOfDay.Second
    '    End If
    'End Sub


    Private Sub MapGenerator_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        MouseX = Math.Floor(e.X / Tilesize)
        MouseY = Math.Floor(e.Y / Tilesize)

        mMapX = MouseX
        mMapY = MouseY


    End Sub
    Enum blockID
        Grass = 0
        Trees1 = 1
        Trees2 = 2
        Dandilions = 3
        VioletPlants = 4
        Poppies = 5
        Mountains = 6
        OceanTile1 = 7
        OceanTile2 = 8
        OceanTile3 = 9
        OceanTile4 = 10
        SahraGrass = 11
        SahraMountain = 12
        SahraOasis = 13
        SahraCactus = 14
        DesertFlowers = 15
        DesertRiver1 = 16
        DesertRiver2 = 17
        SnowBiomeFloor = 18
        SnowBiomeMountains = 19
        SnowBiomeTree = 20
        SnowBiomeBlueFlower = 21
        SnowBiomeIceFloor = 22
        SnowBiomeRedFlower = 23
        SnowBiomeBlueFlowerPot = 24
        SnowBiomeRedFlowerPot = 25
        WoodPlank = 27
        Cobblestone = 28

    End Enum
    Public Sub GetSourceBlock(ByVal x As Integer, ByVal y As Integer, ByVal TileSize As Integer)


        Select Case Map(x, y, 0)
            Case blockID.Grass 'Grass
                SRect = New Rectangle(0, 0, TileSize, TileSize)
                Map(x, y, 1) = 0
            Case blockID.Trees1 ' Trees1
                SRect = New Rectangle(64, 0, TileSize, TileSize)
                Map(x, y, 1) = 1 'Impassible
            Case blockID.Trees2 ' Trees2
                SRect = New Rectangle(96, 0, TileSize, TileSize)
                Map(x, y, 1) = 1 'Impassible

            Case blockID.Dandilions ' Dandilions
                SRect = New Rectangle(0, 64, TileSize, TileSize)
                Map(x, y, 1) = 0
            Case blockID.VioletPlants ' Violet plants
                SRect = New Rectangle(32, 32, TileSize, TileSize)
                Map(x, y, 1) = 0
            Case blockID.Poppies ' Poppies
                SRect = New Rectangle(32, 64, TileSize, TileSize)
                Map(x, y, 1) = 0
            Case blockID.Mountains 'Mountains
                SRect = New Rectangle(0, 32, TileSize, TileSize)
                Map(x, y, 1) = 1
            Case blockID.OceanTile1 'OceanTile1
                SRect = New Rectangle(64, 64, TileSize, TileSize)
                Map(x, y, 1) = 1
            Case blockID.OceanTile2 'OceanTile2  
                SRect = New Rectangle(96, 64, TileSize, TileSize)
                Map(x, y, 1) = 1
            Case blockID.OceanTile3 'OceanTile3
                SRect = New Rectangle(64, 96, TileSize, TileSize)
                Map(x, y, 1) = 1
            Case blockID.OceanTile4 'OceanTile4
                SRect = New Rectangle(96, 96, TileSize, TileSize)
                Map(x, y, 1) = 1
            Case blockID.SahraGrass 'Sahra Grass
                SRect = New Rectangle(128, 64, TileSize, TileSize)
                Map(x, y, 1) = 0
            Case blockID.SahraMountain 'Sahra Mountain
                SRect = New Rectangle(128, 96, TileSize, TileSize)
                Map(x, y, 1) = 1
            Case blockID.SahraOasis ' Sahra Oasis
                SRect = New Rectangle(128, 0, TileSize, TileSize)
                Map(x, y, 1) = 0
            Case blockID.SahraCactus ' Sahra Cactus 
                SRect = New Rectangle(128, 32, TileSize, TileSize)
                Map(x, y, 1) = 0
            Case blockID.DesertFlowers 'Desert flowers
                SRect = New Rectangle(160, 0, TileSize, TileSize)
                Map(x, y, 1) = 0
            Case blockID.DesertRiver1 'Desert River1
                SRect = New Rectangle(160, 32, TileSize, TileSize)
                Map(x, y, 1) = 1
            Case blockID.DesertRiver2 'Desert River2
                SRect = New Rectangle(160, 64, TileSize, TileSize)
                Map(x, y, 1) = 1
            Case blockID.SnowBiomeFloor 'Snow Biome Floor
                SRect = New Rectangle(96, 128, TileSize, TileSize)
                Map(x, y, 1) = 0
            Case blockID.SnowBiomeMountains 'Snow Biome Mountain
                SRect = New Rectangle(128, 128, TileSize, TileSize)
                Map(x, y, 1) = 1
            Case blockID.SnowBiomeTree 'Snow biome Tree
                SRect = New Rectangle(96, 160, TileSize, TileSize)
                Map(x, y, 1) = 1
            Case blockID.SnowBiomeBlueFlower 'Snow biome Blue flower
                SRect = New Rectangle(128, 160, TileSize, TileSize)
                Map(x, y, 1) = 0
            Case blockID.SnowBiomeIceFloor 'Snow biome Icefloor
                SRect = New Rectangle(160, 160, TileSize, TileSize)
                Map(x, y, 1) = 0
            Case blockID.SnowBiomeRedFlower 'Snow biome Red Flower
                SRect = New Rectangle(160, 128, TileSize, TileSize)
                Map(x, y, 1) = 0
            Case blockID.SnowBiomeBlueFlowerPot 'Snow biome Blue Flower Pot
                SRect = New Rectangle(64, 160, TileSize, TileSize)
                Map(x, y, 1) = 0
            Case blockID.SnowBiomeRedFlowerPot 'Snow biome Red Flower Pot
                SRect = New Rectangle(160, 96, TileSize, TileSize)
                Map(x, y, 1) = 0
            Case Character.CharacterModel.CasinoMan 'Casino NPC
                SRect = New Rectangle(0, 96, TileSize, TileSize)
                Map(x, y, 1) = 1


            Case blockID.WoodPlank 'WoodPlank
                SRect = New Rectangle(0, 160, TileSize, TileSize)
                Map(x, y, 1) = 0
            Case blockID.Cobblestone 'Stone
                SRect = New Rectangle(32, 160, TileSize, TileSize)
                Map(x, y, 1) = 1
            Case Character.CharacterModel.Kingsley 'KingsleyNPC
                SRect = New Rectangle(0, 224, TileSize, TileSize)
                Map(x, y, 1) = 0
            Case Character.CharacterModel.Princess 'Princess NPC
                SRect = New Rectangle(32, 192, TileSize, TileSize)
                Map(x, y, 1) = 0
            Case Character.ItemModel.HealthPot 'Health Pot
                SRect = New Rectangle(64, 192, TileSize, TileSize)
                Map(x, y, 1) = 0
            Case Character.ItemModel.Sword 'Sword
                SRect = New Rectangle(92, 192, TileSize, TileSize)
                Map(x, y, 1) = 0
            Case Character.CharacterModel.Paladin 'Paladin NPC
                SRect = New Rectangle(128, 192, TileSize, TileSize)
                Map(x, y, 1) = 0
            Case Character.CharacterModel.Firemage 'FireMage NPC
                SRect = New Rectangle(160, 192, TileSize, TileSize)
                Map(x, y, 1) = 0
        End Select

    End Sub

    Public Sub MapGenerator_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Me.MouseDoubleClick
        Character.PlaceBlock()
    End Sub

    Public Sub Movement(ByVal dir As Integer) 'byval x, byval y
        Select Case dir
            Case 1
                If IsBlocked() = False Then
                    YPos += MovementSpeed
                    CharY -= MovementSpeed
                    If YPos >= Tilesize Then
                        YPos = 0
                        MapY -= 1
                    End If
                Else

                End If
            Case 2
                If IsBlocked() = False Then
                    XPos += MovementSpeed
                    CharX -= MovementSpeed
                    If XPos >= Tilesize Then
                        XPos = 0
                        MapX -= 1
                    End If
                Else

                End If

            Case 3
                If IsBlocked() = False Then
                    YPos -= MovementSpeed
                    CharY += MovementSpeed
                    If YPos <= Tilesize * -1 Then
                        YPos = 0
                        MapY += 1
                    End If
                Else

                End If
            Case 4
                If IsBlocked() = False Then
                    XPos -= MovementSpeed
                    CharX += MovementSpeed
                    If XPos <= Tilesize * -1 Then
                        XPos = 0
                        MapX += 1

                    End If
                Else
                End If

        End Select
        'If (mMapX = XPos And mMapY = YPos - 1 Or mMapX = XPos And mMapY = YPos + 1 Or mMapX = XPos + 1 And mMapY = YPos Or mMapX = XPos - 1 And mMapY = YPos) Then
        'XPos = 0
        'YPos = 0
        'XPos = XPos + mMapX
        'YPos = YPos + mMapY
        'Turn += 1
        'End If




    End Sub
    Private Function IsBlocked()

        Select Case dir
            Case 1 'North
                If Map(CharX / Tilesize, Math.Ceiling(CharY / Tilesize) - 1, 1) = 1 Then
                    Return True
                End If
            Case 2 'West
                If Map(Math.Ceiling(CharX / Tilesize) - 1, CharY / Tilesize, 1) = 1 Then
                    Return True
                End If
            Case 3 'South
                If Map(CharX / Tilesize, Math.Floor(CharY / Tilesize) + 1, 1) = 1 Then
                    Return True
                End If
            Case 4 'East
                If Map(Math.Floor(CharX / Tilesize) + 1, CharY / Tilesize, 1) = 1 Then
                    Return True
                End If
        End Select
        Return False
    End Function
    Public Sub LoadMap(ByVal MapFile As String)
        Try
            Dim sr As New IO.StreamReader(MapFile)
            Dim strLine As String = ""
            Dim x As Integer = 0
            Dim y As Integer = 0

            Do Until sr.EndOfStream
                strLine = sr.ReadLine
                strLine = strLine.Replace(strLine.LastIndexOf(","), "")

                For Each item As String In Split(strLine, ",", -1)
                    If item = "" Then
                        item = 0
                    End If
                    If x <= MapWidth Then
                        Map(x, y, 0) = Int(item)


                    End If
                    x += 1
                Next
                x = 0
                y += 1

            Loop
            sr.Close()
            sr.Dispose()

        Catch ex As Exception
            MsgBox("Map '" & MapFile & "' could not be Loaded." & vbCrLf & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR")

        End Try
    End Sub

    Private Sub MapGenerator_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp, Button1.KeyDown, Button1.KeyUp, CmdRandom.KeyUp, CmdRandom.KeyDown, CharModel5.KeyUp, CharModel5.KeyDown, CharModel4.KeyUp, CharModel4.KeyDown, CharModel3.KeyUp, CharModel3.KeyDown, CharModel2.KeyUp, CharModel2.KeyDown, CharModel1.KeyUp, CharModel1.KeyDown
        dir = 0
        InvOpen = False
    End Sub

    Public Sub BreakBlock()


        BlocksBroken += 1

        Select Case LastDir

            Case 1
                If Map(CharX / Tilesize, Math.Ceiling(CharY / Tilesize) - 1, 0) = 7 Or Map(CharX / Tilesize, Math.Ceiling(CharY / Tilesize) - 1, 0) = 8 Or Map(CharX / Tilesize, Math.Ceiling(CharY / Tilesize) - 1, 0) = 9 Or Map(CharX / Tilesize, Math.Ceiling(CharY / Tilesize) - 1, 0) = 10 Then
                Else

                    Select Case Map(CharX / Tilesize, Math.Ceiling(CharY / Tilesize) - 1, 0)
                        Case 1
                            Wood += 1
                        Case 2
                            Wood += 1
                        Case 3
                            Flowers += 1
                        Case 4
                            Flowers += 1
                        Case 5
                            Flowers += 1
                        Case 6
                            Stone += 1
                        Case 12
                            Stone += 1
                        Case 14
                            Cactus += 1
                        Case 19
                            Stone += 1
                        Case 20
                            Wood += 1
                    End Select
                    Select Case Map(CharX / Tilesize, Math.Ceiling(CharY / Tilesize) - 1, 2)
                        Case 1
                            Map(CharX / Tilesize, Math.Ceiling(CharY / Tilesize) - 1, 0) = 0
                        Case 2
                            Map(CharX / Tilesize, Math.Ceiling(CharY / Tilesize) - 1, 0) = 11
                        Case 3
                            Map(CharX / Tilesize, Math.Ceiling(CharY / Tilesize) - 1, 0) = 18
                    End Select


                End If


            Case 2

                If Map(Math.Ceiling(CharX / Tilesize) - 1, CharY / Tilesize, 0) = 7 Or Map(Math.Ceiling(CharX / Tilesize) - 1, CharY / Tilesize, 0) = 8 Or Map(Math.Ceiling(CharX / Tilesize) - 1, CharY / Tilesize, 0) = 9 Or Map(Math.Ceiling(CharX / Tilesize) - 1, CharY / Tilesize, 0) = 10 Then
                Else
                    Select Case Map(Math.Ceiling(CharX / Tilesize) - 1, CharY / Tilesize, 0)
                        Case 1
                            Wood += 1
                        Case 2
                            Wood += 1
                        Case 3
                            Flowers += 1
                        Case 4
                            Flowers += 1
                        Case 5
                            Flowers += 1
                        Case 6
                            Stone += 1
                        Case 12
                            Stone += 1
                        Case 14
                            Cactus += 1
                        Case 19
                            Stone += 1
                        Case 20
                            Wood += 1

                    End Select
                    Select Case Map(Math.Ceiling(CharX / Tilesize) - 1, CharY / Tilesize, 2)
                        Case 1
                            Map(Math.Ceiling(CharX / Tilesize) - 1, CharY / Tilesize, 0) = 0
                        Case 2
                            Map(Math.Ceiling(CharX / Tilesize) - 1, CharY / Tilesize, 0) = 11
                        Case 3
                            Map(Math.Ceiling(CharX / Tilesize) - 1, CharY / Tilesize, 0) = 18
                    End Select
                End If

            Case 3
                If Map(CharX / Tilesize, Math.Floor(CharY / Tilesize) + 1, 0) = 7 Or Map(CharX / Tilesize, Math.Floor(CharY / Tilesize) + 1, 0) = 8 Or Map(CharX / Tilesize, Math.Floor(CharY / Tilesize) + 1, 0) = 9 Or Map(CharX / Tilesize, Math.Floor(CharY / Tilesize) + 1, 0) = 10 Then
                Else
                    Select Case Map(CharX / Tilesize, Math.Floor(CharY / Tilesize) + 1, 0)
                        Case 1
                            Wood += 1
                        Case 2
                            Wood += 1
                        Case 3
                            Flowers += 1
                        Case 4
                            Flowers += 1
                        Case 5
                            Flowers += 1
                        Case 6
                            Stone += 1
                        Case 12
                            Stone += 1
                        Case 14
                            Cactus += 1
                        Case 19
                            Stone += 1
                        Case 20
                            Wood += 1
                    End Select
                    Select Case Map(CharX / Tilesize, Math.Floor(CharY / Tilesize) + 1, 2)
                        Case 1
                            Map(CharX / Tilesize, Math.Floor(CharY / Tilesize) + 1, 0) = 0
                        Case 2
                            Map(CharX / Tilesize, Math.Floor(CharY / Tilesize) + 1, 0) = 11
                        Case 3
                            Map(CharX / Tilesize, Math.Floor(CharY / Tilesize) + 1, 0) = 18
                    End Select

                End If

            Case 4

                If Map(Math.Floor(CharX / Tilesize) + 1, CharY / Tilesize, 0) = 7 Or Map(Math.Floor(CharX / Tilesize) + 1, CharY / Tilesize, 0) = 8 Or Map(Math.Floor(CharX / Tilesize) + 1, CharY / Tilesize, 0) = 9 Or Map(Math.Floor(CharX / Tilesize) + 1, CharY / Tilesize, 0) = 10 Then
                Else
                    Select Case Map(Math.Floor(CharX / Tilesize) + 1, CharY / Tilesize, 0)
                        Case 1
                            Wood += 1
                        Case 2
                            Wood += 1
                        Case 3
                            Flowers += 1
                        Case 4
                            Flowers += 1
                        Case 5
                            Flowers += 1
                        Case 6
                            Stone += 1
                        Case 12
                            Stone += 1
                        Case 14
                            Cactus += 1
                        Case 19
                            Stone += 1
                        Case 20
                            Wood += 1
                    End Select
                    Select Case Map(Math.Floor(CharX / Tilesize) + 1, CharY / Tilesize, 2)
                        Case 1
                            Map(Math.Floor(CharX / Tilesize) + 1, CharY / Tilesize, 0) = 0
                        Case 2
                            Map(Math.Floor(CharX / Tilesize) + 1, CharY / Tilesize, 0) = 11
                        Case 3
                            Map(Math.Floor(CharX / Tilesize) + 1, CharY / Tilesize, 0) = 18
                    End Select

                End If

        End Select
        If Map(Math.Floor(CharX / Tilesize) + 1, CharY / Tilesize, 4) = 1 Then
            Roulette.Show()
        ElseIf Map(Math.Floor(CharX / Tilesize) + 1, CharY / Tilesize, 4) = 2 Then
            KingsleyInterface.Show()
        End If
        If Map(Math.Floor(CharX / Tilesize) - 1, CharY / Tilesize, 4) = 1 Then
            Roulette.Show()
        ElseIf Map(Math.Floor(CharX / Tilesize) - 1, CharY / Tilesize, 4) = 2 Then
            KingsleyInterface.Show()
        End If
        If Map(Math.Floor(CharX / Tilesize), (CharY / Tilesize) + 1, 4) = 1 Then
            Roulette.Show()
        ElseIf Map(Math.Floor(CharX / Tilesize), (CharY / Tilesize) + 1, 4) = 2 Then
            KingsleyInterface.Show()
        End If
        If Map(Math.Floor(CharX / Tilesize), (CharY / Tilesize) - 1, 4) = 1 Then
            Roulette.Show()
        ElseIf Map(Math.Floor(CharX / Tilesize), (CharY / Tilesize) - 1, 4) = 2 Then
            KingsleyInterface.Show()

        End If
    End Sub

    Sub PlaceBlock()
        Select Case LastDir

            Case 1

                If Map(CharX / Tilesize, Math.Ceiling(CharY / Tilesize) - 1, 0) = 7 Or Map(CharX / Tilesize, Math.Ceiling(CharY / Tilesize) - 1, 0) = 8 Or Map(CharX / Tilesize, Math.Ceiling(CharY / Tilesize) - 1, 0) = 9 Or Map(CharX / Tilesize, Math.Ceiling(CharY / Tilesize) - 1, 0) = 10 Then
                Else
                    If Map(CharX / Tilesize, Math.Ceiling(CharY / Tilesize) - 1, 0) = 0 Or Map(CharX / Tilesize, Math.Ceiling(CharY / Tilesize) - 1, 0) = 11 Or Map(CharX / Tilesize, Math.Ceiling(CharY / Tilesize) - 1, 0) = 18 Then
                        If BlockInHand = "Wood" Then
                            If Wood > 0 Then
                                Map(CharX / Tilesize, Math.Ceiling(CharY / Tilesize) - 1, 0) = 27
                                Wood -= 1
                            Else
                            End If

                        ElseIf BlockInHand = "Stone" Then
                            If Stone > 0 Then
                                Map(CharX / Tilesize, Math.Ceiling(CharY / Tilesize) - 1, 0) = 28
                                Stone -= 1
                            Else
                            End If

                        End If
                    End If
                End If


            Case 2


                If Map(Math.Ceiling(CharX / Tilesize) - 1, CharY / Tilesize, 0) = 7 Or Map(Math.Ceiling(CharX / Tilesize) - 1, CharY / Tilesize, 0) = 8 Or Map(Math.Ceiling(CharX / Tilesize) - 1, CharY / Tilesize, 0) = 9 Or Map(Math.Ceiling(CharX / Tilesize) - 1, CharY / Tilesize, 0) = 10 Or Map(CharX / Tilesize, Math.Ceiling(CharY / Tilesize) - 1, 0) = 18 Then
                Else
                    If Map(Math.Ceiling(CharX / Tilesize) - 1, CharY / Tilesize, 0) = 0 Or Map(Math.Ceiling(CharX / Tilesize) - 1, CharY / Tilesize, 0) = 11 Then
                        If BlockInHand = "Wood" Then
                            If Wood > 0 Then
                                Map(Math.Ceiling(CharX / Tilesize) - 1, CharY / Tilesize, 0) = 27
                                Wood -= 1
                            Else
                            End If
                        ElseIf BlockInHand = "Stone" Then
                            If Stone > 0 Then
                                Map(Math.Ceiling(CharX / Tilesize) - 1, CharY / Tilesize, 0) = 28
                                Stone -= 1
                            Else

                            End If
                        End If
                    End If
                End If

            Case 3

                If Map(CharX / Tilesize, Math.Floor(CharY / Tilesize) + 1, 0) = 7 Or Map(CharX / Tilesize, Math.Floor(CharY / Tilesize) + 1, 0) = 8 Or Map(CharX / Tilesize, Math.Floor(CharY / Tilesize) + 1, 0) = 9 Or Map(CharX / Tilesize, Math.Floor(CharY / Tilesize) + 1, 0) = 10 Or Map(CharX / Tilesize, Math.Ceiling(CharY / Tilesize) - 1, 0) = 18 Then
                Else
                    If Map(CharX / Tilesize, Math.Floor(CharY / Tilesize) + 1, 0) = 0 Or Map(CharX / Tilesize, Math.Floor(CharY / Tilesize) + 1, 0) = 11 Then
                        If Wood > 0 Then
                            If BlockInHand = "Wood" Then
                                Map(CharX / Tilesize, Math.Floor(CharY / Tilesize) + 1, 0) = 27
                                Wood -= 1
                                If Stone > 0 Then
                                ElseIf BlockInHand = "Stone" Then
                                    Map(CharX / Tilesize, Math.Floor(CharY / Tilesize) + 1, 0) = 28
                                    Stone -= 1
                                End If
                            End If
                        End If
                    End If
                End If
            Case 4

                If Map(Math.Floor(CharX / Tilesize) + 1, CharY / Tilesize, 0) = 7 Or Map(Math.Floor(CharX / Tilesize) + 1, CharY / Tilesize, 0) = 8 Or Map(Math.Floor(CharX / Tilesize) + 1, CharY / Tilesize, 0) = 9 Or Map(Math.Floor(CharX / Tilesize) + 1, CharY / Tilesize, 0) = 10 Or Map(CharX / Tilesize, Math.Ceiling(CharY / Tilesize) - 1, 0) = 18 Then
                Else
                    If Map(Math.Floor(CharX / Tilesize) + 1, CharY / Tilesize, 0) = 0 Or Map(Math.Floor(CharX / Tilesize) + 1, CharY / Tilesize, 0) = 11 Then
                        If Wood > 0 Then
                            If BlockInHand = "Wood" Then
                                Map(Math.Floor(CharX / Tilesize) + 1, CharY / Tilesize, 0) = 27
                                If Stone > 0 Then
                                ElseIf BlockInHand = "Stone" Then
                                    Map(Math.Floor(CharX / Tilesize) + 1, CharY / Tilesize, 0) = 28
                                    Stone -= 1
                                End If
                            End If
                        End If
                    End If
                End If

        End Select

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim SaveGameFile
        OpenFileDialog1.ShowDialog()
        lblFile.Text = OpenFileDialog1.FileName.Replace("C:\Users\oskar\OneDrive\Documents\Computer Science NEA\Project Zombified\Project Zombified\bin\Debug\net5.0-windows\", "")
        SaveGameFile = lblFile.Text.Replace("C:\Users\oskar\OneDrive\Documents\Computer Science NEA\Project Zombified\Project Zombified\bin\Debug\net5.0-windows\", "")
        LoadMap(SaveGameFile)

    End Sub
    Public Sub MapGenerator_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress, Button1.KeyPress, CmdRandom.KeyPress, CharModel5.KeyPress, CharModel4.KeyPress, CharModel3.KeyPress, CharModel2.KeyPress, CharModel1.KeyPress, SaveButton.KeyPress
        Select Case e.KeyChar
            Case "w"
                Turn += 1
                dir = 1
                LastDir = 1
                Character.dir = 1
                Character.LastDir = 1
            Case "a"
                Turn += 1
                dir = 2
                LastDir = 2
                Character.dir = 2
                Character.LastDir = 2
            Case "s"
                Turn += 1
                dir = 3
                LastDir = 3
                Character.dir = 3
                Character.LastDir = 3
            Case "d"
                Turn += 1
                dir = 4
                LastDir = 4
                Character.dir = 4
                Character.LastDir = 4
            Case "1"
                BlockInHand = "Wood"
            Case "2"
                BlockInHand = "Stone"
            Case "u"

                SaveButton.Visible = False
                SaveName.Visible = False
                CharModel5.Visible = False
                CharModel4.Visible = False
                CharModel3.Visible = False
                CharModel2.Visible = False
                CharModel1.Visible = False
                lblFile.Visible = False
                Button1.Visible = False
                CmdRandom.Visible = False
                Stats.Visible = False
            Case "v"
                SaveButton.Visible = True
                SaveName.Visible = True
                CharModel5.Visible = True
                CharModel4.Visible = True
                CharModel3.Visible = True
                CharModel2.Visible = True
                CharModel1.Visible = True
                lblFile.Visible = True
                Button1.Visible = True
                CmdRandom.Visible = True
                Stats.Visible = True


        End Select

        Select Case e.KeyChar
            Case "e"
                ' BlocksBroken += 1
                'If Map(x, y + 1, 1) = 1 Or Map(x - 1, y, 1) = 1 Or Map(x, y - 1, 1) = 1 Or Map(x + 1, y, 1) = 1 = True Then '
                ' BlockHit = True

                BreakBlock()

            Case "f"
                PlaceBlock()
            Case "i"
                InvInterface.Show()
                InvInterface.UpdateInv()

        End Select

    End Sub

    Private Sub Stats_Click(sender As Object, e As EventArgs) Handles Stats.Click
        CharacterCreation.Show()

    End Sub

    Private Function Rand() As Integer
        Randomize()
        Dim rnd As New Random

        Dim RndNumb As Integer = rnd.Next(0, 150)
        Return RndNumb
    End Function
    Private Sub lblFile_Click(sender As Object, e As EventArgs) Handles lblFile.Click

    End Sub


    Private Sub GenerateRandomMap()
        SRect = New Rectangle(32, 0, Tilesize, Tilesize)
        Dim rnd As New Random
        Dim TileCounter, LastRnd, rndnumb As Integer

        Dim RandX, RandY, Count As Integer

        ' Powerflower = New Bitmap(GFX.ItemsGraphics.BackgroundImage, 0, 32, )

        HealthPot = New Bitmap(GFX.ItemsGraphics.BackgroundImage)
        Sword = New Bitmap(GFX.ItemsGraphics.BackgroundImage)
        For x = 0 To (MapWidth / 2) - 3
            For y = 0 To (MapHeight / 2) - 3
                If rndnumb = LastRnd Then
                    rndnumb = rnd.Next(0, 16)
                End If


                LastRnd = rndnumb
                If rndnumb = 0 Or rndnumb = 1 Or rndnumb = 2 Or rndnumb = 3 Or rndnumb = 4 Or rndnumb = 5 Or rndnumb = 6 Then
                    For i = 1 To 4
                        Map(x + 1, y + 1, 2) = 1
                        Map(x + 1, y + 1, 0) = rndnumb


                    Next

                End If


                If rndnumb = 9 Or rndnumb = 10 Then

                End If
            Next
        Next
        For x = (MapWidth / 3) - 3 To MapWidth - 3
            TileCounter += 1
            For y = (MapHeight / 3) - 3 To MapHeight - 3
                rndnumb = 0
                If rndnumb = LastRnd Then
                    rndnumb = rnd.Next(11, 18)
                End If

                LastRnd = rndnumb
                If rndnumb = 11 Or rndnumb = 12 Or rndnumb = 13 Or rndnumb = 14 Or rndnumb = 15 Then
                    If rndnumb = 16 Or rndnumb = 17 Then
                        Map(x, y, 0) = 16
                        Map(x, y - 1, 0) = 17

                    Else
                        For i = 1 To 4
                            Map(x + 1, y + 1, 2) = 2
                            Map(x + 1, y + 1, 0) = rndnumb
                        Next
                    End If

                End If

            Next





        Next

        For x = (MapWidth / 4) - 3 To MapWidth / 2 - 3

            TileCounter += 1
            For y = (MapHeight / 4) - 3 To MapHeight / 2 - 3
                If rndnumb = LastRnd Then
                    rndnumb = rnd.Next(18, 24)
                End If

                LastRnd = rndnumb
                If rndnumb = 18 Or rndnumb = 19 Or rndnumb = 20 Or rndnumb = 21 Or rndnumb = 22 Or rndnumb = 23 Then
                    Map(x + 1, y + 1, 2) = 3
                        Map(x + 1, y + 1, 0) = rndnumb




                End If



            Next
        Next
        For x = (MapWidth / 3) - 3 To MapWidth - 3
            For y = (MapHeight / 3) - 3 To MapHeight - 3
                If Map(x, y, 0) = 0 Or Map(x, y, 0) = 1 Or Map(x, y, 0) = 2 Or Map(x, y, 0) = 3 Or Map(x, y, 0) = 4 Or Map(x, y, 0) = 5 Or Map(x, y, 0) = 6 Or Map(x, y, 0) = 7 Or Map(x, y, 0) = 8 Or Map(x, y, 0) = 9 Or Map(x, y, 0) = 10 Then
                    Map(x, y, 0) = 11
                End If
            Next
        Next

        'Generates sea tile boarder
        For x = 18 To MapX + 18
            Map(x, 0, 0) = rnd.Next(7, 10)
            Map(x, MapX + 12, 0) = rnd.Next(7, 10)
        Next
        For y = 11 To MapY + 11
            Map(0, y, 0) = rnd.Next(7, 10)
            Map(MapY + 19, y, 0) = rnd.Next(7, 10)
        Next
        For i = 0 To 10
            If Count > 3 Then
                Count += 1
                RandX = Rand()
                RandY = Rand()
                Map(RandX, RandY, 0) = 24
            ElseIf Count > 7 Then
                Count += 1
                RandX = Rand()
                RandY = Rand()
                Map(RandX, RandY, 0) = 25
            End If
        Next
        Map(125, 125, 0) = 25
        'Random Item Generation
        Sword.MakeTransparent(Color.Magenta)
        HealthPot.MakeTransparent(Color.Magenta)
        'Powerflower.MakeTransparent(Color.Magenta)
        'G.DrawImage(HealthPot, 16 * Tilesize, 1 * Tilesize, SRect, GraphicsUnit.Pixel)

    End Sub
    Public Sub SaveCharacter(ByVal CharacterFile As String)

        Try
            Dim sw As New IO.StreamWriter(CharacterFile & "character" & ".IWantToSmashMyHeadAgainstAWall")
            Dim strLine As String = ""

            strLine = strLine & "," & Stone & "," & Wood & "," & Flowers & "," & Cactus & "," & Character.PlayerCoinBalance & "," & Character.HasSword

            sw.WriteLine(strLine)
            strLine = ""
            sw.Close()
            sw.Dispose()
            MsgBox("Character '" & CharacterFile & "' successfully saved.", MsgBoxStyle.OkOnly, "SUCCESS")

        Catch ex As Exception
            MsgBox("Character '" & CharacterFile & "' could not be written to." & vbCrLf & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR")

        End Try
    End Sub
    Public Sub LoadCharacter(ByVal CharacterFile As String)
        Try
            Dim sr As New IO.StreamReader(CharacterFile)
            Dim strLine As String = ""


            Do Until sr.EndOfStream
                strLine = sr.ReadLine
                strLine = strLine.Replace(strLine.LastIndexOf(","), "")

            Loop
            sr.Close()
            sr.Dispose()

        Catch ex As Exception
            MsgBox("Map '" & CharacterFile & "' could not be Loaded." & vbCrLf & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR")

        End Try
    End Sub
    Private Sub SaveMap(ByVal MapFile As String)
        Try
            Dim sw As New IO.StreamWriter(MapFile & ".IWantToSmashMyHeadAgainstAWall")
            Dim strLine As String = ""
            Dim x As Integer = 0
            Dim y As Integer = 0
            For y = 0 To MapHeight
                For x = 0 To MapWidth
                    strLine = strLine & Map(x, y, 0) & ","
                Next

                sw.WriteLine(strLine)
                strLine = ""

            Next
            sw.Close()
            sw.Dispose()
            MsgBox("Map '" & MapFile & "' successfully saved.", MsgBoxStyle.OkOnly, "SUCCESS")

        Catch ex As Exception
            MsgBox("Map '" & MapFile & "' could not be written to." & vbCrLf & vbCrLf & ex.Message, MsgBoxStyle.Critical, "ERROR")

        End Try

    End Sub

    public Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim GameSaveName As String
        GameSaveName = SaveName.Text
        CharacterFile = SaveName.Text
        SaveMap(GameSaveName)
        SaveCharacter(CharacterFile)
    End Sub
    Public Sub CharModel1_Click(sender As Object, e As EventArgs) Handles CharModel1.Click
        Character.CharModel = 0
        Character.CharModel += 0
    End Sub

    Public Sub CharModel2_Click(sender As Object, e As EventArgs) Handles CharModel2.Click
        Character.CharModel = 0
        Character.CharModel += 1
    End Sub

    Public Sub CharModel3_Click(sender As Object, e As EventArgs) Handles CharModel3.Click
        Character.CharModel = 0
        Character.CharModel += 2
    End Sub
    Public Sub CharModel4_Click(sender As Object, e As EventArgs) Handles CharModel4.Click
        Character.CharModel = 0
        Character.CharModel += 3
    End Sub

    Public Sub CharModel5_Click(sender As Object, e As EventArgs) Handles CharModel5.Click
        Character.CharModel = 0
        Character.CharModel += 4
    End Sub

    Public Sub RouletteNPCTimer_Tick(sender As Object, e As EventArgs) Handles RouletteNPCTimer.Tick


        Seconds += 1
        If Seconds = 3 Then
            MoveTime += 1
            Seconds = 0
            If MoveTime = 4 Then
                MoveTime = 0
            End If
        End If
    End Sub
End Class