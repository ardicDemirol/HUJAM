using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] Rigidbody2D rb;
    float currentSpeed = 1f;
    [SerializeField] private float walkSpeed = 10f;
    [SerializeField] private float runSpeed = 20f;
    [SerializeField] float jumpPower;

    private SpriteRenderer spriteRenderer;
    private Vector2 movement;




    private void Awake()
    {
        currentSpeed = walkSpeed;
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Start()
    {

    }

    void Update()
    {
        Move();
        Jump();
        SpeedUp();
        //Flip();
    }



    void Move()
    {

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        movement = new Vector2(x, y);

        if (Input.GetKeyDown(KeyCode.A))
        {
            spriteRenderer.flipX = true;
            rb.velocity = new Vector2(0, 0);
            rb.AddForce(movement * currentSpeed * Time.deltaTime,ForceMode2D.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            spriteRenderer.flipX = false;
            rb.velocity = new Vector2(0,0);
            rb.AddForce(movement * currentSpeed * Time.deltaTime,ForceMode2D.Impulse);
        }
       
    }



    void Jump()
    {
        if (Input.GetKey(KeyCode.Space) && rb.velocity.y == 0)
        {
            //rb.AddForce(transform.up * jumpPower * Time.deltaTime);
            rb.AddForce(new Vector2(0f, 100f) * jumpPower * Time.deltaTime);
            Debug.Log("space");
        }
    }

    void SpeedUp()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            currentSpeed = runSpeed;
            rb.AddForce(movement * currentSpeed * Time.deltaTime, ForceMode2D.Impulse);
            Debug.Log("leftShift");
        }
        else
        {
            currentSpeed = walkSpeed;
            rb.AddForce(movement * currentSpeed * Time.deltaTime, ForceMode2D.Impulse);
            Debug.Log("else");
        }
    }


    void Flip()
    {

        if (movement.x < 0)
        {
            spriteRenderer.flipX = true;

            if(movement.x > 0)
            {
                spriteRenderer.flipX = false;
            }
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

    }
}
