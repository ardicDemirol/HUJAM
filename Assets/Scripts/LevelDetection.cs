using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelDetection : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
            Debug.Log("gvbg");
        }

    }



}


