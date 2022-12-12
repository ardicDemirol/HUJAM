using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{

    [SerializeField] Rigidbody2D rb;
    float currentSpeed = 1f;
    [SerializeField] private float walkSpeed = 10f;
    [SerializeField] private float runSpeed = 20f;
    [SerializeField] float jumpPower = 100f;

    private int bullet = 10;

    private int currentBullet = 100;


    private SpriteRenderer spriteRenderer;
    private Vector2 movement;
    private Animator animator;

    [SerializeField] GameObject deathScreen;

    public int GetBullet
    {
        get { return currentBullet; }
        set { currentBullet = value; }
    }

    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip deathSound;

    public bool canMove = true;

    Password password;


     void Awake()
    {
        currentSpeed = runSpeed;
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    void Start()
    {
        password = GetComponent<Password>();
        audioSource = GetComponent<AudioSource>();
    }

    private void FixedUpdate()
    {
        if (canMove )
        {
            rb.MovePosition(rb.position + movement * currentSpeed * Time.fixedDeltaTime);
        }

    }

    void Update()
    {

        Move();
        AnimatonChanger();
    }



    void Move()
    {
        if (canMove)
        {
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");

            rb.velocity = new Vector2(movement.x, movement.y).normalized;

            FlipCharcter();
        }



    }


    void AnimatonChanger()
    {
        if (canMove)
        {
            animator.SetFloat("Horizontal", movement.x);
            animator.SetFloat("Vertical", movement.y);
            animator.SetFloat("Speed", movement.sqrMagnitude);
        }
        else
        {
            Debug.Log("Ýdle durumuna geç");
        }




    }

    private void FlipCharcter()
    {
        if (movement.x < 0)
        {
            spriteRenderer.flipX = false;
        }
        else
        {
            spriteRenderer.flipX = true;
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "")
        {


        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Laser")
        {
            // Ölme Efekti;
            deathScreen.SetActive(true);
            Destroy(gameObject);
            audioSource.PlayOneShot(deathSound);
        }
       
    }




}
