using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Colorful;

public class Journee02Manager : MonoBehaviour
{
    public GameObject projecteurBloquant;
    public GameObject murBloque;
    public GameObject effetMurBloque;
    public GameObject mannequinDisparaitApresBloquage;
    private bool effetAJoue = true;

    public GameObject projecteurManequinRespire;
    public GameObject manequinRespire;
    private AudioSource respiration;
    private bool sonJoue = false;

    public GameObject porteFin;
    public GameObject cle;
    public GameObject mannequinNathanFin;
    public GameObject lightAEteindre;
    public GameObject lightAEteindreDeux;
    public GameObject cleUI;
    public GameObject playerController;
    public GameObject playerCamera;
    public AudioSource poursuiteOST;

    public float vitessePoursuite = 1f;

    private void Start()
    {
        respiration = manequinRespire.GetComponent<AudioSource>();
        poursuiteOST = gameObject.GetComponent<AudioSource>();
    }

    private void Update()
    {
        BloquageMur();
        JoueRespiration();
        EventFinLevel();
    }

    private void BloquageMur()
    {
        if(projecteurBloquant.GetComponent<Projecteurs>().murActive == true && effetAJoue == false)
        {
            effetAJoue = true;
            murBloque.SetActive(false);
            Destroy(Instantiate(effetMurBloque, new Vector3(murBloque.transform.position.x, murBloque.transform.position.y, murBloque.transform.position.z), new Quaternion(murBloque.transform.rotation.x, murBloque.transform.rotation.y, murBloque.transform.rotation.z, murBloque.transform.rotation.w)), 3.5f);
            mannequinDisparaitApresBloquage.SetActive(false);
        }
        if (projecteurBloquant.GetComponent<Projecteurs>().murActive == false && effetAJoue == true)
        {
            effetAJoue = false;
            murBloque.SetActive(true);
        }
    }

    private void JoueRespiration()
    {
        if(projecteurManequinRespire.GetComponent<Projecteurs>().murActive == true && sonJoue == false)
        {
            sonJoue = true;
            respiration.Play(0);
        }
        if(projecteurManequinRespire.GetComponent<Projecteurs>().murActive == false && sonJoue == true)
        {
            sonJoue = false;
            respiration.Stop();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        respiration.Stop();
        lightAEteindre.SetActive(false);
        lightAEteindreDeux.SetActive(false);
}

    private void EventFinLevel()
    {
        if(porteFin.GetComponent<Porte>().aEssayerOuvrir == true)
        {
            cle.SetActive(true);
            mannequinNathanFin.SetActive(true);
            lightAEteindre.SetActive(true);
            lightAEteindreDeux.SetActive(true);
            ChangementCameraEtVitesse();
            if(!poursuiteOST.isPlaying)
            {
                poursuiteOST.Play(0);
            }
        }
        if (porteFin.GetComponent<Porte>().cleUtilisee == true)
        {
            cleUI.SetActive(false);
            FinLevel();
        }
    }

    private void ChangementCameraEtVitesse()
    {
        playerCamera.GetComponent<Wiggle>().enabled = true;
        playerCamera.GetComponent<DoubleVision>().enabled = true;
        playerCamera.GetComponent<BilateralGaussianBlur>().enabled = true;
        playerCamera.GetComponent<PhotoFilter>().enabled = true;
        playerCamera.GetComponent<DirectionalBlur>().enabled = true;
        playerController.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().m_WalkSpeed = vitessePoursuite;
        playerController.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().m_RunSpeed = vitessePoursuite;
    }

    private void FinLevel()
    {
        GameObject.FindGameObjectWithTag("SceneLoadingManager").GetComponent<SceneLoading>().goDernierSoir = true;
    }
}
