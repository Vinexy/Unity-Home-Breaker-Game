using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class falling_item_rotation : MonoBehaviour
{
    Rigidbody2D physics;
    [SerializeField] float vel;

    [SerializeField] GameObject explosion;
    private void Start()
    {
        physics = GetComponent<Rigidbody2D>();
        physics.velocity = transform.forward * vel;
        physics.angularVelocity = 1200f;
        

    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "pedal")
        {

            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(collision.gameObject);
            StartCoroutine(time());





        }
    }
    private IEnumerator time()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("GameOver");
    }
}
