using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{

    public float currentHealth = 100f;
    public float maxHealth = 100f;
    public Image healthBar;
    // Start is called before the first frame update
    void Start()
    {
        updateHealthBar();
    }

    // Update is called once per frame

    public void affectHealth(float amount)
    {
        currentHealth += amount;
        if(currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        else if(currentHealth <= 0)
        {
            currentHealth = 0;
            die();
        }
        updateHealthBar();
    }

    void die()
    {
        //todo
    }

    void updateHealthBar()
    {
        float perc = currentHealth / maxHealth;
        healthBar.transform.localScale = new Vector3(perc, healthBar.transform.localScale.y, healthBar.transform.localScale.z);
    }
}
