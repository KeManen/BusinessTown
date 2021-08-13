using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class GameData : MonoBehaviour{
    
    //Singleton
    private static readonly GameData gameDataSingleton = new GameData();
    private ArrayList playerArrayList;
    private TileManager tileManager;




    static GameData(){}
    private GameData(){
        //TODO expand skeleton
        playerArrayList = new ArrayList();
        tileManager = new TileManager();
    }

    public static GameData Instance{
        get{return gameDataSingleton;}
    }

    public TileManager GetTileManager(){
        return tileManager;
    }
}
