using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour{
    private GameData gameData;
    private DiceScripts diceScripts;
    private UserInterface ui;
    private int turnPlayerID;
    private int players;
    private bool buyHouseBtnPressed;

    public void StartTurn(){ //is called by roll dice button
        MovePlayer(turnPlayerID, DiceScripts.Roll2Dice());
        ui.HideDiceBtn();

        //Do other turn stuff

        TileAction();
        EndTurn();
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

    public void TileAction(){
        Player player = gameData.GetPlayerFromID(turnPlayerID);
        GameObject tileObject = gameData.GetTileFromID(player.GetTileID()).gameObject;

        //property tile action
        PropertyTile propertyTile = (PropertyTile) tileObject.GetComponent(typeof(PropertyTile));
        if(propertyTile != null){
            StartCoroutine(PropertyMenu(propertyTile));
            return;
        }
        
        //other tile actions
    }

    IEnumerator PropertyMenu(PropertyTile property){
        ui.ShowBuyHouseBtn();
        GameObject btn = ui.GetBuyHouseBtn();
        while(!buyHouseBtnPressed){
            yield return null;
        }
        property.BuildHouse();
        ui.HideBuyHouseBtn();
        buyHouseBtnPressed = false;
    }

    public void BuyHouseBtnOnClick(){
        buyHouseBtnPressed = true;
    }

    public void EndTurn(){
        //check win conditions
        SetNextInOrderPlayer();
        //other end of turn stuff

        ui.ShowDiceBtn();
    }

    public void SetNextInOrderPlayer(){
        turnPlayerID = turnPlayerID < (players - 1) ? turnPlayerID + 1 : 0;
    }

    //note changeAmout can be negative to go downwards
    public void UpdateStockValues(int changeAmount){
        //TODO implement
    }


    // Start is called before the first frame update
    void Start(){
        gameData = (GameData) gameObject.GetComponent(typeof(GameData));
        ui = (UserInterface) gameObject.GetComponent(typeof(UserInterface));
        diceScripts = (DiceScripts) gameObject.GetComponent(typeof(DiceScripts));
        turnPlayerID = 0;
        //players = gameData.GetPlayerCount();
        players = 2;
        buyHouseBtnPressed = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}