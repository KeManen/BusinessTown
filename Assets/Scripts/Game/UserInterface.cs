using UnityEngine;
using UnityEngine.UI;

public class UserInterface : MonoBehaviour {
    [SerializeField] private GameObject diceButton;
    [SerializeField] private GameObject buyHouseButton;

    void Start(){

    }

    public void ShowBuyHouseBtn(){
        buyHouseButton.SetActive(true);
    }

    public void HideBuyHouseBtn(){
        buyHouseButton.SetActive(false);
    }
    public void ShowDiceBtn(){
        diceButton.SetActive(true);
    }

    public void HideDiceBtn(){
        diceButton.SetActive(false);
    }

    //getters
    public GameObject GetDiceButton(){
        return diceButton;
    }

    public GameObject GetBuyHouseBtn(){
        return buyHouseButton;
    }
}