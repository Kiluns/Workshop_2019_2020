using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetourDebut : MonoBehaviour
{
    public GameObject playerController;
    public GameObject mannequinhead;
    private Transform depart;
    public GameObject departGO;
    public GameObject mannequins;
    public GameObject mannequinNathan;
    public GameObject mannequinNathanAllonge;
    public GameObject levelManager;

    private void Start()
    {
        depart = departGO.GetComponent<Transform>();
    }

    //appelé en animevent
    public void RetourAuDebut()
    {
        mannequinhead.SetActive(false);
        mannequins.SetActive(false);
        mannequinNathan.SetActive(false);
        mannequinNathanAllonge.SetActive(false);
        playerController.transform.position = new Vector3(depart.position.x, depart.position.y, depart.position.z);
        playerController.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().enabled = true;
    }
}
