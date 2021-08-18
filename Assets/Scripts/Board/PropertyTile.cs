using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropertyTile : Tile{
    [SerializeField] int value;

    public PropertyTile(int startValue):base(){
        value = startValue;
    }

    public int GetValue(){
        return value;
    }
}