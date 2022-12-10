using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowEnemy : MonoBehaviour
{

    private Transform playerPos;
    [SerializeField] int enemyHealth = 1;

    void Awake()
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        float speed = UnityEngine.Random.RandomRange(0.05f, 2f);
        transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speed * Time.deltaTime);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Debug.Log("X");
            enemyHealth -= 1;
            if (enemyHealth < 0)
            {
                Destroy(gameObject);
            }

        }
    }

  
}
