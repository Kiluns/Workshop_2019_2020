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
                    rbBobines.AddForce(0f, -500f, -800f);
                    Debug.Log("bouge");
                    //chuteSX.Play(0);
                }
                peutTomber = false;
            }
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
