using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdater : MonoBehaviour
{
    public GameObject scoreDisplay;
    void Start()
    {
        scoreDisplay.GetComponent<Text>().text = "Score: 10";
        
    }

    void FixUpdate()
    {
        
    }
}
