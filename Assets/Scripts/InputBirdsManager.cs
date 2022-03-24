using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InputBirdsManager : MonoBehaviour
{
    InputField inputField;

    void Start()
    {
        inputField = GameObject.Find("InputField").GetComponent<InputField>();
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Invoke("ReturnToUserFillOut", 0.5f);
            Destroy(gameObject, 0.5f);
        }

    }
    void ReturnToUserFillOut()
    {
        SceneManager.LoadScene("Birds");

    }


    public void GetInputName() 
    {
        string name = inputField.text;
        Debug.Log(name);
        inputField.text = "";
    }
}
