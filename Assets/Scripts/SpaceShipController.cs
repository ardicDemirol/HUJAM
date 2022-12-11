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
    private int damage;



    [SerializeField] private GameObject deathScreen;
    [SerializeField] private Image healthBar;



    private void Start()
    {
        currentHealth = maxHealth;
    }

    void Update()
    {
        Turn();
        Die();
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
            damage = UnityEngine.Random.Range(1, 6);
            currentHealth -= damage;
            Debug.Log(currentHealth);
        }
    }


    void Die()
    {
        if (currentHealth < 0)
        {
            Destroy(gameObject);
            deathScreen.SetActive(true);
            
        }
    }
}
