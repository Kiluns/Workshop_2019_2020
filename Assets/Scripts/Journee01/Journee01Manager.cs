using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Journee01Manager : MonoBehaviour
{
    public bool possedeCle = false;
    public bool placementArmoiresdecide = false;

    public GameObject cleUI;
    public GameObject porteFinPremierCouloir;
    public GameObject porteFermeeCle;

    // Update is called once per frame
    void Update()
    {
        //Si clé en possession : apparition de l'image dans l'UI, ouverture de la porte de sortie de l'énigme (à faire).
        if (possedeCle == true)
        {
            cleUI.SetActive(true);
            porteFermeeCle.GetComponent<Porte>().fermeeACle = false;
        }

        //retire la clé de l'UI.
        if(porteFermeeCle.GetComponent<Porte>().cleUtilisee == true)
        {
            cleUI.SetActive(false);
        }
    }
}
