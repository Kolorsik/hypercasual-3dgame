using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdater : MonoBehaviour
{
    public GameObject scoreDisplay;
    public GameObject orbsDisplay;
    public static int orbScore;
    public static int orbCount;

    void FixedUpdate()
    {
        scoreDisplay.GetComponent<Text>().text = "Score: " + orbScore.ToString();
        orbsDisplay.GetComponent<Text>().text = "Orbs Caugh: " + orbCount.ToString();
    }
}
