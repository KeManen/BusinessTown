using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour{
    [Serializable] public struct PlayerStats{
        public int ID;
        public Transform Transform;
        public int Money;
        public ArrayList Properties; //PropertyTile
        public ArrayList Stocks; //Stock
    }

    [SerializableField] private PlayerStats playerStats;

    public Player(int playerID, int startMoney){
        playerStats.ID = playerID;
        playerStats.Money = startMoney;
        playerStats.Properties = new ArrayList();
        playerStats.Stock = new ArrayList();
    }

    //TODO add full value calculations
    public int GetPlayerValue(){
        return playerStats.Money;
    }

    public int GetPlayerMoney(){
        return playerStats.Money;
    }

    //Note changeAmount can be negative to inflict a cost
    public void ChangeMoney(int changeAmount){
        playerStats.Money += changeAmount; 
    }

    //returns ArrayList<PropertyTiles>
    public ArrayList GetProperties(){
        return playerStats.Properties;
    }


    //returns ArrayList<Stock>
    public ArrayList GetStocks(){
        return playerStats.Stocks;
    }

    public int GetID(){
        return playerStats.ID;
    }

    public Transform GetTransformPlayer(){
        return playerStats.Transform;
    }
}
