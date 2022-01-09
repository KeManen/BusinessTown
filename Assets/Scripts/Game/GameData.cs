using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameData : MonoBehaviour{
    [SerializeField] private GameObject diceButton {get;} //Move to diceScipts.cs
    private Dictionary<int, Player> playerIDMap;
    private Dictionary<int, Tile> tileIDMap;
    private Dictionary<int, Stock> stockIDMap;    
    [field: SerializeField] public int TileCount {get; private set;}
    [field: SerializeField] public int PlayerCount {get; private set;}
    [field: SerializeField] public int DistrictCount {get; private set;}

    void Start(){
        playerIDMap = new Dictionary<int, Player>();
        tileIDMap = new Dictionary<int, Tile>();
        stockIDMap = new Dictionary<int, Stock>();

        //Fill playerIDMap
        GameObject[] playerObjects = GameObject.FindGameObjectsWithTag("Player");
        foreach (GameObject playerObject in playerObjects){
            Player player = (Player) playerObject.GetComponent(typeof(Player));
            playerIDMap.Add(player.Id, player);
        }

        //Fill tileIDMap
        GameObject[] tileObjects = GameObject.FindGameObjectsWithTag("Tile");
        foreach (GameObject tileObject in tileObjects){
            Tile tile = (Tile) tileObject.GetComponent(typeof(Tile));
            tileIDMap.Add(tile.Id, tile);
        }

        //Fill stockIDMap
        //Getting amount of districts
        int amountOfDistricts = 0;
        foreach (Tile tile in tileIDMap.Values){
            if(tile.GetType() == typeof(PropertyTile)){
                PropertyTile propertyTile = (PropertyTile) tile;
                if(propertyTile.DistrictId > amountOfDistricts){
                    amountOfDistricts = propertyTile.DistrictId;
                }
            }
        }

        //TODO implement working stock
        /*
        for (int i = 0; i < amountOfDistricts; i++){
            stockIDMap.Add(i, new Stock(1000, i)); 
        }*/

        //Filling boardStats
        
        DistrictCount = amountOfDistricts;
        TileCount = tileIDMap.Count;
        PlayerCount = playerIDMap.Count;

        Debug.Log("Gamedata/boardstats.districtCount:"+DistrictCount);
        Debug.Log("Gamedata/boardstats.tileCount:"+TileCount);
        Debug.Log("Gamedata/boardstats.playerCount:"+PlayerCount);
    }

    //Basic Getters
    public Player GetPlayerFromID(int playerID){
        return playerIDMap[playerID];
    }

    public Tile GetTileFromID(int tileID){
        return tileIDMap[tileID];
    }
}
