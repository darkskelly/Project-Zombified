Public Class MapEditor
    Dim Box(12, 12) As PictureBox
    'Mouse Locations
    Dim MouseX As Integer
    Dim MouseY As Integer
    Dim mMapX As Integer
    Dim mMapY As Integer
    'Fps Counter
    Dim tSec As Integer = TimeOfDay.Second
    Dim tTicks As Integer = 0
    Dim MaxTicks As Integer = 0
    'Map Variables
    Dim MapWidth As Integer = 96
    Dim MapHeight As Integer = 96
    Dim Map(MapWidth, MapHeight, 6) As Integer

    Dim MapX As Integer = 48
    Dim MapY As Integer = 48
    Dim Tilesize As Integer = 32
    Dim x As Object
    Dim y As Object
    'Graphics Variables
    Dim G As Graphics
    Dim BBG As Graphics 'To stop flickering with characters
    Dim BB As Bitmap
    Dim BmpTile As Bitmap
    Dim SRect As Rectangle
    Dim DRect As Rectangle
    'Game running
    Dim IsRunning As Boolean = True
    'Character Variables
    Dim BmpChar As Bitmap
    Dim XPos As Integer = 6
    Dim YPos As Integer = 9
    Dim CharX As Integer = (MapX + 6) * Tilesize
    Dim CharY As Integer = (MapY + 9) * Tilesize
    Dim Turn As Integer
    Dim CharModel As Integer = 2
    Dim MovementSpeed As Integer = 8
    Dim dir As Integer
    'Key Detection
    Dim KeyPushed As Short = 0
    'PaintBrush
    Dim PBrush As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()
        Me.Focus()
        LoadMap("BoarderMap.IWantToSmashMyHeadAgainstAWall")
        'intiialising Game
        G = Me.CreateGraphics
        BB = New Bitmap(Me.Width, Me.Height)
        BmpTile = New Bitmap(GFX.pbGFX.BackgroundImage)



    End Sub
    Public Sub StartGame()
        Do While IsRunning = True
            Movement(dir)
            Application.DoEvents()
            TickCounter()
            BuildMap()
        Loop
    End Sub
    Private Class Player


    End Class
    Public Sub BuildMap()

        For x = -1 To 48
            For y = -1 To 48
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
        'Menu, Characters
        G.DrawRectangle(Pens.Red, MouseX * Tilesize, MouseY * Tilesize, Tilesize, Tilesize)
        G.DrawString("Ticks: " & tTicks & vbCrLf &
                  "TPS: " & MaxTicks & vbCrLf &
                  "Map X: " & mMapX & vbCrLf &
                 " Y: " & mMapY & vbCrLf &
                 "Char X pos: " & (CharX / Tilesize) - 6 & vbCrLf &
                 "Char Y pos: " & (CharY / Tilesize) - 9 & vbCrLf &
                 "Turn: " & Turn & vbCrLf &
                 "", Me.Font, Brushes.Black, 650, 0)
        'Drawing Character
        GetCharacter()
        BmpChar.MakeTransparent(Color.Magenta)
        G.DrawImage(BmpChar, 6 * Tilesize, 9 * Tilesize, SRect, GraphicsUnit.Pixel) 'c
        'Copy back buffer to graphics object
        G = Graphics.FromImage(BB)
        'Draw Backbuffer screen
        BBG = Me.CreateGraphics
        BBG.DrawImage(BB, 0, 0, Me.Width, Me.Height)
        G.Clear(Color.DarkGreen)
        'Map Editor
        Map(50, 24, 0) = 0 'grass
        Map(50, 25, 0) = 1 'tree
        Map(50, 26, 0) = 2 'dandilions
        Map(50, 27, 0) = 3 'violet plant
        Map(50, 28, 0) = 4 'poppies
        G.FillRectangle(Brushes.LawnGreen, 13 * Tilesize, 0 * Tilesize, Tilesize, Tilesize)
        G.FillRectangle(Brushes.ForestGreen, 13 * Tilesize, 1 * Tilesize, Tilesize, Tilesize)
        G.FillRectangle(Brushes.Yellow, 13 * Tilesize, 2 * Tilesize, Tilesize, Tilesize)
        G.FillRectangle(Brushes.Violet, 13 * Tilesize, 3 * Tilesize, Tilesize, Tilesize)
        G.FillRectangle(Brushes.Red, 13 * Tilesize, 4 * Tilesize, Tilesize, Tilesize)
    End Sub
    Private Sub GetCharacter()
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
    Private Sub TickCounter()

        If tSec = TimeOfDay.Second Then
            tTicks = tTicks + 1
        Else
            MaxTicks = tTicks
            tTicks = 0
            tSec = TimeOfDay.Second
        End If
    End Sub

    Private Sub MapGenerator_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        If mMapX = 50 And mMapY = 24 Then
            PBrush = 0
        End If
        If mMapX = 50 And mMapY = 25 Then
            PBrush = 1
        End If
        If mMapX = 50 And mMapY = 26 Then
            PBrush = 2
        End If
        If mMapX = 50 And mMapY = 27 Then
            PBrush = 3
        End If
        If mMapX = 50 And mMapY = 28 Then
            PBrush = 4
        End If
        If mMapX = 50 And mMapY = 29 Then
            PBrush = 5
        End If


        Select Case PBrush
            Case 0
                Map(mMapX, mMapY, 0) = 0
            Case 1
                Map(mMapX, mMapY, 0) = 1
                Map(mMapX, mMapY, 1) = 1

            Case 2
                Map(mMapX, mMapY, 0) = 2
            Case 3
                Map(mMapX, mMapY, 0) = 3
            Case 4
                Map(mMapX, mMapY, 0) = 4
        End Select
    End Sub

    Private Sub MapGenerator_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        MouseX = Math.Floor(e.X / Tilesize)
        MouseY = Math.Floor(e.Y / Tilesize)

        mMapX = MapX + MouseX
        mMapY = MapY + MouseY


    End Sub


    Private Sub GetSourceBlock(ByVal x As Integer, ByVal y As Integer, ByVal TileSize As Integer)
        Select Case Map(x, y, 0)
            Case 0 'Grass
                SRect = New Rectangle(32, 0, TileSize, TileSize)
                Map(x, y, 1) = 0
            Case 1 ' Trees
                SRect = New Rectangle(96, 0, TileSize, TileSize)
                Map(x, y, 1) = 1 'Impassible
            Case 2 ' Dandilions
                SRect = New Rectangle(0, 96, TileSize, TileSize)
                Map(x, y, 1) = 0
            Case 3 ' Violet plants
                SRect = New Rectangle(96, 64, TileSize, TileSize)
                Map(x, y, 1) = 0
            Case 4 ' Poppies
                SRect = New Rectangle(160, 96, TileSize, TileSize)
                Map(x, y, 1) = 0

        End Select

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim GameSaveName As String
        GameSaveName = SaveName.Text
        SaveMap(GameSaveName)
    End Sub
    Private Sub MapGenerator_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress, Button1.KeyPress

        Select Case e.KeyChar
            Case "w"
                Turn += 1
                Dir = 1
            Case "a"
                Turn += 1
                Dir = 2
            Case "s"
                Turn += 1
                Dir = 3
            Case "d"
                Turn += 1
                Dir = 4
        End Select
    End Sub
    Private Sub Movement(ByVal dir As Integer) 'byval x, byval y
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

    Private Sub MapGenerator_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp, Button1.KeyDown, Button1.KeyUp
        dir = 0
    End Sub
    Private Sub LoadMap(ByVal MapFile As String)
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
End Class
