using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sucker : MonoBehaviour
{
    public Transform teleportTo;
    void OnTriggerEnter(Collider col)
    {
	Transform t = col.gameObject.transform;
        t.position = teleportTo.position;
    }
}
