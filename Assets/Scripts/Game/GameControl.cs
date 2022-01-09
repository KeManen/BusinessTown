using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour{
    private GameData gameData;
    private DiceScripts diceScripts;
    private int turnPlayerID;
    private int players;

    public void StartTurn(){ //is called by roll dice button
        MovePlayer(turnPlayerID, DiceScripts.Roll2Dice());
        diceScripts.HideBtn();

        //Do other turn stuff

        TileAction();
        EndTurn();
    }

    public void TileAction(){
        Player player = gameData.GetPlayerFromID(turnPlayerID);
        GameObject tileObject = gameData.GetTileFromID(player.TileId).gameObject;

        //property tile action
        PropertyTile propertyTile = (PropertyTile) tileObject.GetComponent(typeof(PropertyTile));
        if(propertyTile != null){
            //TODO buy menu
            propertyTile.BuildHouse();
            return;
        }
        
        //other tile actions
    }

    public void EndTurn(){
        //check win conditions
        //set turnPlayerID to next player
        //other end of turn stuff

        diceScripts.ShowBtn();
    }

    //Note moveAmount can be negative to go backwards
    public void MovePlayer(int playerID, int moveAmount){
        Debug.Log(playerID);
        //Calculate and update ID
        Player player = gameData.GetPlayerFromID(playerID);
        Debug.Log(player);
        int nextTileID = (player.TileId + moveAmount) % gameData.TileCount;
        player.TileId = nextTileID;

        //Update Vector3 location
        player.UpdateTransformPosition(gameData.GetTileFromID(nextTileID).GetVector3Loction(playerID));

    }

    public void SetNextInOrderPlayer(){
        Debug.Log(players);
    }

    //note changeAmout can be negative to go downwards
    public void UpdateStockValues(int changeAmount){
        //TODO implement
    }


    // Start is called before the first frame update
    void Start(){
        gameData = (GameData) gameObject.GetComponent(typeof(GameData));
        diceScripts = (DiceScripts) gameObject.GetComponent(typeof(DiceScripts));
        turnPlayerID = 0;
        Debug.Log(gameData.TileCount);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}