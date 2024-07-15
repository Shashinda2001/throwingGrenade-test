using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour
{
    // Start is called before the first frame update
    public float delay = 3f;
    bool hasExploded = false;
    public GameObject explodeEfect;
    float countdown;
    void Start()
    {
        countdown = delay; 
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0f && !hasExploded)
        {
            Explode();
            hasExploded = true;
        }
    }

   void Explode()
    {
        //show fire effect
        Instantiate(explodeEfect, transform.position, transform.rotation);

        //get nearby objects
        //add force
        //damage

        Destroy(gameObject);

        Debug.Log("boooom");
    }
}
