using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porte : MonoBehaviour
{
    public Animator porteAnim;

    public bool fermeeACle = false; //est référencé dans managerJournee01.
    public bool cleUtilisee = false; //est référencé dans managerJournee01.
    public bool aEssayerOuvrir = false; //est référencé quand on a besoin de déclencher quelque chose après avoir essayer d'ouvrir une porte
    private bool dansTrigger = false;
    private bool enAnimation = false;

    private void Update()
    {
        Interaction();
    }

    private void Interaction()
    {
        if(Input.GetKeyDown("e") && fermeeACle == false && dansTrigger == true && enAnimation == false)
        {
            porteAnim.SetTrigger("Ouverture");
            enAnimation = true;
            cleUtilisee = true;
        }
        else if(Input.GetKeyDown("e") && fermeeACle == true && dansTrigger == true && enAnimation == false)
        {
            porteAnim.SetTrigger("Fermee");
            aEssayerOuvrir = true;
            enAnimation = true;
        }
    }

    //Appelée en AnimEvent.
    public void ResetEnAnimation()
    {
        enAnimation = false;
    }

    //On autorise le joueur à interagir dans le trigger.
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            dansTrigger = true;
        }
    }

    //On refuse au joueur l'intéraction hors du trigger.
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            dansTrigger = false;
        }
    }
}
