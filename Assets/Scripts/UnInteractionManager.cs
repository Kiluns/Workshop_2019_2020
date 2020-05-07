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



    void Start()
    {
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
        /*
        if(isFinish)
            SceneManager.LoadScene(4);
        */
        if (!isTV)
        {
            TV.GetComponent<activateOutline>().targetToOutline.GetComponent<Outline>().enabled = false;
            TV.GetComponent<activateOutline>().enabled = false;
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
        }

        if (!isCadres)
        {
            Cadres.GetComponent<activateOutline>().targetToOutline.GetComponent<Outline>().enabled = false;
            Cadres.GetComponent<activateOutline>().enabled = false;
        }

        if (!isFrigo)
        {
            Frigo.GetComponent<activateOutline>().targetToOutline.GetComponent<Outline>().enabled = false;
            Frigo.GetComponent<activateOutline>().enabled = false;
        }

        if (!isTelephone)
        {
            Telephone.GetComponent<activateOutline>().targetToOutline.GetComponent<Outline>().enabled = false;
            Telephone.GetComponent<activateOutline>().enabled = false;
        }

        if (!isFenetre)
        {
            Fenetre.GetComponent<activateOutline>().targetToOutline.GetComponent<Outline>().enabled = false;
            Fenetre.GetComponent<activateOutline>().enabled = false;
        }

    }
}
