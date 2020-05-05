using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmoireCle : MonoBehaviour
{
    public GameObject Level01Manager;
    public Animator AnimPorte;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("detected");
            
        }
    }
}
