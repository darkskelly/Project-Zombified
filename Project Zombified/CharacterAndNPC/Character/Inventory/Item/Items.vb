Public Class Items
    'Textures
    Public ImageAsset As Image
    Public Item As ItemClass
    Public Name As String
    Public Description As String
    Public IsStackable As Boolean
    Public ItemCount As Integer
    Public ItemID As Integer
    Public ArmourType As ArmourPiece
    'Weapon Variables
    Public Strength, Intellegence, MovementSpeed, Dexterity, Luck As Integer
    Public BaseDamage As Integer

End Class
Public Enum ItemClass
    Weapon
    Usable
    Specials
    Blocks
    Armour
End Enum
Public Enum WeaponType
    Bow
    Sword
    Hammer
    Staff
    Shield
    OffHand
    Sythe
End Enum

Public Enum ArmourPiece
    Head
    Chest
    Gloves
    Shoes
End Enum

