using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{

    [SerializeField] Rigidbody2D rb;
    [SerializeField] float runSpeed = 1f;


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
    [SerializeField] AudioClip gameplayAudio;


    public bool canMove = true;


    public Joystick joystick;



    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    void Start()
    {
        StartCoroutine(LoopAudio());
        audioSource = GetComponent<AudioSource>();
    }

    private void FixedUpdate()
    {
        if (canMove)
        {
            rb.MovePosition(rb.position + movement * runSpeed * Time.fixedDeltaTime);
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
            // PC INPUT //
            //movement.x = Input.GetAxisRaw("Horizontal");
            //movement.y = Input.GetAxisRaw("Vertical");

            // MOBIL INPUT //

            //movement.x = joystick.Horizontal;
            //movement.y = joystick.Vertical;

            if (joystick.Horizontal >= 0.75f)
            {
                movement.x = runSpeed;
                movement.y = 0.2f;
                Debug.Log("x >= .2f");
            }
            else if (joystick.Horizontal <= -0.75f)
            {
                movement.x = -runSpeed;
                movement.y = 0.2f;
                Debug.Log("x <= .2f");
            }
            else if (joystick.Vertical >= 0.5f)
            {
                movement.y = runSpeed;
                movement.x = 0.2f;
                Debug.Log("y >= .5f");
            }
            else if (joystick.Vertical <= -0.5f)
            {
                movement.y = -runSpeed;
                movement.x = 0.2f;
                Debug.Log("y <= .5f");
            }
            else
            {
                movement.x = 0;
                movement.y = 0;
            }
           
            rb.velocity = new Vector2(movement.x, movement.y).normalized;

            FlipCharcter();
        }
    }



    void AnimatonChanger()
    {
        if (canMove)
        {
            animator.SetFloat("Horizontal", joystick.Horizontal);
            animator.SetFloat("Vertical", joystick.Vertical);
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


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Laser")
        {
            audioSource.PlayOneShot(deathSound);
            deathScreen.SetActive(true);
            
        }

    }

    IEnumerator LoopAudio()
    {
        float length = gameplayAudio.length;

        while (true)
        {
            audioSource.PlayOneShot(gameplayAudio);
            yield return new WaitForSeconds(length);
        }
    }

}
