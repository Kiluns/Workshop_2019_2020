using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjoInteraction : MonoBehaviour
{
    public bool isActive;
    private bool isEnableInteraction;
    void Start()
    {
        isActive = true;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isEnableInteraction = true;

            if(Input.GetKeyDown(KeyCode.Space) && isActive)
            {
                isActive = false;
                transform.GetChild(0).gameObject.GetComponent<Light>().enabled = false;
                //Placer ici l'appel à l'animation de sortie du mur vert
            }
            else if (Input.GetKeyDown(KeyCode.Space) && !isActive)
            {
                isActive = true;
                transform.GetChild(0).gameObject.GetComponent<Light>().enabled = true;
                //Placer ici l'appel à l'animation de'apparition du mur vert
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isEnableInteraction = false;
        }
    }

    void Update()
    {
        if (isEnableInteraction)
        {
            //Placer ici la fonction qui affiche le feedback comme quoi on peut intéragir avec le projecteur.
        }
    }
}
