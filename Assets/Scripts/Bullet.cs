using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject hitEffect;
    

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.tag == "Enemy")
    //    {
    //        GameObject clone = Instantiate(hitEffect, transform.position, Quaternion.identity);
    //        Destroy(clone,0.3f);
    //        Destroy(gameObject);
    //        Debug.Log("Enemy");
    //    }
    //    else
    //    {
    //        Destroy(gameObject);
    //    }
    //}

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
