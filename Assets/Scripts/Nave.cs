using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Nave : MonoBehaviour
{
    //he puesto la velocidad a 4, ya que iba muy lento. 
    [SerializeField] float velocidad = 4; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        transform.Translate(horizontal * velocidad * Time.deltaTime, 0, 0);
        //Debug.Log(Time.deltaTime + "seg," + (1.0f / Time.deltaTime) + "FPS");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        UnityEngine.Debug.Log("Hola");
    }
}
