using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class box : MonoBehaviour
{

    [SerializeField] GameObject explosion;
    [SerializeField] GameObject explosionSound;
 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ball")
        {
            
            
            Instantiate(explosion, transform.position, transform.rotation);
            Instantiate(explosionSound, transform.position, transform.rotation);
            Destroy(gameObject);




        }
      


    }
}
