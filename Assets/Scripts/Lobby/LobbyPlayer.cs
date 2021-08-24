using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LobbyPlayer : MonoBehaviour
{
    private string playerName;
    private int playerColor;
    [SerializeField]
    private InputField inputName;
    [SerializeField]
    private Dropdown dropdownColor;
    // Start is called before the first frame update
    void Start()
    {
        inputName.onEndEdit.AddListener(SubmitName);
        dropdownColor.onValueChanged.AddListener(delegate {
            SubmitColor(dropdownColor);
        });
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void SubmitName(string n)
    {
        playerName = n;
        Debug.Log(playerName);
    }

    private void SubmitColor(Dropdown c)
    {
        playerColor = c.value;
        Debug.Log(playerColor);
    }

    public string GetPlayerName()
    {
        return(playerName);
    }

    public int GetPlayerColor()
    {
        return(playerColor);
    }
}
