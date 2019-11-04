using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{

    public float currentHealth = 100f;
    public float maxHealth = 100f;
    public Image healthBar;
    public GameObject deathText;

    public static bool isDead = false;
    // Start is called before the first frame update
    void Start()
    {
        isDead = false;
        updateHealthBar();
    }

    // Update is called once per frame

    public void affectHealth(float amount)
    {
        if (Timer.finishedLevel)
        {
            return;
        }
        currentHealth += amount;
        if(currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        else if(currentHealth <= 0)
        {
            currentHealth = 0;
            StartCoroutine(die());
        }
        updateHealthBar();
    }

    IEnumerator die()
    {
        isDead = true;
        GetComponent<PlayerController>().enabled = false;
        deathText.SetActive(true);
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void updateHealthBar()
    {
        float perc = currentHealth / maxHealth;
        healthBar.transform.localScale = new Vector3(perc, healthBar.transform.localScale.y, healthBar.transform.localScale.z);
    }
}
