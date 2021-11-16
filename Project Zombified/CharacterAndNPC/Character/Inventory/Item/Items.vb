Public Class Items
    'Textures
    Public ImageAsset As String = "Items"
    Public SRect As Rectangle

    Public Item As ItemClass
    Public Name As String
    Public Description As String
    Public IsStackable As Boolean
    Public ItemCount As Integer

End Class
Public Enum ItemClass
    Weapon
    Usable
    Specials
    Blocks
End Enum