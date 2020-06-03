using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroEscape : MonoBehaviour
{
    private bool isActive;
    void Start()
    {
        isActive = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isActive)
            {
                isActive = false;
                transform.GetChild(13).gameObject.SetActive(false);
                Cursor.visible = false;
            }
            else
            {
                isActive = true;
                transform.GetChild(13).gameObject.SetActive(true);
                Cursor.visible = true;
            }
        }
    }

    public void Skip()
    {
        SceneManager.LoadScene(2);
    }
}
