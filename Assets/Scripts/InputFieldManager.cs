using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.SceneManagement;

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
        Debug.LogFormat(name);
        if (creature.Contains(name))
        {
            
            Debug.LogFormat("Correct!");
            Invoke("ToCorrectScene", 1.5f);
        }
        else
        {
            Debug.LogFormat("Wrong!");
            Invoke("ToWrongScene", 1.5f);
        }


        inputField.text = "";

    }
    void ToWrongScene() { 
    SceneManager.LoadScene("CasesOfWrong");
        }
    void ToCorrectScene()
    {
        SceneManager.LoadScene("CasesOfCorrect");
    }

}
