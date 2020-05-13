using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TagFramework;

public class Sucker : MonoBehaviour
{
    public Transform teleportTo;
    void OnTriggerEnter(Collider col)
    {
        if(Tag.HasTag(col, TagData.Unit))
        {
            Transform t = col.gameObject.transform;
            t.position = teleportTo.position;
        }
    }
}
