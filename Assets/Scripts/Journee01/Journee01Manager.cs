using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Colorful;
using UnityStandardAssets;

public class Journee01Manager : MonoBehaviour
{
    public bool possedeCle = false;
    public bool placementArmoiresdecide = false;
    public bool startMannequin = false;
    public bool cameraModifiee = false;
    public float vitessePoursuite = 1f;
    private float controllerRunSpeed;
    private float controllerWalkSpeed;

    public GameObject cleUI;
    public GameObject porteFinPremierCouloir;
    public GameObject porteFermeeCle;
    public GameObject playerCamera;
    public GameObject playerController;
    public GameObject porteFin;
    public GameObject mannequin;

    private void Start()
    {
        controllerWalkSpeed = playerController.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().m_WalkSpeed;
        controllerRunSpeed = playerController.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().m_RunSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        //Si clé en possession : apparition de l'image dans l'UI, ouverture de la porte de sortie de l'énigme (à faire).
        if (possedeCle == true)
        {
            cleUI.SetActive(true);
            porteFermeeCle.GetComponent<Porte>().fermeeACle = false;
        }

        //retire la clé de l'UI.
        if(porteFermeeCle.GetComponent<Porte>().cleUtilisee == true)
        {
            cleUI.SetActive(false);
        }

        //Change la caméra et la vitesse du joueur
        if(startMannequin == true && cameraModifiee == false)
        {
            playerCamera.GetComponent<Wiggle>().enabled = true;
            playerCamera.GetComponent<DoubleVision>().enabled = true;
            playerCamera.GetComponent<BilateralGaussianBlur>().enabled = true;
            playerCamera.GetComponent<PhotoFilter>().enabled = true;
            playerCamera.GetComponent<DirectionalBlur>().enabled = true;
            playerController.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().m_WalkSpeed = vitessePoursuite;
            playerController.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().m_RunSpeed = vitessePoursuite;
            cameraModifiee = true;
        }

        //Retourne la caméra à son êtat original et la vitesse du joueur
        if(porteFin.GetComponent<Porte>().aEssayerOuvrir == true)
        {
            mannequin.GetComponent<Mannequin>().porteNonOuverte = false;
            playerCamera.GetComponent<Wiggle>().enabled = false;
            playerCamera.GetComponent<DoubleVision>().enabled = false;
            playerCamera.GetComponent<BilateralGaussianBlur>().enabled = false;
            playerCamera.GetComponent<PhotoFilter>().enabled = false;
            playerCamera.GetComponent<DirectionalBlur>().enabled = false;
            playerController.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().m_WalkSpeed = controllerWalkSpeed;
            playerController.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().m_RunSpeed = controllerRunSpeed;
            porteFin.GetComponent<Porte>().fermeeACle = false;
        }

        if(mannequin.GetComponent<Mannequin>().joueurAttrape == true)
        {
            porteFin.GetComponent<Porte>().aEssayerOuvrir = true;
        }

        if(porteFin.GetComponent<Porte>().cleUtilisee == true)
        {
            FinLevel();
        }
    }

    //Est lancé par animevent dans le canvas.
    public void FinLevel()
    {
        SceneManager.LoadScene(3);
    }

    private void OnTriggerEnter(Collider other)
    {
        startMannequin = true;
    }
}
