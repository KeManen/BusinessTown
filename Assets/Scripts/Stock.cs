using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stock : MonoBehaviour{
    private int stockValue;

    public Stock(int startValue){
        stockValue = startValue;
    }

    public int GetValue(){
        return stockValue;
    }

    public void SetValue(int newValue){
        stockValue = newValue;
    }
}