using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjecteurInteractionManequin : MonoBehaviour
{
    public GameObject manequin;
    public GameObject mur;

    private Animator projecteurAnim;
    private Animator manequinAnim;
    private AudioSource projectionSound;

    private bool dansTrigger = false;
    private bool projecteurCasse = false;
    private bool murActive = false;

    private void Start()
    {
        projecteurAnim = gameObject.GetComponent<Animator>();
        manequinAnim = manequin.GetComponent<Animator>();
        projectionSound = gameObject.GetComponent<AudioSource>();
        EtatDuMur();
    }

    private void Update()
    {
        Interaction();
        ActivationMur();
    }

    private void Interaction()
    {
        if (Input.GetKeyDown("e") && dansTrigger == true && projecteurCasse == false)
        {
            manequinAnim.SetTrigger("deplacement");
        }
        else if (Input.GetKeyDown("e") && dansTrigger == true && projecteurCasse == true)
        {
            projecteurAnim.SetTrigger("DesactivationCasse");
        }
    }

    //doActivationMur est passé true en Animevent du manequin.
    public void ActivationMur()
    {
        if(manequin.GetComponent<ManequinLieProjecteur>().doActivationMur == true && murActive == false)
        {
            murActive = true;
            mur.SetActive(true);
            projecteurAnim.SetTrigger("Activation");
            projectionSound.Play(0);
            projecteurCasse = true;
        }
    }

    private void EtatDuMur()
    {
        mur.SetActive(false);
        projecteurAnim.SetTrigger("Desactivation");
    }

    private void OnTriggerEnter(Collider other)
    {
        dansTrigger = true;
        transform.GetChild(1).gameObject.transform.GetComponentInChildren<BlinkFeedback>().isActive = true;
    }

    private void OnTriggerExit(Collider other)
    {
        dansTrigger = false;
        transform.GetChild(1).gameObject.transform.GetComponentInChildren<BlinkFeedback>().isActive = false;
    }
}
