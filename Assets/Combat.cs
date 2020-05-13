using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat : MonoBehaviour
{
    public float health;
    public float attack;
    public bool win = false;
    
    virtual public void StartCombat(Combat defender)
    {
        if(defender == null) return;
        win = false;
        defender.health -= attack;
        if(defender.health <= 0)
        {
            win = true;
        }
    }

    void Update()
    {
	if(health < 0.0f)
        {
            Destroy(gameObject);
        }
    }
}
