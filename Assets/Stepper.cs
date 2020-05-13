using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stepper : MonoBehaviour
{
    public float stepAmount = -1.2f;
    void OnTriggerEnter(Collider col)
    {
	col.transform.position =
            new Vector3(col.transform.position.x,
                        col.transform.position.y + stepAmount,
                        col.transform.position.z);
    }
}
