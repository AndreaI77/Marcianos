using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Security.Cryptography;
using UnityEngine;

public class Nave : MonoBehaviour
{
    //he puesto la velocidad a 4, ya que iba muy lento. 
    [SerializeField] float velocidad = 4;
    [SerializeField] Transform prefabDisparo;
    private float velocidadDisparo = 4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        //if ((transform.position.x > -9.2) && (transform.position.x < 9.2))
        //{
        //    transform.translate(horizontal * velocidad * time.deltatime, 0, 0);
        //    debug.log(time.deltatime + "seg," + (1.0f / time.deltatime) + "fps");
        //}
        //else
        //{
        //    transform.translate(0, 0, 0);
        //}
        transform.Translate(horizontal * velocidad * Time.deltaTime, 0, 0);

        if (Input.GetButtonDown("Fire1"))
        {
            GetComponent<AudioSource>().Play();
            Transform disparo= Instantiate(prefabDisparo, transform.position, Quaternion.identity);
            disparo.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0, velocidadDisparo, 0);
            // UnityEngine.Debug.Log("hola");
            
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        UnityEngine.Debug.Log("Hola");
    }
}
