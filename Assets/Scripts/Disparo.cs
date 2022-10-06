using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    [SerializeField] Transform prefabExplosion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ( transform.position.y > 6.7)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Enemigo")
        {
            Instantiate(prefabExplosion,
                other.transform.position, Quaternion.identity);
            Destroy(other.gameObject);
            Destroy(prefabExplosion.gameObject, 1f);
            Destroy(gameObject);
           
        }
       
    }
}
