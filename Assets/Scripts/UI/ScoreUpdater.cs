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

    private Text textScore;
    private Text textOrbsCount;

    void Start()
    {
        textScore = scoreDisplay.GetComponent<Text>();
        textOrbsCount = orbsDisplay.GetComponent<Text>();
    }

    void FixedUpdate()
    {
        textScore.text = "Score: " + orbScore.ToString();
        textOrbsCount.text = "Orbs Caugh: " + orbCount.ToString();
    }
}
