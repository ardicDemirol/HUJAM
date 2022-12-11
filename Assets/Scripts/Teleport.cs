using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{


    [SerializeField] Transform[] teleportPoints;
    private float waitTime = 1f;
    private bool teleport = true;

    private Rigidbody2D rigidbody;

    void Start()
    {
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
                teleport = false;
                transform.position = teleportPoints[4].transform.position;
                StartCoroutine(Wait());
            }
            if (other.gameObject.name == "1")
            {
                teleport = false;
                transform.position = teleportPoints[10].transform.position;
                StartCoroutine(Wait());
            }
            if (other.gameObject.name == "2")
            {
                teleport = false;
                transform.position = teleportPoints[0].transform.position;
                StartCoroutine(Wait());
            }
            if (other.gameObject.name == "4" )
            {
                teleport = false;
                transform.position = teleportPoints[10].transform.position;
                StartCoroutine(Wait());
            }
            if (other.gameObject.name == "5")
            {
                teleport = false;
                transform.position = teleportPoints[7].transform.position;
                StartCoroutine(Wait());
            }
            if (other.gameObject.name == "7" )
            {
                teleport = false;
                transform.position = teleportPoints[13].transform.position;
                StartCoroutine(Wait());
            }
            if (other.gameObject.name == "8" )
            {
                teleport = false;
                transform.position = teleportPoints[7].transform.position;
                StartCoroutine(Wait());
            }
            if (other.gameObject.name == "10" )
            {
                teleport = false;
                transform.position = teleportPoints[14].transform.position;
                StartCoroutine(Wait());
            }
            if (other.gameObject.name == "11" )
            {
                teleport = false;
                transform.position = teleportPoints[7].transform.position;
                StartCoroutine(Wait());
            }
            if(other.gameObject.name == "14" )
            {
                transform.position = teleportPoints[0].transform.position;
                StartCoroutine(Wait());
            }
        }

    }

    IEnumerator Wait()
    {
        while (true)
        {
            rigidbody.velocity = Vector2.zero;
            yield return new WaitForSeconds(waitTime);
        }
    }


}
