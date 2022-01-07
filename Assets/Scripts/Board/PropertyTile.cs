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
        //TODO build hotel
        //TODO check if house is already built on tile
        Transform tileTransform = GetTileTransfrom();
        Vector3 position = transform.position;
        Quaternion rotation = transform.rotation;
        Vector3 eulerAngles = rotation.eulerAngles;
        Debug.Log(eulerAngles);

        float offsetZ = 0;
        float offsetX = 0;

        switch(eulerAngles.y){
            case 0:
                offsetZ = 5f;
                offsetX = 0f;
                break;
            case 90:
                offsetZ = 0f;
                offsetX = 5f;
                break;
            case 180:
                offsetZ = -5F;
                offsetX = 0f;
                break;
            case 270:
                offsetZ = 0f;
                offsetX = -5f;
                break;
        }

        position.y = position.y + 1;
        position.x = position.x + offsetX;
        position.z = position.z + offsetZ;
        GameObject house = Instantiate(housePrefab, position, rotation);
        house.transform.parent = tileTransform;
    }

    //public getters
    public int GetValue(){
        return value;
    }

    public int GetDistrictID(){
        return district;
    }
}