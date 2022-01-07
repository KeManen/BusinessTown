using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour{
    private GameData gameData;
    private int turnPlayerID;
    private GameObject diceButton;

    public void StartTurn(){ //is called by roll dice button
        diceButton.SetActive(false); //hide dice roll button
        MovePlayer(turnPlayerID, DiceScripts.Roll2Dice());

        //Do other turn stuff
        
        EndTurn();
    }

    public void EndTurn(){
        //check win conditions
        //set turnPlayerID to next player
    }

    //Note moveAmount can be negative to go backwards
    public void MovePlayer(int playerID, int moveAmount){
        Debug.Log(playerID);
        //Calculate and update ID
        Player player = gameData.GetPlayerFromID(playerID);
        Debug.Log(player);
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
        diceButton = gameData.GetDiceButton();
        turnPlayerID = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
