using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    public Text loseText;
    public float initialTime;

    private float timeLeft;
    bool isDone = false;

    void Start()
    {
        timeLeft = initialTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isDone)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft < 0)
            {
                isDone = true;
                timeLeft = 0;
                loseText.gameObject.SetActive(true);
            }
            updateTimerText();
        }
    }

    void updateTimerText()
    {
        timerText.text = timeLeft.ToString("0.#");
    }
}
