using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour{
    private GameData gameData;
    private int turnPlayerID;

    public void StartTurn(){
        MovePlayer(turnPlayerID, DiceScripts.Roll2Dice());
        //Do other turn stuff

    }

    //Note moveAmount can be negative to go backwards
    public void MovePlayer(int playerID, int moveAmount){
        //Calculate and update ID
        Player player = gameData.GetPlayerFromID(playerID);
        int nextTileID = (player.GetTileID() + moveAmount) % gameData.GetTileAmount();
        player.SetTileID(nextTileID);

        //Update Vector3 location
        player.UpdateTransformPosition(gameData.GetTileFromID(nextTileID).GetVector3Loction(playerID));

    }

    //note changeAmout can be negative to go downwards
    public void UpdateStockValues(int changeAmount){
        //TODO implement
    }

    // Start is called before the first frame update
    void Start(){
        gameData = (GameData) gameObject.GetComponent(typeof(GameData));
        turnPlayerID = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
