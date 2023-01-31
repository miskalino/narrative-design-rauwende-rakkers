using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public static bool PausedGame = false;
    public GameObject MenuUI;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (PausedGame)
            {
                Continue();
            } else
            {
                Pause();
            }
        }  
    }
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Continue()
    {
        MenuUI.SetActive(false);
        Time.timeScale = 1f;
        PausedGame = false;
    }

    public void Pause()
    {
        MenuUI.SetActive(true);
        Time.timeScale = 0f;
        PausedGame = true;
    }

    public void Back()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
