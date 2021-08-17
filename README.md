# BusinessTown
A videogame prototype made in unity inspired by monopoly



Structure overview:
```
GameControl - - handles functions as the skeleton
|_GameData - Singleton - keeps track of game objects
    |_Player - - keeps track of player assets
    |_BoardData - - keeps track of board state and value
    |_TileManager - - keeps track of tiles in the board
        |_PropertyTile - -
            |_Tile - - Base tile class
```
Stocks
