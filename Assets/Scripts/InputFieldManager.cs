using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class InputFieldManager : MonoBehaviour
{
    InputField inputField;
    string[] creature = { "birds", "mammals", "lizard", "fish" };

    void Start()
    {
        inputField = GameObject.Find("InputField").GetComponent<InputField>();
        
    }
public void GetInputName()
    {
        string name = inputField.text;
        Debug.Log(name);
        if (creature.Contains(name))
        {
            Debug.Log("Correct!");
        }
        else
        {
            Debug.Log("Wrong!");
        }

        inputField.text = "";
    }
    
}
