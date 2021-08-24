using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour{
    private Dictionary<int, Player> playerIDMap;
    private Dictionary<int, Tile> tileIDMap;    

    void Start(){
        playerIDMap = new Dictionary<int, Player>();
        tileIDMap = new Dictionary<int, Tile>();

        //Fill playerIDMap
        GameObject[] playerObjects = GameObject.FindGameObjectsWithTag("Player");
        foreach (GameObject playerObject in playerObjects){
            Player player = (Player) playerObject.GetComponent(typeof(Player));
            playerIDMap.Add(player.GetID(), player);
        }

        //Fill tileIDMap
        GameObject[] tileObjects = GameObject.FindGameObjectsWithTag("Tile");
        foreach (GameObject tileObject in tileObjects){
            Tile tile = (Tile) tileObject.GetComponent(typeof(Tile));
            tileIDMap.Add(tile.GetID(), tile);
        }
    }

    //Basic Getters
    public Player GetPlayerFromID(int playerID){
        foreach (int playerID2 in playerIDMap.Keys){
            Player player;
            playerIDMap.TryGetValue(playerID2, out player);
        }
        return playerIDMap[playerID];
    }

    public Tile GetTileFromID(int tileID){
        return tileIDMap[tileID];
    }

    //Other Methods
    public int GetTileAmount(){
        return tileIDMap.Count;
    }
}
