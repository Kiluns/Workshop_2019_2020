using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IlluInteraction : MonoBehaviour
{
    // myIllu représente le numéro de l'illu à afficher : 
    //       0 - Frigo
    //       1 - Téléphone
    //       2 - Télé
    //       3 - Canapé
    //       4 - Cadres
    //       5 - Miroir
    //       6 - Fenêtre
    //       7 - Ecran Noir

    [HideInInspector]
    public int myIllu = 0;

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
        transform.GetChild(7).gameObject.SetActive(true);
        transform.GetChild(7).GetComponent<Image>().canvasRenderer.SetAlpha(-1f);
    }

    void Update()
    {
        if (isInteracting)
        {
            if(neverDone)
            {
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
                    transform.GetChild(myIllu).gameObject.SetActive(true);
                    BlackCrossFadeOUT();
                    myTime = Time.time + 4f;
                    nneverDone = false;
                }

                if (Time.time >= myTime && !nnneverDone)
                {
                    transform.GetChild(myIllu).gameObject.SetActive(false);
                    BlackCrossFadeOUT();
                    isInteracting = false;
                    neverDone = true;
                    nneverDone = true;
                    nnneverDone = true;
                }
            }
        }
    }

    private void BlackCrossFadeIN()
    {
        transform.GetChild(7).GetComponent<Image>().CrossFadeAlpha(1, 1.0f, false);
    }

    private void BlackCrossFadeOUT()
    {
        transform.GetChild(7).GetComponent<Image>().CrossFadeAlpha(-1, 1.0f, false);
    }
}
