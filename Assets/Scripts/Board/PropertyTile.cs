using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropertyTile : Tile{
    int tileValue;

    public PropertyTile(int tileID, Vector3 location1, Vector3 location2, Vector3 location3, Vector3 location4, int startValue):base(tileID, location1, location2, location3, location4){
        tileValue = startValue;
    }
}