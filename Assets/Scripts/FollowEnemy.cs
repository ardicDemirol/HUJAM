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

        Vector3 diff = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        diff.Normalize();
        float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rot_z - 90);

    }

    void Update()
    {
        float speed = UnityEngine.Random.Range(0.005f, 2.25f);
        transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speed * Time.deltaTime);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            enemyHealth -= 1;
            if (enemyHealth < 0)
            {
                SpaceShipController.spaceShipController.DoSmthng(Count());
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
