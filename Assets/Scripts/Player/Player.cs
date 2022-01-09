using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour{
    [field: SerializeField] public int Id {get;}
    [field: SerializeField] public int TileId {get; set;}
    [field: SerializeField] public int Money {get; set;}
    [SerializeField] private List<PropertyTile> Properties {get;}
    [SerializeField] private Dictionary<Stock, int> Stocks {get;}

    //Needed?
    public Player(int startMoney){
        Money = startMoney;
        Properties = new List<PropertyTile>();
        Stocks = new Dictionary<Stock, int>();
        TileId = 0;
    }

    //TODO add full value calculations
    public int GetValue(){
        int value = Money;
        foreach (PropertyTile property in Properties){
            value += property.Value;
        }
        foreach (Stock stock in Stocks.Keys){
            value += stock.Value * Stocks[stock];
        }
        return value;
    }

    //Note changeAmount can be negative to inflict a cost
    public void ChangeMoney(int changeAmount){
        Money += changeAmount; 
    }

    public List<PropertyTile> GetProperties(){
        return Properties;
    }

    public Dictionary<Stock, int> GetStocks(){
        return Stocks;
    }

    public void UpdateTransformPosition(Vector3 newLocation){
        gameObject.transform.position = newLocation;
        gameObject.transform.rotation = UnityEngine.Random.rotation;
    }
}
