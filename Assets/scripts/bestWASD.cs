using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bestWASD : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public float speed1;
    public float lowBoundary;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float y = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        // Rotation
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, -speed1 * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0,speed1 * Time.deltaTime, 0);
        }


        transform.Translate(x, 0, y);

        if (transform.position.y < lowBoundary)
        {
           SceneManager.LoadScene(0);
        }

    }
}
