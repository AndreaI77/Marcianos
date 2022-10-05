using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float velocidadX = 2;
    private float velocidadY = -1.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(velocidadX * Time.deltaTime, velocidadY * Time.deltaTime, 0);
        if ((transform.position.x < -9.2) || (transform.position.x > 9.2))
        {
            velocidadX = -velocidadX;
        }
        if ((transform.position.y < -6.6) || (transform.position.y > 6.6))
        {
            velocidadY = -velocidadY;
        }

    }
}
