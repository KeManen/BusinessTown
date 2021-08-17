using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//TODO add logic to bind with a tileObject
public class Tile : MonoBehaviour{
    protected int tileID;
    private List<Vector3> vector3PlayerLocations;

    public Tile(int tileID, Vector3 location1, Vector3 location2, Vector3 location3, Vector3 location4){
        this.tileID = tileID;
        vector3PlayerLocations = new List<Vector3>(){
            location1, location2, location3, location4
        };
    }    

    public int GetID(){
        return tileID;
    }

    /*
    //returns a list of vector3 playerlocation
    public List<Vector3> GetPlayerLocations(){
        return vector3PlayerLocations;
    }
    */

    public Vector3 GetVector3LoctionForID(int playerID){
        return vector3PlayerLocations[playerID];
    }
}