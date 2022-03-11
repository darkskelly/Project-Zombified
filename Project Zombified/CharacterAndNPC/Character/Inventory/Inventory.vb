Public Class Inventory
    Public ItemMax As Integer = 9 'Number of inventory slots
    Public Items As New List(Of Items)
    Public Equipped As New List(Of Items)

    Public Sub Equip(Armour As Items)
        Equipped.Add(Armour)
        Items.RemoveAt(Items.IndexOf(Armour))
    End Sub
    Public Sub Add(Newitem As Items)
        If Items.Count <= ItemMax Then
            For Each I As Items In Items
                If I.Name = Newitem.Name Then
                    If I.IsStackable = True And I.ItemCount < 64 Then
                        I.ItemCount += 1
                        Exit Sub
                    Else

                        Items.Add(Newitem)
                        Exit Sub
                    End If
                End If
            Next
            Items.Add(Newitem)
        End If
    End Sub
    Public Sub Remove(ItemID As Items)
        If Items.Item(Items.IndexOf(ItemID)).ItemCount > 0 Then
            Items.Item(Items.IndexOf(ItemID)).ItemCount -= 1
        Else
            Items.RemoveAt(Items.IndexOf(ItemID))
        End If
    End Sub
    Public Sub UpdateInv()
        For i = 0 To (Items.Count - 1)
            If 0 < Items.Count Then
                Select Case (i)

                    Case 0
                        MapGenerator.Inv11.BackgroundImage = Items(i).ImageAsset
                        MapGenerator.Inv11TT.SetToolTip(MapGenerator.Inv11, Items(i).Description)

                        If Items(i).IsStackable = True Then
                            MapGenerator.Inv11Count.Text = Items(i).ItemCount + 1
                            MapGenerator.Inv11Count.Visible = True


                        End If

                    Case 1
                        MapGenerator.Inv12.BackgroundImage = Items(i).ImageAsset
                        MapGenerator.Inv12TT.SetToolTip(MapGenerator.Inv12, Items(i).Description)
                        If Items(i).IsStackable = True Then
                            MapGenerator.Inv12Count.Text = Items(i).ItemCount + 1
                            MapGenerator.Inv12Count.Visible = True
                        End If

                    Case 2
                        MapGenerator.Inv13.BackgroundImage = Items(i).ImageAsset
                        MapGenerator.Inv13TT.SetToolTip(MapGenerator.Inv13, Items(i).Description)
                        If Items(i).IsStackable = True Then
                            MapGenerator.Inv13Count.Text = Items(i).ItemCount + 1
                            MapGenerator.Inv13Count.Visible = True
                        End If

                    Case 3
                        MapGenerator.Inv21.BackgroundImage = Items(i).ImageAsset
                        MapGenerator.Inv21TT.SetToolTip(MapGenerator.Inv21, Items(i).Description)
                        If Items(i).IsStackable = True Then
                            MapGenerator.Inv21Count.Text = Items(i).ItemCount + 1
                            MapGenerator.Inv21Count.Visible = True
                        End If

                    Case 4
                        MapGenerator.Inv22.BackgroundImage = Items(i).ImageAsset
                        MapGenerator.Inv22TT.SetToolTip(MapGenerator.Inv22, Items(i).Description)
                        If Items(i).IsStackable = True Then
                            MapGenerator.Inv22Count.Text = Items(i).ItemCount + 1
                            MapGenerator.Inv22Count.Visible = True
                        End If

                    Case 5
                        MapGenerator.Inv23.BackgroundImage = Items(i).ImageAsset
                        MapGenerator.Inv23TT.SetToolTip(MapGenerator.Inv23, Items(i).Description)
                        If Items(i).IsStackable = True Then
                            MapGenerator.Inv23Count.Text = Items(i).ItemCount + 1
                            MapGenerator.Inv23Count.Visible = True
                        End If

                    Case 6
                        MapGenerator.Inv31.BackgroundImage = Items(i).ImageAsset
                        MapGenerator.Inv31TT.SetToolTip(MapGenerator.Inv31, Items(i).Description)
                        If Items(i).IsStackable = True Then
                            MapGenerator.Inv31Count.Text = Items(i).ItemCount + 1
                            MapGenerator.Inv31Count.Visible = True
                        End If

                    Case 7
                        MapGenerator.Inv32.BackgroundImage = Items(i).ImageAsset
                        MapGenerator.Inv32TT.SetToolTip(MapGenerator.Inv32, Items(i).Description)
                        If Items(i).IsStackable = True Then
                            MapGenerator.Inv32Count.Text = Items(i).ItemCount + 1
                            MapGenerator.Inv32Count.Visible = True
                        End If

                    Case 8
                        MapGenerator.Inv33.BackgroundImage = Items(i).ImageAsset
                        MapGenerator.Inv33TT.SetToolTip(MapGenerator.Inv33, Items(i).Description)
                        If Items(i).IsStackable = True Then
                            MapGenerator.Inv33Count.Text = Items(i).ItemCount + 1
                            MapGenerator.Inv33Count.Visible = True

                        End If

                End Select



            End If
        Next
    End Sub
End Class

