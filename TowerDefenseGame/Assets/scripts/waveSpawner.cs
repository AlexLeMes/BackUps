using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class waveSpawner : MonoBehaviour {

    bool allowSpawning = false;

    float timeBetweenWaves = 25f;

    int currentWave = 0;

    int numEnemiesToSpawn = 15;

    GameObject spawnLocation;

    public GameObject[] enemies;
    int arrayLength;

    //public Text waveText;

    public void startWaves()
    {
        spawnEnemy();
    }

    void Awake()
    {
        spawnLocation = GameObject.Find("_SpawnLocation");
        arrayLength = enemies.GetLength(0);
    }

    void spawnEnemy()
    {
        allowSpawning = true;

        if (allowSpawning == true)
        {
            for (int i = 0; i <= numEnemiesToSpawn; i++)
            {
                Instantiate(enemies[Random.Range(0, arrayLength)], spawnLocation.transform.position, Quaternion.identity);
            }
        }
    }
}
