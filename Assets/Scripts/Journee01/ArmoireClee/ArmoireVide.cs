using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmoireVide : MonoBehaviour
{
    public Animator animPorte;
    public AudioSource ouvertureSFX;

    private bool peutOuvrir = false;
    private bool ouvert;

    private void Update()
    {
        Interaction();
    }

    //On autorise le joueur à interagir dans le trigger.
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            peutOuvrir = true;
            if(ouvert == false)
            {
                transform.GetChild(0).gameObject.GetComponent<BlinkFeedback>().isActive = true;
            }
        }
    }

    //On refuse au joueur l'intéraction hors du trigger.
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            peutOuvrir = false;
            transform.GetChild(0).gameObject.GetComponent<BlinkFeedback>().isActive = false;
        }
    }

    //Appelée dans l'update, permet l'interaction, conditions vérifiée seulement dans le trigger.
    private void Interaction()
    {
        if (peutOuvrir == true && ouvert == false && Input.GetKeyDown("e"))
        {
            animPorte.SetTrigger("Interagis");
            if (!ouvertureSFX.isPlaying)
            {
                ouvertureSFX.Play(0);
            }
            ouvert = true;
            transform.GetChild(0).gameObject.GetComponent<BlinkFeedback>().isActive = false;
        }
    }
}
