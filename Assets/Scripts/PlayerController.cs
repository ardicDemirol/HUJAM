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

    }

    private void FixedUpdate()
    {
        Move();
        Jump();
        SpeedUp();
    }



    void Move()
    {

        float x = Input.GetAxis("Horizontal");
        movement = new Vector2(x, 0);


        if (Input.GetKeyDown(KeyCode.A))
        {
            spriteRenderer.flipX = true;
            rb.velocity = new Vector2(-1, 0);
            rb.AddForce(movement * currentSpeed * Time.deltaTime);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //
            }
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            spriteRenderer.flipX = false;
            rb.velocity = new Vector2(1, 0);
            rb.AddForce(movement * currentSpeed * Time.deltaTime);
        }
    }



    void Jump()
    {
        rb.gravityScale = 0.85f;
        if (Input.GetKeyDown(KeyCode.Space) && rb.velocity.y == 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
            Debug.Log("zýplýyorum");

        }
        else if(rb.velocity.y < -0.1f)
        {
            rb.gravityScale = 3f;
            
            Debug.Log("Düþüyorum");
        }
    }

    void SpeedUp()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            currentSpeed = runSpeed;
            rb.AddForce(movement * currentSpeed * Time.deltaTime, ForceMode2D.Impulse);
        }
        else
        {
            currentSpeed = walkSpeed;
            rb.AddForce(movement * currentSpeed * Time.deltaTime, ForceMode2D.Impulse);
        }
    }




    private void OnCollisionEnter2D(Collision2D collision)
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

    }


}
