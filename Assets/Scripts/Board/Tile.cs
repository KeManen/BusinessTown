using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//TODO add logic to bind with a tileObject
public class Tile : MonoBehaviour{
    [SerializeField]
    private int tileID;
    

    public int GetID(){
        return tileID;
    }
}