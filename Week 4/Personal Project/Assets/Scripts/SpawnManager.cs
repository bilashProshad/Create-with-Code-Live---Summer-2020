using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPerfabs;
    public GameObject powerupPrefab;

    private float xRange = 10;
    private float zPosEnemy = 12;
    private float ySpawnPos = 0.75f;
    private float zPosPowerup = 3;

    private float startDelay = 1;
    private float spawnEnemyInterval = 1;
    private float spawnPowerupInterval = 5;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", startDelay, spawnEnemyInterval);
        InvokeRepeating("SpawnPowerup", startDelay, spawnPowerupInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy()
    {
        int randomIndex = Random.Range(0, enemyPerfabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-xRange, xRange), ySpawnPos, zPosEnemy);
        Instantiate(enemyPerfabs[randomIndex], spawnPos, enemyPerfabs[randomIndex].transform.rotation);
    }

    void SpawnPowerup()
    {
        Vector3 spawnPos = new Vector3
            (Random.Range(-xRange, xRange), ySpawnPos, 
            Random.Range(-zPosPowerup, zPosPowerup));
        Instantiate(powerupPrefab, spawnPos, powerupPrefab.transform.rotation);
    }
}
