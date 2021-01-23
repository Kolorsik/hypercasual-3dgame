using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbsGenerator : MonoBehaviour
{
    public GameObject[] orbFall;
    public bool genOrb = false;
    public int orbLoc;
    public int orbCol;

    void FixedUpdate()
    {
        if (!genOrb)
        {
            genOrb = true;
            orbLoc = Random.Range(1, 4);
            orbCol = Random.Range(0, 3);
            StartCoroutine(OrbFalling());
        }
    }

    IEnumerator OrbFalling()
    {
        Instantiate(orbFall[orbCol], new Vector3(-1.7f, 7f, 0f), Quaternion.identity);
        yield return new WaitForSeconds(0.5f);
        genOrb = false;
    }
}
