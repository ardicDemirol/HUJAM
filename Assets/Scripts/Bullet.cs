using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
<<<<<<< Updated upstream
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

=======
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
>>>>>>> Stashed changes
    void Update()
    {
        
    }
<<<<<<< Updated upstream

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab,firePoints[0].position,firePoints[0].rotation);
        bullet
    }
=======
>>>>>>> Stashed changes
}
