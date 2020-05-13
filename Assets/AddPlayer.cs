using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPlayer : MonoBehaviour
{
    public GameObject player;
    public float xMod = 0f;
    public float yMod = 0f;
    public float zMod = -1.5f;

    void OnMouseDown()
    {
       var location = Instantiate(player);
       location.transform.position = new Vector3(transform.position.x + xMod,
                                                 transform.position.y + yMod,
                                                 transform.position.z + zMod);
    }
}
