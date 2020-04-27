using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Text resultsText;
    void Start()
    {
        resultsText.text = PlayerPrefs.GetString("results");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
