using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropertyTile : Tile{
    [SerializeField] GameObject housePrefab;
    [SerializeField] int value;
    [SerializeField] int district; //0-7

    public PropertyTile(int startValue):base(){
        value = startValue;
    }

    public void BuildHouse(){
        //TODO take into account the orientation of property tile 
        //TODO build hotel
        Transform transfrom = GetTileTransfrom();
        Vector3 position = transfrom.position;
        position.y = position.y + 1.5f;
        position.z = position.z + 3;
        Instantiate(housePrefab, position, Quaternion.identity);
    }

    //public getters
    public int GetValue(){
        return value;
    }

    public int GetDistrictID(){
        return district;
    }
}