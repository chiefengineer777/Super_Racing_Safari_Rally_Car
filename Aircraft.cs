using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aircraft : MonoBehaviour
{
    public float thrust = 25000f;
    public float topspeed = 1000f;
    Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.magnitude < topspeed)
        {
            rb.AddRelativeForce(new Vector3(0, 0, thrust));
        }
    }
}
