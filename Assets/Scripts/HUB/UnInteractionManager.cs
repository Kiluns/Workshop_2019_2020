using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UnInteractionManager : MonoBehaviour
{
    public GameObject TV;
    public GameObject Canape;
    public GameObject Miroir;
    public GameObject Cadres;
    public GameObject Frigo;
    public GameObject Telephone;
    public GameObject Fenetre;

    [HideInInspector]
    public bool isFinish;
    [HideInInspector]
    public bool isTV;
    [HideInInspector]
    public bool isCanape;
    [HideInInspector]
    public bool isMiroir;
    [HideInInspector]
    public bool isCadres;
    [HideInInspector]
    public bool isFrigo;
    [HideInInspector]
    public bool isTelephone;
    [HideInInspector]
    public bool isFenetre;

    private bool ND1;
    private bool ND2;
    private bool ND3;
    private bool ND4;
    private bool ND5;
    private bool ND6;
    private bool ND7;
    private bool ND8;



    void Start()
    {
        ND1 = true;
        ND2 = true;
        ND3 = true;
        ND4 = true;
        ND5 = true;
        ND6 = true;
        ND7 = true;
        ND8 = true;


        isTV = true;
        isCanape = true;
        isMiroir = true;
        isCadres = true;
        isFrigo = true;
        isTelephone = true;
        isFenetre = true;

        isFinish = false;
    }

    void Update()
    {
        if (!isCanape && !isFrigo)
            isFinish = true;

        if (isFinish)
        {
            GameObject.FindGameObjectWithTag("SceneLoadingManager").GetComponent<SceneLoading>().goPremiereJournee = true;
        }
            
        
        if (!isTV)
        {
            TV.GetComponent<activateOutline>().targetToOutline.GetComponent<Outline>().enabled = false;
            TV.GetComponent<activateOutline>().enabled = false;
            if (ND5)
            {
                ND5 = false;
                GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<BlinkFeedback>().isActive = false;
            }
        }

        if (!isCanape)
        {
            Canape.GetComponent<activateOutline>().targetToOutline.GetComponent<Outline>().enabled = false;
            Canape.GetComponent<activateOutline>().enabled = false;
        }

        if (!isMiroir)
        {
            Miroir.GetComponent<activateOutline>().targetToOutline.GetComponent<Outline>().enabled = false;
            Miroir.GetComponent<activateOutline>().enabled = false;
            Miroir.SetActive(false);
            if (ND5)
            {
                ND5 = false;
                GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<BlinkFeedback>().isActive = false;
            }
        }

        if (!isCadres)
        {
            Cadres.GetComponent<activateOutline>().targetToOutline.GetComponent<Outline>().enabled = false;
            Cadres.GetComponent<activateOutline>().enabled = false;
            Cadres.SetActive(false);
            if (ND3)
            {
                ND3 = false;
                GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<BlinkFeedback>().isActive = false;
            }
        }

        if (!isFrigo)
        {
            
            Frigo.GetComponent<activateOutline>().targetToOutline.GetComponent<Outline>().enabled = false;
            Frigo.GetComponent<activateOutline>().enabled = false;
            Frigo.SetActive(false);
            if (ND1)
            {
                ND1 = false;
                GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<BlinkFeedback>().isActive = false;
            }
        }

        if (!isTelephone)
        {
            Telephone.GetComponent<activateOutline>().targetToOutline.GetComponent<Outline>().enabled = false;
            Telephone.GetComponent<activateOutline>().enabled = false;
            Telephone.SetActive(false);
            if (ND2)
            {
                ND2 = false;
                GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<BlinkFeedback>().isActive = false;
            }
        }

        if (!isFenetre)
        {
            Fenetre.GetComponent<activateOutline>().targetToOutline.GetComponent<Outline>().enabled = false;
            Fenetre.GetComponent<activateOutline>().enabled = false;
            Fenetre.SetActive(false);
            if (ND4)
            {
                ND4 = false;
                GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<BlinkFeedback>().isActive = false;
            }
        }
    }
}
