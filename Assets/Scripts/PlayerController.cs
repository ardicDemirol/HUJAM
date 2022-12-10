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

    public int GetBullet
    {
        get { return currentBullet; }
        set { currentBullet = value; }
    }



    private void Awake()
    {
        currentSpeed = runSpeed;
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    void Start()
    {

    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * currentSpeed * Time.fixedDeltaTime);
    }

    void Update()
    {
        Move();
        //AnimatonChanger();

    }




    void Move()
    {
        //animator.SetBool("idle",true);

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        rb.velocity = new Vector2(movement.x, movement.y);




        FlipCharcter();
    }


    //void AnimatonChanger()
    //{

    //    if (Input.GetKey(KeyCode.W))
    //    {
    //        animator.SetBool("idle", false);
    //        animator.SetBool("RunUp", true);
    //        animator.SetBool("RunDown",false);
    //    }
    //    if(Input.GetKey(KeyCode.S))
    //    {
    //        animator.SetBool("idle", false);
    //        animator.SetBool("RunUp", false);
    //        animator.SetBool("RunDown", true);

    //    }
    //}

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
        if (collision.gameObject.tag == "Pickable")
        {
            Destroy(collision.gameObject);
            currentBullet += bullet;
            Debug.Log(currentBullet);
        }
    }


  

}
