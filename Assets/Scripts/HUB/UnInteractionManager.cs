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

    private float timer;

    public int mySoiree = 1;

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
        if(GameObject.FindGameObjectWithTag("SceneLoadingManager") != null)
        {
            if (GameObject.FindGameObjectWithTag("SceneLoadingManager").GetComponent<SceneLoading>().activationPremierSoir == true)
                mySoiree = 0;
            else if (GameObject.FindGameObjectWithTag("SceneLoadingManager").GetComponent<SceneLoading>().activationSecondSoir == true)
                mySoiree = 1;
            else if (GameObject.FindGameObjectWithTag("SceneLoadingManager").GetComponent<SceneLoading>().activationDernierSoir == true)
                mySoiree = 2;
        }
        else
        {
            mySoiree = 0;
        }
            
        ND1 = true;
        ND2 = true;
        ND3 = true;
        ND4 = true;
        ND5 = true;
        ND6 = true;
        ND7 = true;
        ND8 = true;

        Cursor.visible = false;

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
        if(mySoiree == 2)
        {
            if (!isFenetre)
            {
                Fenetre.GetComponent<activateOutline>().targetToOutline.GetComponent<Outline>().enabled = false;
                Fenetre.SetActive(false);
                if (ND4)
                {
                    ND4 = false;
                    GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<BlinkFeedback>().isActive = false;
                    timer = Time.timeSinceLevelLoad;
                }

                if(Time.timeSinceLevelLoad >= timer + 5f)
                {
                    GameObject.FindGameObjectWithTag("SceneLoadingManager").GetComponent<SceneLoading>().goFin = true;
                }
            }

        }

        if(mySoiree == 1)
        {
            if (!isCanape && !isFrigo)
                isFinish = true;

            if (!isCanape)
            {
                if (ND6)
                {
                    ND6 = false;
                    timer = Time.timeSinceLevelLoad;
                }
                if (Time.timeSinceLevelLoad >= timer + 5f)
                {
                    print("oui");
                    GameObject.FindGameObjectWithTag("SceneLoadingManager").GetComponent<SceneLoading>().goSecondeJournee = true;
                }
            }

            if (!isTV)
            {
                TV.GetComponent<activateOutline>().targetToOutline.GetComponent<Outline>().enabled = false;
                TV.SetActive(false);
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
                Fenetre.SetActive(false);
                if (ND4)
                {
                    ND4 = false;
                    GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<BlinkFeedback>().isActive = false;
                }
            }
        }

        if(mySoiree == 0)
        {
            if (!isCanape && !isFrigo)
                isFinish = true;

            if (!isCanape)
            {
                if (ND6)
                {
                    ND6 = false;
                    timer = Time.timeSinceLevelLoad;
                }
                if (Time.timeSinceLevelLoad >= timer + 5f)
                {
                    print("oui");
                    GameObject.FindGameObjectWithTag("SceneLoadingManager").GetComponent<SceneLoading>().goPremiereJournee = true;
                }
            }

            if (!isTV)
            {
                TV.GetComponent<activateOutline>().targetToOutline.GetComponent<Outline>().enabled = false;
                TV.SetActive(false);
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
                Fenetre.SetActive(false);
                if (ND4)
                {
                    ND4 = false;
                    GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<BlinkFeedback>().isActive = false;
                }
            }
        }
    }
        
}
