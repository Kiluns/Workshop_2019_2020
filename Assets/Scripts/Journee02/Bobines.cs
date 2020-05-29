using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bobines : MonoBehaviour
{
    bool peutTomber = true;

    public AudioSource chuteSFX;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (peutTomber)
            {

                for (int i = 0; i < 51; i++)
                {
                    Rigidbody rbBobines;
                    rbBobines = transform.GetChild(i).GetComponent<Rigidbody>();
                    rbBobines.AddForce(-100f, 5f, 0f);
                    
                    chuteSFX.Play(0);
                }
                peutTomber = false;
            }
        }
        
    }
 
}
