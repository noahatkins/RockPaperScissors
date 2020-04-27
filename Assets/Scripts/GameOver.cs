using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Text resultsText;
    public AudioSource win, lose;
    public int results;
    void Start()
    {
        results = PlayerPrefs.GetInt("whowon");
        resultsText.text = PlayerPrefs.GetString("results");
        if (results == 1)
        {
            win.Play();
        } else {
            lose.Play();
        }
    }
}
