using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stock : MonoBehaviour{
    [field: SerializeField] public int Id {get; private set;}
    [field: SerializeField] public int Value {get; set;}

    public Stock(int id, int value){
        Id = id;
        Value = value;
    }
}