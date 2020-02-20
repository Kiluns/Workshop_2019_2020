using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventaire : MonoBehaviour
{
    public bool isLettre = false;
    public bool lettre = false;
    public int isObjet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E) &&  isObjet == 1)
        {
            lettre = true;
        }
    }
}
