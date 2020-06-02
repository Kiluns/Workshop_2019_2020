using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPause : MonoBehaviour
{
    public static bool GameIsPaused = false;
    //public GameObject pauseMenuUI;
    public GameObject fps;

    private void Awake()
    {
        fps = GameObject.FindWithTag("Player");
    }
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
                Cursor.lockState = CursorLockMode.None;
                Pause();
            }
        }
    }

    void Reprendre()
    {
        transform.GetChild(0).gameObject.SetActive(false);
        //fps.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void Pause()
    {
        transform.GetChild(0).gameObject.SetActive(true);
        //fps.SetActive(false);
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

