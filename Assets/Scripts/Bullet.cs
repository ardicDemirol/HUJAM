using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject hitEffect;
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject clone = Instantiate(hitEffect, transform.position, Quaternion.identity);
        Destroy(clone,1f);
        Destroy(gameObject);

        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("Enemy");
        }       
    }

}
