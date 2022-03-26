using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class InputFieldManager : MonoBehaviour
{
    InputField inputField;
    string[] creature = { "birds", "mammals", "lizard", "fish" };
    public Text TextFrame;
    private string name = "";

    void Start()
    {
        inputField = GameObject.Find("InputField").GetComponent<InputField>();
        
    }
public void GetInputName()
    {
        name = inputField.text;
        Debug.LogFormat(name);
        if (creature.Contains(name))
        {
            Debug.LogFormat("Correct!");
        }
        else
        {
            Debug.LogFormat("Wrong!");
        }

        inputField.text = "";
    }
    
}
