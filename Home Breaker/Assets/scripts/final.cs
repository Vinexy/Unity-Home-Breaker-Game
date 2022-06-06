using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class final : MonoBehaviour
{
    [SerializeField] Text namePrefs;
    [SerializeField] Text scorePrefs;

    void Start()
    {
        namePrefs.text = PlayerPrefs.GetString("playernamex");
        scorePrefs.text = PlayerPrefs.GetInt("score").ToString();
    }
}
