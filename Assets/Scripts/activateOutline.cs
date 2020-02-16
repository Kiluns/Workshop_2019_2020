using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateOutline : MonoBehaviour
{
public GameObject targetToOutline;
    
    void OnTriggerEnter(Collider Player)
    {
        if (Player.attachedRigidbody)
        {
            Debug.Log("outline activé");
            targetToOutline.GetComponent<Outline>().enabled = true;
        }
    }

    void OnTriggerExit(Collider Player)
    {
        if (Player.attachedRigidbody)
        {
            Debug.Log("outline désactivé");
            targetToOutline.GetComponent<Outline>().enabled = false;
        }
    }
}
