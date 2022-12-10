using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    //[SerializeField] float speed;
    //[SerializeField] float walkSpeed;
    //[SerializeField] float runSpeed;

    [SerializeField] Transform[] spawnPositions;
    [SerializeField] GameObject[] enemyPrefab = new GameObject[4];


    [SerializeField] float spawnTime = 2f;
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
        EnemySpawner();
    }

    private void EnemySpawner()
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
                
                // rigidbody.AddForce(1f, downSpeed, 1f, ForceMode.Impulse);

            }
            timer = 0f;

        }
        
    }

}
