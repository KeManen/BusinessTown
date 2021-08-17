using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class GameData:ScriptableObject{
    
    //Singleton
    private static readonly GameData gameDataSingleton = new GameData();
    private Dictionary<Player, Tile> playerTileMap;
    private TileManager tileManager;


    static GameData(){}
    private GameData(){
        //TODO expand skeleton
        playerTileMap = new Dictionary<Player, Tile>();
        tileManager = new TileManager();
    }

    public static GameData Instance{
        get{return gameDataSingleton;}
    }

    public TileManager GetTileManager(){
        return tileManager;
    }

    //return Tile player is assigned to else null
    public Tile GetPlayerCurrentTile(int playerID){
        return playerTileMap[GetPlayerFromID(playerID)];
    }

    public void SetPlayerCurrentTile(int playerID, int tileID){
        playerTileMap[GetPlayerFromID(playerID)] = tileManager.GetTile(tileID);
    }

    public Dictionary<Player, Tile> GetPlayerTileMap(){
        return playerTileMap;
    }

    private Player GetPlayerFromID(int playerID){
        foreach(Player player in playerTileMap.Keys){
            if(player.GetID() == playerID){
                return player;
            }
        }
        return null;
    }

    
}
