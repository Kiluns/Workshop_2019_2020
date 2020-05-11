using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortesViolentes : MonoBehaviour
{
    public GameObject porteLiee; //Porte à la fin du couloir.
    public Animator portesViolentesAnim; //Animator de l'objet.

    private bool dansTrigger = false;
    private bool enAnimation = false;

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
        }
    }

    //Appelée en AnimEvent.
    public void ResetEnAnimation()
    {
        enAnimation = false;
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
