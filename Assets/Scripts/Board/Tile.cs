using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//TODO add logic to bind with a tileObject
public class Tile : MonoBehaviour{

    [Serializable] public struct TileStats{
        public int ID;
        public List<Vector3> vector3PlayerLocations;
    }

    [SerializeField] private TileStats tileStats;

    public Tile(int tileID, Vector3 location1, Vector3 location2, Vector3 location3, Vector3 location4){
        this.tileStats.ID = tileID;
        tileStats.vector3PlayerLocations = new List<Vector3>(){
            location1, location2, location3, location4
        };
    }
    

    public int GetID(){
        return tileStats.ID;
    }

    /*
    //returns a list of vector3 playerlocation
    public List<Vector3> GetPlayerLocations(){
        return vector3PlayerLocations;
    }
    */

    public Vector3 GetVector3LoctionForID(int playerID){
        return tileStats.vector3PlayerLocations[playerID];
    }
}