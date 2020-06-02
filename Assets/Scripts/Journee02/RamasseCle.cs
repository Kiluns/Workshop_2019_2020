using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RamasseCle : MonoBehaviour
{
    public GameObject cleUI;
    public GameObject porteFin;
    public AudioSource cleUISFX;

    private bool dansTrigger = false;

    private void Update()
    {
        Interaction();
    }

    private void Interaction()
    {
        if (Input.GetKeyDown("e") && dansTrigger == true)
        {
            cleUI.SetActive(true);
            cleUISFX.Play(0);
            porteFin.GetComponent<Porte>().fermeeACle = false;
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            Destroy(transform.GetChild(0).gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        transform.GetChild(0).gameObject.transform.GetComponentInChildren<BlinkFeedback>().isActive = true;
        dansTrigger = true;
    }
    private void OnTriggerExit(Collider other)
    {
        transform.GetChild(0).gameObject.transform.GetComponentInChildren<BlinkFeedback>().isActive = false;
        dansTrigger = false;
    }
}
