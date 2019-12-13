using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public float time = 120; //Seconds Overall
    public Text countdown; //UI Text Object
    public Transform healthBar;
    public ControlCar carController;
    public GameObject loseMenu;

    private float timeLeft;
    private bool isDead = false;

    void Start()
    {
        timeLeft = time;
        updateTimeText();
        updateHealthBar();
        Time.timeScale = 1; //Just making sure that the timeScale is right
    }

    void Update()
    {
        if(!isDead)
        {
            if (timeLeft > 0f)
            {
                timeLeft -= Time.deltaTime;
            }
            else
            {
                timeLeft = 0f;
                isDead = true;
                die();
            }
            updateHealthBar();
            updateTimeText();
        }
    }

    public void addTime(float amount)
    {
        if(!isDead)
        {
            timeLeft += amount;
            if(timeLeft > time)
            {
                timeLeft = time;
            }
            updateHealthBar();
            updateTimeText();
        }
    }

    private void updateHealthBar()
    {
        float x = timeLeft / time;
        healthBar.localScale = new Vector3(x, healthBar.localScale.y, healthBar.localScale.z);
    }

    private void updateTimeText()
    {
        countdown.text = timeLeft.ToString("N2"); //Showing the Score on the Canvas
    }

    private void die()
    {
        carController.enabled = false;
        loseMenu.SetActive(true);
    }
}