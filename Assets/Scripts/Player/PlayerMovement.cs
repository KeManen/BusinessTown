using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour{
    private TileManager tileManager;
    private Tile currentPlayerTile;

    public PlayerMovement(){
        tileManager = GameData.Instance.GetTileManager();
        currentPlayerTile = tileManager.GetTile(0);
    }
    public Tile GetCurrentTile(){
        return currentPlayerTile;
    }

    //Note moveAmount can be negative to go backwards
    public void MovePlayer(int moveAmount){
        int currentPlayerTileID = currentPlayerTile.GetID();
        int nextPlayerTileID = (currentPlayerTileID + moveAmount) % tileManager.GetTileAmount();
        currentPlayerTile = tileManager.GetTile(nextPlayerTileID);
    }
}