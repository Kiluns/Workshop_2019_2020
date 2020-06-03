using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPause : MonoBehaviour
{
    public static bool GameIsPaused = false;
    //public GameObject pauseMenuUI;
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
        Time.timeScale = 1f;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        if(SceneManager.GetActiveScene().name == "Appartement")
        {
            transform.GetChild(10).gameObject.SetActive(false);
            fps.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().name == "Bureau")
        {
            transform.GetChild(3).gameObject.SetActive(false);
        }
        else
        {
            transform.GetChild(0).gameObject.SetActive(false);
        }
        
        GameIsPaused = false;
    }
    void Pause()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        if (SceneManager.GetActiveScene().name == "Appartement")
        {
            transform.GetChild(10).gameObject.SetActive(true);
            fps.SetActive(true);
        }
        else if(SceneManager.GetActiveScene().name == "Bureau")
        {
            transform.GetChild(3).gameObject.SetActive(true);
        }
        else
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }
        GameIsPaused = true;
        Time.timeScale = 0f;
    }
    public void BTMenu()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
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

