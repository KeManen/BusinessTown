using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour{
    private int playerID;
    public Transform playerTransform;
    private int playerMoney;
    ArrayList playerProperties; //PropertyTile
    ArrayList playerStock; //Stock

    public PlayerData(int playerID, int startMoney){
        this.playerID = playerID;
        playerMoney = startMoney;
        playerProperties = new ArrayList();
        playerStock = new ArrayList();
    }

    //TODO add full value calculations
    public int GetPlayerValue(){
        return playerMoney;
    }

    public int GetPlayerMoney(){
        return playerMoney;
    }

    //Note changeAmount can be negative to inflict a cost
    public void ChangeMoney(int changeAmount){
        playerMoney += changeAmount; 
    }

    //returns ArrayList<PropertyTiles>
    public ArrayList GetProperties(){
        return playerProperties;
    }


    //returns ArrayList<Stock>
    public ArrayList GetStocks(){
        return playerStock;
    }

    public int GetID(){
        return playerID;
    }

    public Transform GetTransformPlayer(){
        return playerTransform;
    }
}
