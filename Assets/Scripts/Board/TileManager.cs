using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour{
    List<Tile> tiles;

    
    public Tile GetTile(int tileID){
        return tiles[tileID];
    }

    public int GetTileAmount(){
        return tiles.Count;
    }
}