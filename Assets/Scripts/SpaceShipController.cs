using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpaceShipController : MonoBehaviour
{

    [SerializeField] float moveSpeed = 5f;
    private Vector3 rotation;
    [SerializeField] float rotate = 10f;


    [SerializeField] int maxHealth = 100;
    private int currentHealth;



    [SerializeField] private GameObject deathScreen;
    [SerializeField] private Image healthBar;

    FollowEnemy enemy;


    private void Start()
    {
        currentHealth = maxHealth;
        enemy = GetComponent<FollowEnemy>();
    }

    void Update()
    {
       Turn();
    }

    private void FixedUpdate()
    {

        
    }

    void Turn()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rotation = new Vector3(0, 0, -rotate);
            transform.Rotate(rotation * Time.deltaTime * moveSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rotation = new Vector3(0, 0, rotate);
            transform.Rotate(rotation * Time.deltaTime * moveSpeed);
        }
    }



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            currentHealth -= enemy.enemyHealth;
            Debug.Log("Playere çarptý");
        }
    }
}
