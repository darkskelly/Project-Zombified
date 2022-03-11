# Project-Zombified
A Level coursework
This is a piece of A-Level coursework created from (08/01/2021|8th of January 2021) - (01/04/2022| 1st of April 2022)
The game most likely will not be complete by the end of this deadline but I will try to finish it.
Objectives are as follows

1)	Player able to start game
a)	Player is able to choose a class
 i)	Refer to Specific objectives 8
 
b)	Player is able to choose character model

c)	Player is able to assign stats to character
 i)	Stats affect player refer to specific objectives 9
 
d)	Game starts and GUI loads

2)	Map Loads
a)	Map Generator creates a procedurally generated map

b)	Blocked tiles are assigned (x,y,1) = 1

3)	NPCs Spawn
a)	DrawNPCs has parameters passed through it to create a predetermined structure to the map with the NPC inside of it 

b)	NPC should load up their respective NPC interface when interacted with “e”

c)	Map tile with NPC should be (x,y,3) = 0-4

d)	Player is able to fight NPC

 i)	When NPC interacted with “e” the fight screen is shown 

 ii)	Player is able to press buttons to cause a dice roll to occur 
 
 iii)	Sum of dice roll is calculated and inflicted on enemy NPC
 
 iv)	If fight won player awarded 50 experience
 
 v)	After 200 experience is gained then player will level up and have 2 more stat points to assign
 
 vi)	NPCs will attack randomly when walking around in areas with Flower, Cacti, or tall grass
 
e)	Player is able to use Casino NPC
 i)	When Casino NPC is interacted with “e” the Casino menu is shown

 ii)	Player is able to deposit materials such as wood or stone in exchange for currency. 
 
 iii)	A fair roll is made and the outcome output onto the screen
 
f)	Player is able to use Merchant NPC
 i)	When Merchant NPC is interacted with “e” the merchant menu is shown

ii)	Player is able to sell materials such as wood, stone, flowers, Iron and armour for currency.

iii)	Player is able to buy items such as armour and weapons in exchange for currency.

(1)	Armour is referred to in Specific Objective 12

4)	Player is able to move

a)	Player can use “W,A,S,D” to input movement commands to the game

b)	Player is blocked by terrain such as Trees, Mountains and ocean tiles. 

5)	Player able to break blocks in the game
a)	When a block is broken the tile placed on the broken block should match the biome that block is in

b)	Block player broke returned to inventory

6)	Player able to place block 
a)	Player can press “f” and place a tile in front of them as long as the tile is not a blocked tile

7)	Player is able save game
a)	When save game button is pressed a name for the save should be input

b)	Currant game state and player stats will be saved and be able to be loaded in at a later date

8)	Player is able to resume a game
a)	Player can load a save file made previously and get back to the previous game state with player stats and all.

9)	Player is able to open inventory
a)	Player presses an input to open the inventory where they can see what materials/armour/weapons they have in their inventory. 

b)	Inventory must be saved in character save

10)	Weapons have an affect on combat
a)	Depending on the class the weapons the class uses will have different effects and do more or less damage

b)	Weapons can be upgraded with gold to do more damage
11)	Armour has an effect on combat
a)	Armour when equipped gives more protection to the user when fighting

b)	The highest tier of armour has special effects e.g teleportation. 
