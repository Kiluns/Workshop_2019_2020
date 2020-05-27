using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tableau_Real : MonoBehaviour
{
    public AudioSource foudreSX;

    public GameObject tableux;
    void OnTriggerEnter(Collider player)
    {
        tableux.SetActive(true);
        foudreSX.Play(0);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
