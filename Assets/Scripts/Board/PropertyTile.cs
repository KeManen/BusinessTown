using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropertyTile : Tile{
    [SerializeField] int value;
    [SerializeField] int district; //0-7

    public PropertyTile(int startValue):base(){
        value = startValue;
    }

    public int GetValue(){
        return value;
    }

    public int GetDistrictID(){
        return district;
    }
}