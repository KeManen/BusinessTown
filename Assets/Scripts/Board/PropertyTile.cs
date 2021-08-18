using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropertyTile : Tile{
    [SerializeField] int tileValue;

    public PropertyTile(int startValue):base(){
        tileValue = startValue;
    }
}