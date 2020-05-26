using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public AudioSource myClip;
    public GameObject menu;
    public GameObject option;
    public GameObject controle;
    public GameObject credit;
    public GameObject LoadScene;
    public Slider silder;

    public Text textProgress;

    bool ReadyToLoad = false;
    bool blmenu = false;
    bool bloption = false;
    bool blcontrole = false;
    bool blcredit = false;
    bool bljouer = false;

    
    void Awake()
    {
        option = GameObject.FindWithTag("Option");
        option.SetActive(false);
        myClip = GameObject.FindWithTag("MainCamera").GetComponent<AudioSource>();
    }
    void Update()
    {
        if (ReadyToLoad == true && !myClip.isPlaying)
        {
            if (bloption)
            {
                option.SetActive(true); 
                menu.SetActive(false);                
                bloption = false;
            }

            if (blcontrole)
            {
                menu.SetActive(false);
                credit.SetActive(true);
                blcontrole = false;
            }

            if (blcredit)
            {
                menu.SetActive(false);
                controle.SetActive(true);
                blcredit = false;
            }             
            

        }
    }

    public void BoutonJouer()
    {
        myClip.Play(0);
        /*
        ReadyToLoad = true;
        bljouer = true;*/
        LoadScene.SetActive(true);
        StartCoroutine(LoadAsync());
    }
    public void BoutonOption()
    {
        myClip.Play(0);
        ReadyToLoad = true;
        bloption = true;
    }
    public void BoutonControl()
    {
        myClip.Play(0);
        ReadyToLoad = true;
        blcontrole = true;
    }
    public void BoutonCredit()
    {
        myClip.Play(0);
        ReadyToLoad = true;
        blcredit = true;
    }
    
    public void BoutonQuitter()
    {
        Application.Quit();
    }

    IEnumerator LoadAsync()
    {
        Debug.Log(bljouer+"1");
        AsyncOperation operation = SceneManager.LoadSceneAsync(0);
        
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);

            silder.value = progress;

            textProgress.text = progress * 100 + "%";
            yield return null;
        }
    }
}
