using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funny : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = (Rigidbody)GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        rb.AddForce(0, 0.1f, 0.1f, ForceMode.Acceleration);
    }
}
