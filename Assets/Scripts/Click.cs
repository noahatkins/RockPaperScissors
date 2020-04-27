using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    public AudioSource click;
    public AudioSource hover;
    public void Clicked() {
         click.Play();
         DontDestroyOnLoad(click);
    }
    public void Hovered() {
        hover.Play();
    }

}
