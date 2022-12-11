using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowEnemy : MonoBehaviour
{

    private Transform playerPos;
    [SerializeField] int enemyHealth = 1;

    [SerializeField] GameObject explosionEffect;
    [SerializeField] GameObject explosionEffect2;

    void Awake()
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        float speed = UnityEngine.Random.Range(0.005f, 2f);
        transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speed * Time.deltaTime);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            enemyHealth -= 1;
            if (enemyHealth < 0)
            {
                Destroy(gameObject);
                GameObject explosionEffectClone = Instantiate(explosionEffect, transform.position, Quaternion.identity);
                Destroy(explosionEffectClone, 0.2f);
            }
        }
        if(collision.gameObject.tag == "Player")
        {
            GameObject explosionEffectClone2 = Instantiate(explosionEffect2, transform.position, Quaternion.identity);
            Destroy(explosionEffectClone2, 0.2f);

        }
    }

   


}
