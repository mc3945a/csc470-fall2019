using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public float rechargeTime = 5f;
    public Transform rechargeBar;
    private GameObject[] enemies;
    private float currentChargeTime;
    void Start()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        currentChargeTime = rechargeTime;
        updateRechargeBar();
    }

    void Update()
    {
        currentChargeTime += Time.deltaTime;
        if (currentChargeTime > rechargeTime)
        {
            currentChargeTime = rechargeTime;
        }
        updateRechargeBar();
    }
    public void onButtonPress()
    {
        if(currentChargeTime >= rechargeTime)
        {
            currentChargeTime = 0f;
            updateRechargeBar();
            doBomb();
        }

    }

    void doBomb()
    {
        for (int i = 0; i < enemies.Length; i++)
        {
            enemies[i].GetComponent<DamageTrigger>().relocateEnemy();
        }

    }
    void updateRechargeBar()
    {
        float perc = currentChargeTime / rechargeTime;
        rechargeBar.localScale = new Vector3(perc, rechargeBar.localScale.y, rechargeBar.localScale.z);
    }
}
