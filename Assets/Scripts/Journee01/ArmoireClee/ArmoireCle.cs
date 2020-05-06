﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmoireCle : MonoBehaviour
{
    public Animator animPorte;
    public GameObject level01Manager;
    public GameObject cle;

    private bool peutOuvrir = false;
    private bool cleeRecuperer = false;

    private void Update()
    {
        Interaction();
    }

    //On autorise le joueur à interagir dans le trigger.
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            peutOuvrir = true;
        }
    }

    //On refuse au joueur l'intéraction hors du trigger.
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            peutOuvrir = false;
        }
    }

    //Appelée dans l'update, permet l'interaction, conditions vérifiée seulement dans le trigger.
    private void Interaction()
    {
        if (peutOuvrir == true && cleeRecuperer == false && Input.GetKeyDown("e"))
        {
            animPorte.SetTrigger("Interagis");
            cleeRecuperer = true;
            Destroy(cle);
        }
    }

    //Obtention de la clee, appelée en animEvent.
    public void ObtiensClee()
    {
        level01Manager.GetComponent<Journee01Manager>().possedeCle = true;
    }
}
