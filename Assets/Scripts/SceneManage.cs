using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour
{
    private GameObject music;
    public void ChangeScene(string scenename) {
        SceneManager.LoadScene(scenename);
    }

    void Awake() {
        music = GameObject.Find("BG");
        DontDestroyOnLoad(music);
    }

    public void Quit() {
        Application.Quit();
    }

    public void DestroyMusic() {
        Destroy(music);
    }
}
