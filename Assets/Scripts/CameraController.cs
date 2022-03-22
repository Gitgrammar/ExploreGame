using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CameraController : MonoBehaviour
{
    public Transform player;
    public float pointX = -6.0f;
    public float pointY = 1.0f;
    public float rotX;
    public float rotY;

    void LateUpdate()
    {
        transform.position = player.position + (player.forward * pointX) + (player.up * pointY);
        Vector3 dir = player.forward;
        dir.x += rotX;
        dir.y += rotY;
        transform.rotation = Quaternion.LookRotation(dir);
    }
}