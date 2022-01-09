using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LobbyPlayer : MonoBehaviour
{
    [field: SerializeField] public string Name {get; set;}
    [field: SerializeField] public int Color {get; set;}
    [field: SerializeField] private InputField inputName;
    [field: SerializeField] private Dropdown dropdownColor;
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

    private void SubmitName(string name)
    {
        Name = name;
        Debug.Log(Name);
    }

    private void SubmitColor(Dropdown c)
    {
        Color = c.value;
        Debug.Log(Color);
    }
}
