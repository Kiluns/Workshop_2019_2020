using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RamasseCle : MonoBehaviour
{
    public GameObject cleUI;
    public GameObject porteFin;
    public AudioSource cleUISFX;

    private void OnTriggerEnter(Collider other)
    {
        cleUI.SetActive(true);
        cleUISFX.Play(0);
        porteFin.GetComponent<Porte>().fermeeACle = false;
        Destroy(gameObject);
    }
}
