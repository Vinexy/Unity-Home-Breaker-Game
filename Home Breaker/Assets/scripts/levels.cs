using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levels : MonoBehaviour
{
    public void level1button()
    {
        SceneManager.LoadScene("level1");
    }
    public void level2button()
    {
        SceneManager.LoadScene("level2");
    }

    public void level3button()
    {
        SceneManager.LoadScene("level3");
    }

    public void bosslevelbutton()
    {
        SceneManager.LoadScene("Bosslevel");
    }
    
   
}
