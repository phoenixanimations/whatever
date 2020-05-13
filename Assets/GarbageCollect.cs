using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TagFramework;

[RequireComponent(typeof(Tag))]
public class GarbageCollect : MonoBehaviour
{
    public List<TagData> tagData = new List<TagData>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if(tagData.Count > 0)
        {
            foreach(var tag in tagData)
            {
                if(Tag.HasTag(col, tag))
                {
                    Destroy(col.gameObject);
                    break;
                }
            }
            return;
        }
	Destroy(col.gameObject);
    }
}
