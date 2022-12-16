using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject hitEffect;



    private void Start()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            GameObject clone = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(clone, 0.3f);
            Destroy(gameObject);

        }
        if(collision.gameObject.tag == "Wall") { Destroy(gameObject); }
        
       
    }

}
