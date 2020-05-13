using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddEnemy : MonoBehaviour
{
    public float spawnTime = 100f;
    public GameObject enemy;
    public GameObject enemyLvl2;
    public List<GameObject> enemyTiles = new List<GameObject>();
    public float xMod = 0f;
    public float yMod = 0f;
    public float zMod = -1.5f;
    
    float seconds = 0f;
    float enemySpawned = 0f;

    void Spawn(int i, GameObject enemy)
    {
        var location = Instantiate(enemy);
        enemy.transform.position = new Vector3(enemyTiles[i].transform.position.x + xMod,
                                               enemyTiles[i].transform.position.y + yMod,
                                               enemyTiles[i].transform.position.z + zMod);
        enemySpawned++;
    }
    
    void Start()
    {
	for(int i = 0; i < 3; i++)
        {
            Spawn(i, enemy);
        }
    }
    
    void Update()
    {
	seconds++;
        if(seconds > spawnTime)
        {
            var i = Random.Range(0, 7);
            Spawn(i, enemy);
        }
        if((seconds > spawnTime) && (enemySpawned > 19))
        {
            Spawn(0, enemyLvl2);
        }
        if(seconds > spawnTime)
        {
            seconds = 0;
        }
    }
}
