using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Attack : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            Destroy(gameObject, 0.2f);

            Invoke("ReturnToUserFillOut", 0.9f);

        }

    }
    void ReturnToUserFillOut()
    {
        SceneManager.LoadScene("UserEntry");

    }
}
