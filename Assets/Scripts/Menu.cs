using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject RPS;
    public GameObject options;
    public AudioSource bgMusic;
    public GameObject playBtn;
    public GameObject optionsBtn;
    public GameObject quitBtn;
    public Slider slider;

    void Start()
    {
        bgMusic.Play();
        slider.value = bgMusic.volume;
        options.SetActive(false);    
    }

    public void OptionsMenu() {
        options.SetActive(true);
        playBtn.SetActive(false);
        quitBtn.SetActive(false);
        optionsBtn.SetActive(false);
        RPS.SetActive(false);
    }

    public void Back() {
        options.SetActive(false);
        playBtn.SetActive(true);
        quitBtn.SetActive(true);
        optionsBtn.SetActive(true);
        RPS.SetActive(true);
    }
    
    public void Controller() {
       bgMusic.volume = slider.value;
    }
    
}
