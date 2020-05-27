using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    private void Start()
    {
        effetMurBloque.transform.localScale = murBloque.transform.localScale;
        respiration = manequinRespire.GetComponent<AudioSource>();
    }

    private void Update()
    {
        BloquageMur();
        JoueRespiration();
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
}
