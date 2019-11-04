using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTrigger : MonoBehaviour
{
    public float damageAmount;
    public GameObject explodeParticles;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            
            other.GetComponent<PlayerHealth>().affectHealth(-damageAmount);
            relocateEnemy();
        }
    }
    public void relocateEnemy()
    {
        Instantiate(explodeParticles, this.transform.position, Quaternion.identity);
        this.transform.position = GameManager.instance.enemySpawnPoints[Random.Range(0, GameManager.instance.enemySpawnPoints.Length)].position;
        GetComponent<EnemyMovement>().randomizeSpeed();
    }
}
