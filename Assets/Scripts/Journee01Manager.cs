using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Journee01Manager : MonoBehaviour
{
    public bool possedeCle = false;

    public GameObject cleUI;
    
    // Update is called once per frame
    void Update()
    {
        //Si clé en possession : apparition de l'image dans l'UI, ouverture de la porte de sortie de l'énigme (à faire).
        if (possedeCle == true)
        {
            cleUI.SetActive(true);
        }
        //Si clé retirée : disparition de l'image dans l'UI.
        else
        {
            cleUI.SetActive(false);
        }
    }
}
