using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TagFramework;

public class Stepper : MonoBehaviour
{
    public float stepAmount = -1.2f;
    void OnTriggerEnter(Collider col)
    {
        if(Tag.HasTag(col, TagData.Unit))
        {
            col.transform.position =
                new Vector3(col.transform.position.x,
                            col.transform.position.y + stepAmount,
                            col.transform.position.z);
        }
    }
}
