using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowEnemy : MonoBehaviour
{

    private Transform playerPos;
    [SerializeField] int enemyHealth = 1;

    [SerializeField] GameObject explosionEffect;
    [SerializeField] GameObject explosionEffect2;

    public float count;

    void Awake()
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").transform;
    }
    private void Start()
    {
        int health = enemyHealth;
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
                Count();
                Destroy(gameObject);
                GameObject explosionEffectClone = Instantiate(explosionEffect, transform.position, Quaternion.identity);
                Destroy(explosionEffectClone, 0.2f);
                
            }
        }
        if(collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            GameObject explosionEffectClone2 = Instantiate(explosionEffect2, transform.position, Quaternion.identity);
            Destroy(explosionEffectClone2, 0.2f);

        }
    }


    public float Count()
    {
        count /= 100;
        return count;
    }
   


}
