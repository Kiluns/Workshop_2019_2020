using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPause : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject fps;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            if (GameIsPaused)
            {
                
                Reprendre();
            }
            else
            {
                Pause();
            }
        }
    }

    void Reprendre()
    {
        pauseMenuUI.SetActive(false);
        fps.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        fps.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void BTMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void BTReprendre()
    {
        Reprendre();
    }
    public void BTQuitter()
    {
        Application.Quit();
    }
}

