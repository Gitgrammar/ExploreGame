using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Attack : MonoBehaviour
{
    static string name;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Invoke("ReturnToUserFillOut", 0.5f);
            Destroy(gameObject, 0.5f);
            name = "tiger";
        }

    }
    void ReturnToUserFillOut()
    {
        SceneManager.LoadScene("UserEntry");
        Debug.Log(name);

    }
}
