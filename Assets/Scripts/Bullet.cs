using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Transform[] firePoints;
    public GameObject bulletPrefab;

    public float bulletForce = 20f;

    void Start()
    {
        if (Input.GetMouseButton(0))
        {
            Shoot();
        }
    }

    void Update()
    {
        
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab,firePoints[0].position,firePoints[0].rotation);
        bullet
    }
}
