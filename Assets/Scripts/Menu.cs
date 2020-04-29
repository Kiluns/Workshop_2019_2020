using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public AudioSource myClip;
    public GameObject menu;
    public GameObject option;
    public GameObject controle;
    public GameObject credit;

    bool ReadyToLoad = false;
    bool blmenu = false;
    bool bloption = false;
    bool blcontrole = false;
    bool blcredit = false;
    bool bljouer = false;


    // Update is called once per frame
    void Update()
    {
        if (ReadyToLoad == true && !myClip.isPlaying)
        {
            if (bljouer)
                SceneManager.LoadScene(1);

            if (bloption)
            {
                menu.SetActive(false);
                option.SetActive(true);
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
                blmenu = false;
                
            if (blmenu)
            {
                    menu.SetActive(true);
                    credit.SetActive(false);
                    option.SetActive(false);
                    controle.SetActive(false);
                    blcredit = false;
                }
            }

        }
    }

    public void BoutonJouer()
    {
        myClip.Play(0);
        ReadyToLoad = true;
        bljouer = true;
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
    public void BoutonMenu()
    {
        myClip.Play(0);
        ReadyToLoad = true;
        blmenu = true;
    }
    public void BoutonQuitter()
    {
        Application.Quit();
    }
}
