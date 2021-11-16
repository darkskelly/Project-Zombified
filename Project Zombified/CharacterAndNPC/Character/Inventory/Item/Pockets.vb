Public Class Pockets
    Public ItemMax As Integer = 9 'Number of inventory slots
    Public Items As New List(Of Items)
    Public Sub Add(Newitem As Items)
        If items.Count <= ItemMax Then
            For Each I As Items In items
                If I.Name = Newitem.Name Then
                    If I.IsStackable = True And I.ItemCount < 16 Then
                        I.ItemCount += 1
                        Exit Sub
                    Else
                        items.Add(Newitem)
                        Exit Sub
                    End If
                End If
            Next
            items.Add(Newitem)
        End If
    End Sub
    Public Sub Remove(ItemID As Items)
        If items.Item(items.IndexOf(ItemID)).ItemCount > 0 Then
            items.Item(items.IndexOf(ItemID)).ItemCount -= 1
        Else
            items.RemoveAt(items.IndexOf(ItemID))
        End If
    End Sub
End Class
