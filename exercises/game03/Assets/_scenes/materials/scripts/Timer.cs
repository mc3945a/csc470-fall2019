using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float initialTime = 30f;
    public Text TimerText;
    private float currentTime;
    public static bool finishedLevel = false;
    public GameObject finishedLevelText;


    // Start is called before the first frame update
    void Start()
    {
        currentTime = initialTime;
         updateTimerText();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerHealth.isDead)
        {
            return;
        }
        currentTime -= Time.deltaTime;
        if (currentTime <= 0 && !finishedLevel)
        {
            currentTime = 0;
            updateTimerText();
            StartCoroutine(waitforNextLevelLoad());
        }
        if (!finishedLevel)
        {
            updateTimerText();
        }
        
    }
    IEnumerator waitforNextLevelLoad()
    {
        finishedLevel = true;
        finishedLevelText.SetActive(true);
        yield return new WaitForSeconds(5f);
        finishedLevel = false;

        if (SceneManager.GetActiveScene().buildIndex == SceneManager.sceneCountInBuildSettings - 1)
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    void updateTimerText()
    {
        TimerText.text = currentTime.ToString("N0");
    }
}
