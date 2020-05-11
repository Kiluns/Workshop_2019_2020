using System.Collections;
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
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            peutOuvrir = true;
            transform.GetChild(0).gameObject.GetComponent<BlinkFeedback>().isActive = true;
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
        if (peutOuvrir == true && cleeRecuperer == false && Input.GetKeyDown("e"))
        {
            animPorte.SetTrigger("Interagis");
            cleeRecuperer = true;
            transform.GetChild(0).gameObject.GetComponent<BlinkFeedback>().isActive = false;
        }
    }

    //Obtention de la clee, appelée en animEvent.
    public void ObtiensClee()
    {
        level01Manager.GetComponent<Journee01Manager>().possedeCle = true;
        Destroy(cle);
    }
}
