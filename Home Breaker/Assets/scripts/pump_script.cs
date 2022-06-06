using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pump_script : MonoBehaviour
{
    private int counter = 2;
    [SerializeField] GameObject explosion;
    [SerializeField] GameObject explosionSound;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ball")
        {
            counter--;
            if (counter == 0)
            {

                Instantiate(explosion, transform.position, transform.rotation);
                Instantiate(explosionSound, transform.position, transform.rotation);
                Destroy(gameObject);

            }



        }



    }
}