using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SpaceShipController : MonoBehaviour
{
    public static SpaceShipController spaceShipController; 
    [SerializeField] float moveSpeed = 5f;
    private Vector3 rotation;
    [SerializeField] float rotate = 10f;


    [SerializeField] int maxHealth = 100;
    private float currentHealth;
    private float damage;

    public bool canMove = true;

    [SerializeField] private GameObject deathScreen;
    [SerializeField] private Image healthBar;
    [SerializeField] private GameObject health;

    private float duration;
    private float enemyCount;

    private FollowEnemy enemy;
    private LevelManager levelManager;


    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip deathSound;
    [SerializeField] AudioClip winSound;
    [SerializeField] AudioClip gameplayAudio;

    public Joystick joystick;
    Vector2 movement;



    private void Awake()
    {
        spaceShipController = this;
    }

    private void Start()
    {

        audioSource = GetComponent<AudioSource>();
        enemy = GetComponent<FollowEnemy>();
        levelManager = GetComponent<LevelManager>();
        currentHealth = maxHealth;
        StartCoroutine(LoopAudio());

    }

    void Update()
    {
        duration = Time.deltaTime / 100;

        Turn();
        Die();
        Win();
        Bar();
    }


    void Turn()
    {
        if (canMove)
        {
            //if (Input.GetKey(KeyCode.D))
            //{
            //    rotation = new Vector3(0, 0, -rotate);
            //    transform.Rotate(rotation * Time.deltaTime * moveSpeed);
            //}
            //if (Input.GetKey(KeyCode.A))
            //{
            //    rotation = new Vector3(0, 0, rotate);
            //    transform.Rotate(rotation * Time.deltaTime * moveSpeed);
            //}

            movement.x = joystick.Horizontal;

            if(joystick.Horizontal >= 0.4f)
            {
                rotation = new Vector3(0, 0, -rotate);
                transform.Rotate(rotation * Time.deltaTime * moveSpeed);
            }
            if (joystick.Horizontal <= -0.4f)
            {
                rotation = new Vector3(0, 0, rotate);
                transform.Rotate(rotation * Time.deltaTime * moveSpeed);
            }
        }
    }



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            damage = UnityEngine.Random.Range(1,7);
            currentHealth -= damage; 
            healthBar.fillAmount -= damage/75;
        }
    }


    void Die()
    {
        if (healthBar.fillAmount <= 0.005f)
        {
            Destroy(gameObject);
            deathScreen.SetActive(true);
            health.SetActive(false);
            audioSource.PlayOneShot(deathSound);
        }
    }

    void Win()
    {
        if (healthBar.fillAmount >= 0.95f)
        {
            audioSource.PlayOneShot(winSound);
            int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
            SceneManager.LoadScene(nextSceneIndex);

        }

    }


    void Bar()
    {
        healthBar.fillAmount -= duration;

    }

    public void DoSmthng(float a)
    {
        healthBar.fillAmount += a;
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
