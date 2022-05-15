using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowOverhead : MonoBehaviour
{
    public GameObject ball;
    private Vector3 offset = new Vector3(1.13f, 13.66f, -4.45f);


    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = ball.transform.position + offset;
    }
}