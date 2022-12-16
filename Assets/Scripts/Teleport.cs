using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{


    [SerializeField] Transform[] teleportPoints;
    private float waitTime = 1f;
    

    Rigidbody2D rigidbody;
    PlayerController playerController;
    Animator animator;

    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip teleportSound;

    void Start()
    {
        animator = GetComponent<Animator>();
        playerController = GetComponent<PlayerController>();
        audioSource = GetComponent<AudioSource>();
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        waitTime += Time.deltaTime;
    }


    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Teleport")
        {

            if (other.gameObject.name == "0" && playerController.canMove == true)
            {
                audioSource.PlayOneShot(teleportSound);
                transform.position = teleportPoints[4].transform.position;
                Wait();
                Invoke(nameof(Resume),1f);

            }
            if (other.gameObject.name == "1" && playerController.canMove == true)
            {
                audioSource.PlayOneShot(teleportSound);
                transform.position = teleportPoints[10].transform.position;
                Wait();
                Invoke(nameof(Resume), 1f);
            }
            if (other.gameObject.name == "2" && playerController.canMove == true)
            {
                audioSource.PlayOneShot(teleportSound);
                transform.position = teleportPoints[0].transform.position;
                Wait();
                Invoke(nameof(Resume), 1f);
            }
            if (other.gameObject.name == "4" && playerController.canMove == true)
            {
                audioSource.PlayOneShot(teleportSound);
                transform.position = teleportPoints[10].transform.position;
                Wait();
                Invoke(nameof(Resume), 1f);
            }
            if (other.gameObject.name == "5" && playerController.canMove == true)
            {
                audioSource.PlayOneShot(teleportSound);
                transform.position = teleportPoints[7].transform.position;
                Wait();
                Invoke(nameof(Resume), 1f);
            }
            if (other.gameObject.name == "7" && playerController.canMove == true)
            {
                audioSource.PlayOneShot(teleportSound);
                transform.position = teleportPoints[13].transform.position;
                Wait();
                Invoke(nameof(Resume), 1f);
            }
            if (other.gameObject.name == "8" && playerController.canMove == true)
            {
                audioSource.PlayOneShot(teleportSound);
                transform.position = teleportPoints[7].transform.position;
                Wait();
                Invoke(nameof(Resume), 1f);
            }
            if (other.gameObject.name == "10" && playerController.canMove == true)
            {
                audioSource.PlayOneShot(teleportSound);
                transform.position = teleportPoints[14].transform.position;
                Wait();
                Invoke(nameof(Resume), 1f);
            }
            if (other.gameObject.name == "11" && playerController.canMove == true)
            {
                audioSource.PlayOneShot(teleportSound);
                transform.position = teleportPoints[7].transform.position;
                Wait();
                Invoke(nameof(Resume), 1f);
            }
            if (other.gameObject.name == "14" && playerController.canMove == true)
            {
                audioSource.PlayOneShot(teleportSound);
                transform.position = teleportPoints[0].transform.position;
                Wait();
                Invoke(nameof(Resume), 1f);
            }
        }

    }
    
    public void Wait()
    {
        playerController.canMove = false;
        rigidbody.velocity = new Vector2(0f, 0f);
        animator.SetFloat("Speed", 0);
    }

    public void Resume()
    {
        playerController.canMove = true;
    }
    


}
