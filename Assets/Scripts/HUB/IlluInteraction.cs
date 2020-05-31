using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class IlluInteraction : MonoBehaviour
{
    // myIllu représente le numéro de l'illu à afficher : 
    //       1 - Frigo
    //       2 - Téléphone
    //       3 - Télé
    //       4 - Canapé
    //       5 - Cadres
    //       6 - Miroir
    //       7 - Fenêtre
    //       8 - Ecran Noir

    [HideInInspector]
    public int myIllu = 0;
    [HideInInspector]
    public GameObject Player;
    [HideInInspector]
    public bool isInteracting;

    private float myTime = 0f;
    private bool neverDone;
    private bool nneverDone;
    private bool nnneverDone;


    void Start()
    {
        isInteracting = false;
        neverDone = true;
        nneverDone = true;
        nnneverDone = true;
        transform.GetChild(8).gameObject.SetActive(true);
        transform.GetChild(8).GetComponent<Image>().canvasRenderer.SetAlpha(-1f);
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if (isInteracting)
        {
            if (neverDone)
            {
                GameObject.FindGameObjectWithTag("Realisateur").GetComponent<HubTextAssistant>().ND1 = true;
                BlackCrossFadeIN();
                myTime = Time.time + 1f;
                neverDone = false;
            }

            if (Time.time >= myTime)
            {
                if (!nneverDone && Time.time >= myTime && nnneverDone)
                {
                    BlackCrossFadeIN();
                    myTime = Time.time + 1f;
                    nnneverDone = false;
                }

                if (nneverDone)
                {
                    transform.GetChild(0).gameObject.SetActive(true);
                    transform.GetChild(myIllu).gameObject.SetActive(true);
                    BlackCrossFadeOUT();
                    myTime = Time.time + 4f;
                    nneverDone = false;
                }

                if (Time.time >= myTime && !nnneverDone)
                {
                    transform.GetChild(myIllu).gameObject.SetActive(false);
                    transform.GetChild(0).gameObject.SetActive(false);
                    BlackCrossFadeOUT();
                    isInteracting = false;
                    neverDone = true;
                    nneverDone = true;
                    nnneverDone = true;
                    Player.GetComponent<HUBPlayer>().isWalkEnable = true;
                }
            }
        }
    }

    private void BlackCrossFadeIN()
    {
        transform.GetChild(8).GetComponent<Image>().CrossFadeAlpha(1, 1.0f, false);
    }

    private void BlackCrossFadeOUT()
    {
        transform.GetChild(8).GetComponent<Image>().CrossFadeAlpha(-1, 1.0f, false);
    }
}
