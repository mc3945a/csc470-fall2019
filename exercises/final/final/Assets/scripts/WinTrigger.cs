using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    public GameObject winScreen;
    public ControlCar carController;

    private void OnTriggerEnter(Collider col)
    {
        if(col.CompareTag("Player"))
        {
            winScreen.SetActive(true);
            carController.enabled = false;
        }
    }
}
