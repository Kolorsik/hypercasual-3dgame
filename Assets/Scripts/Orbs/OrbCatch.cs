using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrbCatch : MonoBehaviour
{
    public AudioSource orbCatchFX;
    private void OnTriggerEnter(Collider other)
    {
        orbCatchFX.Play();
        switch(other.tag)
        {
            case "BlueOrb":
                {
                    ScoreUpdater.orbScore += 1;
                    break;
                }
            case "RedOrb":
                {
                    ScoreUpdater.orbScore += 2;
                    break;
                }
            case "GreenOrb":
                {
                    ScoreUpdater.orbScore += 3;
                    break;
                }
        }
        other.gameObject.SetActive(false);
    }
}
