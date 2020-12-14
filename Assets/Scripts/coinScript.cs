using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinScript : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        scoreTextScript.coinAmount += 1;
        timer.currentTime += 5;
        Destroy(gameObject);
    }
}
