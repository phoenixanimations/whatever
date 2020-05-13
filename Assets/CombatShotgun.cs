using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatShotgun : MonoBehaviour
{
    public float attack;
    void OnTriggerStay (Collider col)
    {
	var enemy = col.GetComponent<Combat>() as Combat;
        if(enemy != null)
        {
            enemy.health -= attack;
        }
    }
}
