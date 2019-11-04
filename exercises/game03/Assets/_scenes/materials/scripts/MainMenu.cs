using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void onPlayClick()
    {
        SceneManager.LoadScene(1);
    }

    public void onQuitClick()
    {
        Application.Quit();
    }
}
