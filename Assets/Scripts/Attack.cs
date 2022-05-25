using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Attack : MonoBehaviour
{
    static Animator creature;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Invoke("ReturnToUserFillOut", 0.5f);
            Destroy(gameObject, 0.5f);
            creature = GetComponent<Animator>();
        }

    }
    void ReturnToUserFillOut()
    {
        DontDestroyOnLoad(gameObject);
            SceneManager.LoadScene("UserEntry");
        creature.transform.localPosition=new Vector3 (10, 200,100);
        Debug.Log(creature);

    }
}
