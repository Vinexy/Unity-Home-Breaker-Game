using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class scarecrow_script : MonoBehaviour
{
    // Start is called before the first frame update
    
    private int health = 100;
    [SerializeField] GameObject explosion;
    [SerializeField] GameObject explosionSound;
    [SerializeField] Text lives;

    private void Start()
    {
        lives.text = "Boss Health: " + health.ToString();
    }
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ball")
        {
            health-=10;
            lives.text = "Boss Health: " + (health).ToString();
            if (health == 0)
            {

                Instantiate(explosion, transform.position, transform.rotation);
                Instantiate(explosionSound, transform.position, transform.rotation);
                Destroy(gameObject);
                StartCoroutine(time());


            }



        }



    }
    private IEnumerator time()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("GameOver");
    }


}
