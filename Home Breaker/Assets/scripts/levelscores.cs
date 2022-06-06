using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class levelscores : MonoBehaviour
{
    [SerializeField] Text namePrefs;
    [SerializeField] Text scorePrefs;

    void Update()
    {
        namePrefs.text = PlayerPrefs.GetString("playernamex");
        scorePrefs.text = PlayerPrefs.GetInt("score").ToString();
    }
}
