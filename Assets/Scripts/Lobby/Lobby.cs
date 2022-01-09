using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lobby : MonoBehaviour
{
    private GameObject objectLobbyPlayers;
    [SerializeField] private Button btnStart;
    // Start is called before the first frame update
    void Start()
    {   
        objectLobbyPlayers = GameObject.FindWithTag("LobbyPlayers");

        btnStart.onClick.AddListener(BtnStartOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void BtnStartOnClick()
    {
        LobbyPlayer[] playerScripts = GetComponentsInChildren<LobbyPlayer>();

        foreach (LobbyPlayer script in playerScripts){
            Debug.Log(script.Name);
            Debug.Log(script.Color);
        }

        Debug.Log("Starting game...");
    }
}
