using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTrigger : MonoBehaviour
{
    public float damageAmount;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            
            other.GetComponent<PlayerHealth>().affectHealth(-damageAmount);
            this.transform.position = GameManager.instance.enemySpawnPoints[Random.Range(0, GameManager.instance.enemySpawnPoints.Length)].position;
        }
    }
}
