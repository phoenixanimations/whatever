using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using TagFramework;

public class Step : MonoBehaviour
{
    public GameObject unit;
    public GameObject text;
    bool isText = false;
    float timer = 0f;
    void OnTriggerEnter(Collider col)
    {
        if(Tag.HasTag(col, TagData.Unit))
        {
            unit.transform.position = new Vector3(unit.transform.position.x,
                                                  unit.transform.position.y - 1.2f,
                                                  unit.transform.position.z);
            isText = true;
        }
    }

    void Update()
    {
	text.SetActive(isText);
        if(isText)
        {
            timer++;
        }
        if(timer > 20f)
        {
            timer = 0;
            isText = false;
        }
    }
}
