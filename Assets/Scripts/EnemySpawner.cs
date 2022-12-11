using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    //[SerializeField] float speed;
    //[SerializeField] float walkSpeed;
    //[SerializeField] float runSpeed;

    [SerializeField] Transform[] spawnPositions;
    [SerializeField] GameObject[] enemyPrefab = new GameObject[4];


    [SerializeField] float spawnTime = 8f;
    private float timer = 5f;





    private void Awake()
    {

    }

    void Start()
    {

    }

    void Update()
    {
        timer += Time.deltaTime;
        Spawner();
    }

    private void Spawner()
    {
        if (timer >= spawnTime)
        {
            Debug.Log("ifin içindeyim");

            for (int i = 0; i < spawnPositions.Length; i++)
            {

                for (int j = 0; j < 1; j++)
                {
                    int enemyIndex = UnityEngine.Random.Range(0, enemyPrefab.Length);
                    int positionIndex = UnityEngine.Random.Range(0, spawnPositions.Length);
                    Instantiate(enemyPrefab[enemyIndex], spawnPositions[positionIndex].transform.position, Quaternion.identity);

                }
            }
            timer = 0f;

        }
        
    }

}
