Public Class PlayerStorage
    Public Name As String
    Public PlayerPockets As New Pockets
    Public Sub New()
        Dim i As New Items
        Name = "Princess"
        With i
            .Item = ItemClass.Usable
            .Name = "Red Flower"
            .Description = "Heals you a little bit"
            .IsStackable = True
            .ImageAsset = My.Resources.Florance


        End With
        PlayerPockets.Add(i)
    End Sub
End Class
