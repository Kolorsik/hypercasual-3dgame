using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameObject timeDisplay;
    public bool countingDown = false;
    public int currentSeconds = 30;

    private Text timerText;

    void Start()
    {
        timerText = timeDisplay.GetComponent<Text>();
    }


    void Update()
    {
        if (!countingDown && currentSeconds != 0)
        {
            countingDown = true;
            StartCoroutine(SubtractSecond());
        }
    }

    IEnumerator SubtractSecond()
    {
        yield return new WaitForSeconds(1f);
        currentSeconds--;
        timerText.text = "Time: " + currentSeconds.ToString();
        countingDown = false;
    }
}
