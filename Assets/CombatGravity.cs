using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatGravity : Combat
{
    override public void StartCombat(Combat defender)
    {
        base.StartCombat(defender);
        Rigidbody rb = defender.GetComponent<Rigidbody>() as Rigidbody;
        rb.constraints = RigidbodyConstraints.None;
        rb.useGravity = true;
    }
}
