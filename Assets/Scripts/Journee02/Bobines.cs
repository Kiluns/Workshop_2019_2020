using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bobines : MonoBehaviour
{
    bool peutTomber = true;

    //public AudioSource chuteSX;

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
                    rbBobines.AddForce(0f, -5f, -100f);
                    
                    //chuteSX.Play(0);
                }
                peutTomber = false;
            }
        }
        
    }
 
}
