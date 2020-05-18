using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bibliotheque : MonoBehaviour
{
    bool peutTomber = true;

    public AudioSource livreSX;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            if(peutTomber)
            {
                for (int i = 0; i < 11; i++)
                {
                    Rigidbody rbLivre;
                    rbLivre = transform.GetChild(i).GetComponent<Rigidbody>();
                    rbLivre.AddForce(-100f, 0f, 0f);
                    livreSX.Play(0);
                }
                peutTomber = false;
            }
        }
    }
}
