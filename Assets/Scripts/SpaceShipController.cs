using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipController : MonoBehaviour
{

    [SerializeField] float moveSpeed = 5f;

    private Vector3 rotation;

    [SerializeField] float rotate = 10f;

      
    private void Start()
    {
        
    }

    void Update()
    {
       Turn();
    }

    private void FixedUpdate()
    {

        
    }

    void Turn()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rotation = new Vector3(0, 0, -rotate);
            transform.Rotate(rotation * Time.deltaTime * moveSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rotation = new Vector3(0, 0, rotate);
            transform.Rotate(rotation * Time.deltaTime * moveSpeed);
        }
    }
}
