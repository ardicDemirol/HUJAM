using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{


    [SerializeField] Transform[] teleportPoints;
    private float waitTime = 2f;
    private bool teleport = true;

    private Rigidbody2D rigidbody;


    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip teleportSound;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

    }



    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Teleport")
        {
            
            if (other.gameObject.name == "0")
            {
                audioSource.PlayOneShot(teleportSound);
                transform.position = teleportPoints[4].transform.position;
                StartCoroutine(Wait());
            }
            if (other.gameObject.name == "1")
            {
                audioSource.PlayOneShot(teleportSound);
                transform.position = teleportPoints[10].transform.position;
                StartCoroutine(Wait());
            }
            if (other.gameObject.name == "2")
            {
                audioSource.PlayOneShot(teleportSound);
                transform.position = teleportPoints[0].transform.position;
                StartCoroutine(Wait());
            }
            if (other.gameObject.name == "4" )
            {
                audioSource.PlayOneShot(teleportSound);
                transform.position = teleportPoints[10].transform.position;
                StartCoroutine(Wait());
            }
            if (other.gameObject.name == "5")
            {
                audioSource.PlayOneShot(teleportSound);
                transform.position = teleportPoints[7].transform.position;
                StartCoroutine(Wait());
            }
            if (other.gameObject.name == "7" )
            {
                audioSource.PlayOneShot(teleportSound);
                transform.position = teleportPoints[13].transform.position;
                StartCoroutine(Wait());
            }
            if (other.gameObject.name == "8" )
            {
                audioSource.PlayOneShot(teleportSound);
                transform.position = teleportPoints[7].transform.position;
                StartCoroutine(Wait());
            }
            if (other.gameObject.name == "10" )
            {
                audioSource.PlayOneShot(teleportSound);
                transform.position = teleportPoints[14].transform.position;
                StartCoroutine(Wait());
            }
            if (other.gameObject.name == "11" )
            {
                audioSource.PlayOneShot(teleportSound);
                transform.position = teleportPoints[7].transform.position;
                StartCoroutine(Wait());
            }
            if(other.gameObject.name == "14" )
            {
                audioSource.PlayOneShot(teleportSound);
                transform.position = teleportPoints[0].transform.position;
                StartCoroutine(Wait());
            }
        }

    }

    IEnumerator Wait()
    {
        while (true)
        {
            rigidbody.velocity = new Vector2(0f,0f);
            yield return new WaitForSeconds(waitTime);
        }
    }


}
