using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldManager : MonoBehaviour
{
    InputField inputField;

    void Start()
    {
        inputField = GameObject.Find("InputField").GetComponent<InputField>();
        
    }
public void GetInputName()
    {
        string name = inputField.text;
        Debug.Log(name);

        inputField.text = "";
    }
}
