using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour{
    [Serializable] public struct PlayerStats{
        public int ID;
        public int Money;
        public List<PropertyTile> Properties;
        public Dictionary<Stock, int> Stocks;

        public int TileID;
    }

    [SerializeField] private PlayerStats playerStats;

    //Needed?
    public Player(int startMoney){
        playerStats.Money = startMoney;
        playerStats.Properties = new List<PropertyTile>();
        playerStats.Stocks = new Dictionary<Stock, int>();
        playerStats.TileID = 0;
    }

    //TODO add full value calculations
    public int GetValue(){
        int value = playerStats.Money;
        foreach (PropertyTile property in playerStats.Properties){
            value += property.GetValue();
        }
        foreach (Stock stock in playerStats.Stocks.Keys){
            value += stock.GetValue() * playerStats.Stocks[stock];
        }
        return value;
    }

    public int GetMoney(){
        return playerStats.Money;
    }

    //Note changeAmount can be negative to inflict a cost
    public void ChangeMoney(int changeAmount){
        playerStats.Money += changeAmount; 
    }

    public List<PropertyTile> GetProperties(){
        return playerStats.Properties;
    }

    public Dictionary<Stock, int> GetStocks(){
        return playerStats.Stocks;
    }

    public int GetID(){
        return playerStats.ID;
    }


    public int GetTileID(){
        return playerStats.TileID;
    }

    public void SetTileID(int tileID){
        playerStats.TileID = tileID;
    }

    public void UpdateTransformPosition(Vector3 newLocation){
        gameObject.transform.position = newLocation;
        gameObject.transform.rotation = UnityEngine.Random.rotation;
    }
}
