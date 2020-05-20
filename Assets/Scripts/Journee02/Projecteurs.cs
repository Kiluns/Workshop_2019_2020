using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projecteurs : MonoBehaviour
{
    public GameObject mur;

    private bool dansTrigger = false;
    public bool murActive = true;

    private void Start()
    {
        EtatDuMur();
    }

    private void Update()
    {
        Interaction();
    }

    private void Interaction()
    {
        if(Input.GetKeyDown("e") && dansTrigger == true && murActive == true)
        {
            mur.SetActive(false);
            murActive = false;
        }
        else if(Input.GetKeyDown("e") && dansTrigger == true && murActive == false)
        {
            mur.SetActive(true);
            murActive = true;
        }
    }

    //On check et applique l'état correcte au mur.
    private void EtatDuMur()
    {
        if(murActive == true)
        {
            mur.SetActive(true);
        }
        else if(murActive == false)
        {
            mur.SetActive(false);
        }
    }

    //On autorise le joueur à interagir dans le trigger.
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            dansTrigger = true;
            transform.GetChild(1).gameObject.transform.GetComponentInChildren<BlinkFeedback>().isActive = true;
        }
    }

    //On refuse au joueur l'intéraction hors du trigger.
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            dansTrigger = false;
            transform.GetChild(1).gameObject.transform.GetComponentInChildren<BlinkFeedback>().isActive = false;
        }
    }
}
