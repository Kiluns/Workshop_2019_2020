using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouttonMenu : MonoBehaviour
{
    public AudioSource myClip;
    public GameObject menu;
    public GameObject monButton;

    bool ReadyToLoad = false;

    
    void Update()
    {
        if (ReadyToLoad == true && !myClip.isPlaying)
        {
            menu.SetActive(true);
            monButton.SetActive(false);
            ReadyToLoad = false;
        }
    }
    public void BoutonMenu()
    {
        myClip.Play(0);
        ReadyToLoad = true;
    }
}