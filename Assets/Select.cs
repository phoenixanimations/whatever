using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//hi
public class Select : MonoBehaviour
{
    public GameObject unit;
    public List<GameObject> tiles = new List<GameObject>();

    void OnMouseDown()
    {
        foreach(var tile in tiles)
        {
            AddPlayer player = tile.GetComponent<AddPlayer>() as AddPlayer;
            player.player = unit;
        }
    }
}
