using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bibliotheque : MonoBehaviour
{
    bool peutTomber = true;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            if(peutTomber)
            {
                for (int i = 0; i < 10; i++)
                {
                    Rigidbody rbLivre;
                    rbLivre = transform.GetChild(i).GetComponent<Rigidbody>();
                    rbLivre.AddForce(-100f, 0f, 0f);
                }
                peutTomber = false;
            }
        }
    }
}
