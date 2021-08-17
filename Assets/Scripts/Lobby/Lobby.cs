using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lobby : MonoBehaviour
{
    [SerializeField]
    private Button btnStart;
    // Start is called before the first frame update
    void Start()
    {
        btnStart.onClick.AddListener(btnStartOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void btnStartOnClick()
    {
        Debug.Log("Starting game...");
    }
}
