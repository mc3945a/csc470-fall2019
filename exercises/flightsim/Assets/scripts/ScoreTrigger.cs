using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    public int scoreAmount = 1;

    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            Score.instance.increaseScore(scoreAmount);
            GetComponent<BoxCollider>().enabled = false;
        }
    }
}
