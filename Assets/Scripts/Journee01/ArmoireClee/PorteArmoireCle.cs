using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PorteArmoireCle : MonoBehaviour
{
    public GameObject Level01Manager;

    //Obtention de la clee, appelée en animEvent.
    public void ObtiensClee()
    {
        Level01Manager.GetComponent<Journee01Manager>().possedeCle = true;
    }
}
