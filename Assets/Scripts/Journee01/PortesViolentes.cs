using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortesViolentes : MonoBehaviour
{
    public GameObject porteLiee; //Porte à la fin du couloir.
    public Animator portesViolentesAnim; //Animator de l'objet.
    public AudioSource ouvertureSFX;
    public AudioSource fermetureSFX;

    private bool dansTrigger = false;
    private bool enAnimation = false;
    private bool ouvertureSFXjouee = false;

    private void Update()
    {
        Interaction();
    }

    private void Interaction()
    {
        if(Input.GetKeyDown("e") && dansTrigger == true && enAnimation == false)
        {
            portesViolentesAnim.SetTrigger("FermeeACle");
            enAnimation = true;
        }
        if(porteLiee.GetComponent<Porte>().aEssayerOuvrir == true)
        {
            portesViolentesAnim.SetTrigger("Ouverture");
            if(!ouvertureSFX.isPlaying && ouvertureSFXjouee == false)
            {
                ouvertureSFX.Play(0);
                ouvertureSFXjouee = true;
            }
        }
    }

    //Appelée en AnimEvent.
    public void ResetEnAnimation()
    {
        enAnimation = false;
    }

    //Appelée en AnimEvent
    public void PlayFermetureSFX()
    {
        fermetureSFX.Play(0);
    }

    //Appelée en AnimEvent dans l'ouverture pour ouvrir la porte à la fin du couloir.
    private void OuverturePorte()
    {
        porteLiee.GetComponent<Porte>().fermeeACle = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        dansTrigger = true;
    }

    private void OnTriggerExit(Collider other)
    {
        dansTrigger = false;
    }
}
