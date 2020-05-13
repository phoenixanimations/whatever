using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Combat))]
[RequireComponent(typeof(Rigidbody))]
public class Walk : MonoBehaviour
{
    public float xMovement = 0.05f;
    public float yMovement = 0f;
    public float zMovement = 0f;
    public bool startMovement = true;

    new Rigidbody rigidbody;
    Combat combat;
    void Start()
    {
	rigidbody = GetComponent<Rigidbody>() as Rigidbody;
        combat = GetComponent<Combat>() as Combat;
    }
    
    void Update()
    {
        if(startMovement)
        {
            transform.position =
            new Vector3(transform.position.x + xMovement,
                        transform.position.y + yMovement,
                        transform.position.z + zMovement);
        }
        if(combat.win)
        {
            startMovement = true;
        }
    }

    void OnCollisionStay(Collision col)
    {
        startMovement = false;
        if(Tag.HasTag(col, TagData.Unit))
        {
            combat.StartCombat(col.gameObject.GetComponent<Combat>() as Combat);
        }
    }
}
// enemy that enables gravity on touch
// enable freeze position 
// shotgun effect
