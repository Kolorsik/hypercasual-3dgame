using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchFunctions : MonoBehaviour
{
    public GameObject leftPlatfolm;
    public GameObject middlePlatfolm;
    public GameObject rightPlatfolm;
    public bool activePlat = false;
    public AudioSource platActioveFX;

    public void LeftPlat()
    {
        if (!activePlat)
        {
            activePlat = true;
            platActioveFX.Play();
            leftPlatfolm.SetActive(true);
            StartCoroutine(LeftReset());
        }
    }

    public void MiddlePlat()
    {
        if (!activePlat)
        {
            activePlat = true;
            platActioveFX.Play();
            middlePlatfolm.SetActive(true);
            StartCoroutine(MiddleReset());
        }
    }

    public void RightPlat()
    {
        if (!activePlat)
        {
            activePlat = true;
            platActioveFX.Play();
            rightPlatfolm.SetActive(true);
            StartCoroutine(RightReset());
        }
    }

    IEnumerator LeftReset()
    {
        yield return new WaitForSeconds(0.5f);
        leftPlatfolm.SetActive(false);
        activePlat = false;
    }

    IEnumerator MiddleReset()
    {
        yield return new WaitForSeconds(0.5f);
        middlePlatfolm.SetActive(false);
        activePlat = false;
    }

    IEnumerator RightReset()
    {
        yield return new WaitForSeconds(0.5f);
        rightPlatfolm.SetActive(false);
        activePlat = false;
    }
}
