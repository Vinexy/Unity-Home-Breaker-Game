using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ball : MonoBehaviour
{
    [SerializeField] GameObject gamePedal;
    Vector2 pedalPozisyonu;
    Vector2 vel;

    




    void Start()
    {
        pedalPozisyonu = new Vector2(transform.position.x - gamePedal.transform.position.x , transform.position.y - gamePedal.transform.position.y);

    }

    // Update is called once per frame
    void Update()
    {
        BallPedala();
        



    }

    

    private void BallPedala()
    {
        Vector2 updatePedal = new Vector2(gamePedal.transform.position.x, gamePedal.transform.position.y);
        transform.position = updatePedal + pedalPozisyonu;
        if (Input.GetMouseButtonDown(0))
        {

            Firlat();
            enabled = false;

        }
    }

    private void Firlat()
    {
        vel = GetComponent<Rigidbody2D>().velocity = new Vector2(1.5f, 8f);
    }

    


}
