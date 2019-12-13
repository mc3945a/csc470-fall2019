using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    public float amount = 10f;

    private void OnTriggerEnter(Collider col)
    {
        if(col.CompareTag("Player"))
        {
            col.GetComponent<CountDown>().addTime(amount);
            Destroy(this.gameObject);
        }
    }
}
