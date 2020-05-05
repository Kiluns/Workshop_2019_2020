using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class OptionMenu : MonoBehaviour
{
    public AudioMixer audioMixer;    

    public AudioSource myClip;
    public GameObject option;
    public GameObject menu;

    bool ReadyToLoad = false;
    bool boutonMenu = false;
    bool boutonPlay = false;


    private static OptionMenu s_instance = null;
    void Awake()
    {
        option = GameObject.FindWithTag("Option");
        myClip = GameObject.FindWithTag("MainCamera").GetComponent<AudioSource>();

        GameObject[] objs = GameObject.FindGameObjectsWithTag("Option");

        if (objs.Length >= 1)
        {
            if (s_instance == null)
            {
                s_instance = this;
                DontDestroyOnLoad(this);
                gameObject.SetActive(false);
            }
            else
            {
                Destroy(this.gameObject);
            }

        }
        gameObject.SetActive(true);
        DontDestroyOnLoad(this.gameObject);

    }

   
    void Update()
    {
        if (ReadyToLoad == true && !myClip.isPlaying)
        {
            if (boutonMenu)
                SceneManager.LoadScene(0);

            if (boutonPlay)
            {
                option.SetActive(false);
                menu.SetActive(true);

                boutonPlay = false;
            }
        }
    }
    public void BoutonMenu()
    {
        myClip.Play(0);
        ReadyToLoad = true;
        boutonMenu = true;
    }
    public void BoutonPlay()
    {
        myClip.Play(0);
        ReadyToLoad = true;
        boutonPlay = true;
    }

    public void SetVolume(float Volume)
    {
        audioMixer.SetFloat("Volume", Volume);
    }
}
