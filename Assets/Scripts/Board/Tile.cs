using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//TODO add logic to bind with a tileObject
public class Tile : MonoBehaviour{

    [Serializable] public struct TileStats{
        public int ID;
    }

    private List<Vector3> playerLocations;

    [SerializeField] private TileStats tileStats;

    void Start(){
        
        //////////////////////////////////////////////////////////////
        //Generating player locations in a tile for 4 players
        //////////////////////////////////////////////////////////////

        playerLocations = new List<Vector3>();
        
        float x = transform.position.x;
        float y = transform.position.y;
        float z = transform.position.z;

        float scaleMultiplier = 8/9;
        float offsetY = 4;

        float minScale = Math.Min(transform.lossyScale.x, transform.lossyScale.z);
        
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

        //////////////////////////////////////////////////////
    }

    public int GetID(){
        return tileStats.ID;
    }

    public Vector3 GetVector3Loction(int playerID){
        return playerLocations[playerID];
    }
}