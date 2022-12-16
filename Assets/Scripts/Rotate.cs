using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{


    float platform_x;
    float platform_y;


    [SerializeField] float pos_x_limite;
    [SerializeField] float pos_y_limite;

    [SerializeField] float speed = 5f;


    void Start()
    {
        platform_x = transform.position.x;
        platform_y = transform.position.y;

    }

    void Update()
    {
        if (pos_y_limite > 0)
        {
            transform.position= new Vector2(platform_x, platform_y + Mathf.PingPong(Time.time / speed, pos_y_limite)) ;

        }
        if (pos_x_limite > 0)
        {
            transform.position = new Vector2(platform_x + Mathf.PingPong(Time.time / speed, pos_x_limite), platform_y) ;

        }

    }

    
}
