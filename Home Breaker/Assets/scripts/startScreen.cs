using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class startScreen : MonoBehaviour
{
    [SerializeField] InputField playernamex;
    
    public void playButton()
    {
        PlayerPrefs.SetString("playernamex", playernamex.text);
        SceneManager.LoadScene("levels");
        

    }


}
