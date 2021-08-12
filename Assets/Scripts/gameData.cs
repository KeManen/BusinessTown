using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : MonoBehaviour{
    
    //Singleton
    private GameData gameDataSingleton;

    private ArrayList playerArrayList;
    private ArrayList tileArrayList; 

    private GameData(){
        //TODO expand skeleton
        playerArrayList = new ArrayList();
        tileArrayList = new ArrayList();
    }

    public GameData GetInstance(){
        if (gameDataSingleton == null){
            gameDataSingleton = new GameData();
        }
        return gameDataSingleton;
    }
}
