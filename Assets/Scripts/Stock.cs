using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stock : MonoBehaviour{
    [Serializable] public struct StockStats{
        public int districtID;
        public int stockValue;
    }
    [SerializeField] private StockStats stockStats;

    public Stock(int startValue, int districtID){
        stockStats.stockValue = startValue;
        stockStats.districtID = districtID;
    }

    public int GetValue(){
        return stockStats.stockValue;
    }

    public void SetValue(int newValue){
        stockStats.stockValue = newValue;
    }

    public int GetDistrictID(){
        return stockStats.districtID;
    }
}