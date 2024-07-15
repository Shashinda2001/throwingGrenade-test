using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerRotate : MonoBehaviour
{
    public float speed = 2f;

    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            Debug.Log("E press");
            transform.Rotate(0, speed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            Debug.Log("Q press");
            transform.Rotate(0, -speed * Time.deltaTime, 0);
        }
    }
}
