using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{

    public float healthAmount = 10f;

   
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            

            Score.instance.increaseScore();
            other.GetComponent<PlayerHealth>().affectHealth(healthAmount);
            Destroy(this.gameObject);
            
        }
    }
}
