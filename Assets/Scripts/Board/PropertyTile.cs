using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropertyTile : Tile{
    [SerializeField] GameObject housePrefab; //has tag 'House'
    [SerializeField] GameObject hotelPrefab; //has tag 'Hotel'
    [SerializeField] int value;
    [SerializeField] int district; //0-7

    public PropertyTile(int startValue):base(){
        value = startValue;
    }

    public void BuildHouse(){
        Build(housePrefab);
    }

    public void BuildHotel(){
        Build(hotelPrefab);
    }

    public void Build(GameObject prefab){
        //TODO check if something is already built on the tile
        Transform transform = GetTileTransfrom();
        Vector3 position = transform.position;
        Quaternion rotation = transform.rotation;

        GameObject building = Instantiate(prefab, position, rotation);
        building.transform.SetParent(transform);

        //Move to top edge of the tile, take into account parent scaling.
        building.transform.localPosition = new Vector3(0f, 0.5f, 0.25f);
    }

    //public getters
    public int GetValue(){
        return value;
    }

    public int GetDistrictID(){
        return district;
    }
}