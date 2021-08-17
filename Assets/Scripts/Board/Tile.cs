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

    public Tile(){
        tileStats.vector3PlayerLocations = GeneratePlayerLocations();
    }
    
    public int GetID(){
        return tileStats.ID;
    }

    public Vector3 GetVector3LoctionForID(int playerID){
        return tileStats.vector3PlayerLocations[playerID];
    }

    private List<Vector3> GeneratePlayerLocations(){
        List<Vector3> playerLocations = new List<Vector3>();
        
        int x = transform.position.x;
        int y = transform.position.y;
        int z = transform.position.z;

        int scaleMultiplier = 8/9;
        int offsetY = 0;

        int minScale = Math.Min(transform.scale.x, transform.scale.z);
        
        /* Generating the player positions
                    x
                 ________
                |        |
                |        |
            z   | A    B |
                |        |
                | C    D |
                |________|
        */

        //A
        playerLocations.Add(new Vector3(
            x - (minScale * scaleMultiplier) / 2,
            y + offsetY,
            z
        ));
        
        //B
        playerLocations.Add(new Vector3(
            x + (minScale * scaleMultiplier) / 2,
            y + offsetY,
            z
        ));

        //C
        playerLocations.Add(new Vector3(
            x - (minScale * scaleMultiplier) / 2,
            y + offsetY,
            z - (minScale * scaleMultiplier)
        ));

        //D
        playerLocations.Add(new Vector3(
            x + (minScale * scaleMultiplier) / 2,
            y + offsetY,
            z - (minScale * scaleMultiplier)
        ));
        
        return playerLocations;
    }
}