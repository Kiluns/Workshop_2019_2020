using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmoireCle : MonoBehaviour
{
    public Animator AnimPorte;

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
        if(other.gameObject.CompareTag("Player"))
        {
            peutOuvrir = false;
        }
    }

    //Appelée dans l'update, permet l'interaction, conditions vérifiée seulement dans le trigger.
    //L'obtention de la clée est dans le script PorteArmoireCle et est un AnimEvent.
    private void Interaction()
    {
        if(peutOuvrir == true && cleeRecuperer == false && Input.GetKeyDown("e"))
        {
            AnimPorte.SetTrigger("Interagis");
            cleeRecuperer = true;
        }
    }
}
