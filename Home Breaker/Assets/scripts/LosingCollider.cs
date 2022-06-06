using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LosingCollider : MonoBehaviour
{
    
    
private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "ball")
        {
            
            SceneManager.LoadScene("GameOver");
        }
        
    }


}
