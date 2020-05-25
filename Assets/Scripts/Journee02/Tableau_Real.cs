using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tableau_Real : MonoBehaviour
{
    public GameObject tableux;
    void OnTriggerEnter(Collider player)
    {
        tableux.SetActive(true);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
