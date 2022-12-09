using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{


    [SerializeField] Transform[] teleportPoints;
    private float waitTime = 1f;
    private bool teleport = true;

    void Start()
    {

    }

    void Update()
    {

    }



    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Teleport")
        {
            if (other.gameObject.name == "0" && teleport)
            {
                teleport = false;
                transform.position = teleportPoints[3].transform.position;
                Invoke(nameof(CanTeleport), waitTime);
            }
            if (other.gameObject.name == "1" && teleport)
            {
                teleport = false;
                transform.position = teleportPoints[9].transform.position;
                Invoke(nameof(CanTeleport), waitTime);
            }
            if (other.gameObject.name == "2" && teleport)
            {
                teleport = false;
                transform.position = teleportPoints[0].transform.position;
                Invoke(nameof(CanTeleport), waitTime);
            }
          
            if (other.gameObject.name == "4" && teleport)
            {
                teleport = false;
                transform.position = teleportPoints[9].transform.position;
                Invoke(nameof(CanTeleport), waitTime);
            }
            if (other.gameObject.name == "5" && teleport)
            {
                teleport = false;
                transform.position = teleportPoints[6].transform.position;
                Invoke(nameof(CanTeleport), waitTime);
            }
            if (other.gameObject.name == "7" && teleport)
            {
                teleport = false;
                transform.position = teleportPoints[12].transform.position;
                Invoke(nameof(CanTeleport), waitTime);
            }
            if (other.gameObject.name == "8" && teleport)
            {
                teleport = false;
                transform.position = teleportPoints[6].transform.position;
                Invoke(nameof(CanTeleport), waitTime);
            }
            if (other.gameObject.name == "10" && teleport)
            {
                teleport = false;
                transform.position = teleportPoints[13].transform.position;
                Invoke(nameof(CanTeleport), waitTime);
            }
            if (other.gameObject.name == "11" && teleport)
            {
                teleport = false;
                transform.position = teleportPoints[6].transform.position;
                Invoke(nameof(CanTeleport), waitTime);
            }
        }

    }



    void CanTeleport()
    {
        teleport = true;
    }


}
