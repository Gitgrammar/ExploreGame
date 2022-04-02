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
            Invoke("ReturnToUserFillOut", 0.5f);
            Destroy(gameObject, 0.5f);
        }

    }
    void ReturnToUserFillOut()
    {
        SceneManager.LoadScene("UserEntry");

    }
}
