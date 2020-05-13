using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funny : MonoBehaviour
{
    public AudioClip audioClip;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = (Rigidbody)GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(audioClip != null)
        {
            // audioClip.Play();
        }
        rb.AddForce(0, 0.1f, 0.1f, ForceMode.Acceleration);
        Quaternion deltaRotation = Quaternion.Euler(new Vector3(0, 100, 0) * Time.deltaTime);
        rb.MoveRotation(rb.rotation * deltaRotation);
    }

    void OnDestroy()
    {
        if(audioClip != null)
        {
            // audioClip.Stop();
        }
    }
}
