using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacementArmoire : MonoBehaviour
{
    public GameObject armoireAActiver;
    public GameObject armoireADesactiver;
    public GameObject levelManager;

    private void OnTriggerEnter(Collider other)
    {
        if(levelManager.GetComponent<Journee01Manager>().placementArmoiresdecide == false)
        {
            armoireADesactiver.SetActive(false);
            armoireAActiver.SetActive(true);
            levelManager.GetComponent<Journee01Manager>().placementArmoiresdecide = true;
        }
    }
}
