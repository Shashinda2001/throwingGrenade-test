using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grenadeThrow : MonoBehaviour
{
    // Start is called before the first frame update
    public float throwForce = 30f;
    public GameObject grenadepredab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ThrowGrenade();
        }
    }

   void ThrowGrenade()
    {
       GameObject grenade = Instantiate(grenadepredab, transform.position, transform.rotation);
        Rigidbody rg = grenade.GetComponent<Rigidbody>();
        rg.AddForce(transform.forward * throwForce, ForceMode.VelocityChange);
    }
}
