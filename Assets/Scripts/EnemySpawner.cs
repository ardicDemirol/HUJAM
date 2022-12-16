using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{


    [SerializeField] Transform[] spawnPositions;
    [SerializeField] GameObject[] enemyPrefab = new GameObject[4];

    [SerializeField] float timeBetweenSpawns = 2;


    void Start()
    {
        StartCoroutine(Spawner());
    }


    IEnumerator Spawner() 
    {
        while (true)
        {
            int randomSpawnPosition = UnityEngine.Random.Range(0,spawnPositions.Length);
            int randomEnemyIndex = UnityEngine.Random.Range(0,enemyPrefab.Length );
            Instantiate(enemyPrefab[randomEnemyIndex], spawnPositions[randomSpawnPosition].transform.position, Quaternion.identity);
            yield return new WaitForSeconds(timeBetweenSpawns);
        }
    }

}
