using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TagFramework;

public class CombatShotgun : MonoBehaviour
{
    public float attack;
    void OnTriggerStay (Collider col)
    {
	if(Tag.HasTag(col, TagData.Unit))
        {
            var enemy = col.GetComponent<Combat>() as Combat;
            if(enemy != null)
            {
                enemy.health -= attack;
            }
        }
    }
}
