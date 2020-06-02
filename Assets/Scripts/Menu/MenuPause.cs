using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPause : MonoBehaviour
{
    public static bool GameIsPaused = false;
    //public GameObject pauseMenuUI;
    public GameObject fps;

    public bool isCursorVisible;

    private void Awake()
    {
        fps = GameObject.FindWithTag("Player");
        isCursorVisible = true;
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
                Pause();
            }
        }
        Debug.Log(isCursorVisible);
    }

    void Reprendre()
    {
        Cursor.visible = false;
        transform.GetChild(0).gameObject.SetActive(false);
        //fps.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void Pause()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        transform.GetChild(0).gameObject.SetActive(true);
        //fps.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = true;
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

