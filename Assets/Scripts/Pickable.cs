using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable : MonoBehaviour
{


    PlayerController playerController;
    int bull;
    

    private void Awake()
    {
        playerController = GetComponent<PlayerController>();
        

    }

    private void Start()
    {
        //bull = playerController.GetBullet;
    }

    private void Update()
    {
        Debug.Log(bull);
    }




}
