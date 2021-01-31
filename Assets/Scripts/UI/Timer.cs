using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameObject timeDisplay;
    public bool countingDown = false;
    public int currentSeconds = 30;
    public GameObject splashBackground;
    public GameObject bgm;
    public GameObject globalScripts;
    public GameObject tapPlayButton;
    public GameObject finalScore;
    public GameObject finalOrbs;
    public GameObject tapToBeginText;

    private Text timerText;
    private Text scoreText;
    private Text orbsText;

    void Start()
    {
        timerText = timeDisplay.GetComponent<Text>();
        scoreText = finalScore.GetComponent<Text>();
        orbsText = finalOrbs.GetComponent<Text>();
    }


    void Update()
    {
        if (!countingDown && currentSeconds != 0)
        {
            countingDown = true;
            StartCoroutine(SubtractSecond());
        }

        if (currentSeconds == 0)
        {
            scoreText.text = "Score: " + ScoreUpdater.orbScore.ToString();
            orbsText.text = "Orbs Catch: " + ScoreUpdater.orbCount.ToString();
            StartCoroutine(GameOver());
        }
    }

    IEnumerator GameOver()
    {
        splashBackground.SetActive(true);
        splashBackground.GetComponent<Animator>().Play("SplashFadeIn");
        bgm.SetActive(false);
        globalScripts.GetComponent<OrbsGenerator>().enabled = false;
        yield return new WaitForSeconds(1.2f);
        finalScore.SetActive(true);
        finalOrbs.SetActive(true);
        tapToBeginText.SetActive(true);
        tapPlayButton.SetActive(true);
        currentSeconds = 31;
        ScoreUpdater.orbScore = 0;
        ScoreUpdater.orbCount = 0;
        yield return new WaitForSeconds(0.1f);
        globalScripts.GetComponent<Timer>().enabled = false;
    }

    IEnumerator SubtractSecond()
    {
        yield return new WaitForSeconds(1f);
        currentSeconds--;
        timerText.text = "Time: " + currentSeconds.ToString();
        countingDown = false;
    }
}
