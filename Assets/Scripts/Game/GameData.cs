using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameData : MonoBehaviour{
    public struct BoardStats{
        public int tileAmount;
        public int playerCount;
        public int districtAmount;
    }
    private BoardStats boardStats;

    [SerializeField] private GameObject diceButton;
    private Dictionary<int, Player> playerIDMap;
    private Dictionary<int, Tile> tileIDMap;
    private Dictionary<int, Stock> stockIDMap;    

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

        //Fill stockIDMap
        //Getting amount of districts
        int amountOfDistrict = 0;
        foreach (Tile tile in tileIDMap.Values){
            if(tile.GetType() == typeof(PropertyTile)){
                PropertyTile propertyTile = (PropertyTile) tile;
                if(propertyTile.GetDistrictID() > amountOfDistrict){
                    amountOfDistrict = propertyTile.GetDistrictID();
                }
            }
        }
        for (int i = 0; i < amountOfDistrict; i++){
            stockIDMap.Add(i, new Stock(1000, i)); 
        }

        //Filling boarStats
        boardStats.districtAmount = amountOfDistrict;
        boardStats.tileAmount = tileIDMap.Count;

        Debug.Log("Gamedata/boardstats.districtAmount:"+boardStats.districtAmount);
        Debug.Log("Gamedata/boardstats.tileAmount:"+boardStats.tileAmount);
        boardStats.playerCount = playerIDMap.Count;
    }

    //Basic Getters
    public Player GetPlayerFromID(int playerID){
        return playerIDMap[playerID];
    }
    public GameObject GetDiceButton(){
        return diceButton;
    }

    public Tile GetTileFromID(int tileID){
        return tileIDMap[tileID];
    }

    //Other Methods
    public int GetTileAmount(){
        return boardStats.tileAmount;
    }

    public int GetPlayerCount(){
        return boardStats.playerCount;
    }

    public int GetDistrictAmount(){
        return boardStats.districtAmount;
    }
}
