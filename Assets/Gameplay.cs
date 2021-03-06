﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gameplay : MonoBehaviour
{
    public GameObject GOrock;
    public GameObject GOpaper;
    public GameObject GOscissors;
    public Text countdownText;
    public GameObject GOcountdown;
    private bool choseRock = false, chosePaper = false, choseScissors = false;
    private int playerScore = 0, cpuScore = 0;
    
    void Start() {
        GOcountdown.SetActive(false);
    }

    void Update() {
        if(playerScore == 3) {
            PlayerPrefs.SetString("results", "Congratulations, You've Won!");
            StartCoroutine(JustWait());
        }
        if(cpuScore == 3) {
            PlayerPrefs.SetString("results", "The Computer Won...");
            StartCoroutine(JustWait());
        }


    }
 
    public void Rock() {
        GOrock.SetActive(false);
        GOpaper.SetActive(false);
        GOscissors.SetActive(false);
        choseRock = true;  
        GOcountdown.SetActive(true);
        Game();    
    }

    
    public void Paper() {
        GOrock.SetActive(false);
        GOpaper.SetActive(false);
        GOscissors.SetActive(false);
        chosePaper = true;  
        GOcountdown.SetActive(true);
        Game();
    }

    
    public void Scissors() {
        GOrock.SetActive(false);
        GOpaper.SetActive(false);
        GOscissors.SetActive(false);
        choseScissors= true;    
        GOcountdown.SetActive(true);
        Game(); 
    }

    private void Game() {
        StartCoroutine(StartCountdown());
    }

    float currCountdownValue;

    public IEnumerator StartCountdown(float countdownValue = 3) {
        int random = Random.Range(1, 3);
        currCountdownValue = countdownValue;
        while (currCountdownValue > 0) {
            countdownText.text = currCountdownValue.ToString();
            yield return new WaitForSeconds(1.0f);
            currCountdownValue--;
        }
        if (random == 1)
        {
            countdownText.text = "CPU chose ROCK";
        } else if (random == 2) {
            countdownText.text = "CPU chose PAPER";
        } else {
            countdownText.text = "CPU chose SCISSORS";
        }
        yield return new WaitForSeconds(1.0f);
        if (choseRock && random == 3) {
                playerScore++;
                countdownText.text = playerScore.ToString() + "-" + cpuScore.ToString();
                choseRock = false;
                yield return new WaitForSeconds(1.0f);
            } else if (choseRock  && random == 1) {
                countdownText.text = playerScore.ToString() + "-" + cpuScore.ToString();
                choseRock = false;
                yield return new WaitForSeconds(1.0f);
            } else if (choseRock && random == 2) {
                cpuScore++;
                countdownText.text = playerScore.ToString() + "-" + cpuScore.ToString();
                choseRock = false;
                yield return new WaitForSeconds(1.0f);
            } else if (chosePaper && random == 3) {
                cpuScore++;
                countdownText.text = playerScore.ToString() + "-" + cpuScore.ToString();
                chosePaper = false;
                yield return new WaitForSeconds(1.0f);
            } else if (chosePaper && random == 1) {
                playerScore++;
                countdownText.text = playerScore.ToString() + "-" + cpuScore.ToString();
                chosePaper = false;
                yield return new WaitForSeconds(1.0f);
            } else if (chosePaper && random == 2) {
                countdownText.text = playerScore.ToString() + "-" + cpuScore.ToString();
                chosePaper = false;
                yield return new WaitForSeconds(1.0f);
            } else if (choseScissors && random == 3) {
                countdownText.text = playerScore.ToString() + "-" + cpuScore.ToString();
                choseScissors = false;
                yield return new WaitForSeconds(1.0f);
            } else if (choseScissors && random == 1) {
                cpuScore++;
                countdownText.text = playerScore.ToString() + "-" + cpuScore.ToString();
                choseScissors = false;
                yield return new WaitForSeconds(1.0f);
            } else {
                playerScore++;
                countdownText.text = playerScore.ToString() + "-" + cpuScore.ToString();
                choseScissors = false;
                yield return new WaitForSeconds(1.0f);
            }
            if(playerScore < 3 && cpuScore < 3) {
                GOcountdown.SetActive(false);
                GOrock.SetActive(true);
                GOpaper.SetActive(true);
                GOscissors.SetActive(true);
            }
            
    }

    public IEnumerator JustWait() {
        yield return new WaitForSeconds(1.0f);
        SceneManager.LoadScene("GameOver");
    }
}
