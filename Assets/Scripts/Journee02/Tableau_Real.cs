using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tableau_Real : MonoBehaviour
{
    public AudioSource foudreSX;

    public GameObject tableux;

    private bool sonJoue = false;

    void OnTriggerEnter(Collider player)
    {
        tableux.SetActive(true);
        if(sonJoue == false)
        {
            sonJoue = true;
            foudreSX.Play(0);
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
