using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CastingManager : MonoBehaviour
{
    private GameObject real;
    public bool isSigne;
    private float timerr;
    public float timer;

    private bool ND1;
    private bool ND2;
    private bool ND3;
    private bool ND4;
    private bool ND5;
    private bool ND6;
    private bool ND7;
    private bool ND8;
    private bool ND9;
    private bool ND10;
    private bool ND11;
    private bool ND12;
    private bool ND13;


    void Start()
    {
        real = GameObject.FindGameObjectWithTag("Realisateur");
        isSigne = false;
        timerr = Time.timeSinceLevelLoad;
        ND1 = true;
        ND2 = true;
        ND3 = true;
        ND4 = true;
        ND5 = true;
        ND6 = true;
        ND7 = true;
        ND8 = true;
        ND9 = true;
        ND10 = true;
        ND11 = true;
        ND12 = true;
        ND13 = true;
    }

    

    public void Update()
    {
        if (ND1 && Time.timeSinceLevelLoad >= timerr + 6f)
        {
            ND1 = false;
            transform.GetChild(1).GetComponent<CastingUIAssistant>().ND1 = true;
            real.transform.GetChild(0).gameObject.SetActive(true);
        }

        if (ND2 && Time.timeSinceLevelLoad >= timerr + 10f)
        {
            ND2 = false;
            transform.GetChild(1).GetComponent<CastingUIAssistant>().ND2 = true;
            real.transform.GetChild(0).gameObject.SetActive(false);
            real.transform.GetChild(1).gameObject.SetActive(true);
            real.transform.GetChild(7).gameObject.SetActive(false);
            real.transform.GetChild(8).gameObject.SetActive(true);
        }

        if (ND3 && Time.timeSinceLevelLoad >= timerr + 16f)
        {
            ND3 = false;
            transform.GetChild(1).GetComponent<CastingUIAssistant>().ND3 = true;
            real.transform.GetChild(1).gameObject.SetActive(false);
            real.transform.GetChild(2).gameObject.SetActive(true);
        }

        if (ND4 && Time.timeSinceLevelLoad >= timerr + 19f)
        {
            ND4 = false;
            transform.GetChild(1).GetComponent<CastingUIAssistant>().ND4 = true;
            real.transform.GetChild(2).gameObject.SetActive(false);
            real.transform.GetChild(3).gameObject.SetActive(true);
            real.transform.GetChild(7).gameObject.SetActive(true);
            real.transform.GetChild(8).gameObject.SetActive(false);
        }

        if (ND9 && Time.timeSinceLevelLoad >= timerr + 24f)
        {
            ND9 = false;
            real.transform.GetChild(7).transform.GetChild(0).gameObject.SetActive(true);
        }

        if(ND7 && Time.timeSinceLevelLoad >= timerr + 32f)
        {
            ND7 = false;
            transform.GetChild(2).gameObject.SetActive(true);
        }
        

        if (isSigne)
        {
            if (ND8)
            {
                timer = Time.timeSinceLevelLoad;
                ND8 = false;
            }

            if (ND11 && timer + 0.7f <= Time.timeSinceLevelLoad)
            {
                ND11 = false;
                real.transform.GetChild(4).gameObject.SetActive(true);
            }

            if (ND10 && timer + 1f <= Time.timeSinceLevelLoad)
            {
                ND10 = false;
                transform.GetChild(1).GetComponent<CastingUIAssistant>().ND5 = true;
                real.transform.GetChild(9).gameObject.SetActive(true);
                real.transform.GetChild(7).gameObject.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
                GameObject.FindGameObjectWithTag("Player").transform.GetChild(0).GetComponent<CastingPlayerLook>().isEnable = true;
                transform.GetChild(2).gameObject.SetActive(false);
            }

            if (ND6 && Time.timeSinceLevelLoad >= timer + 3f)
            {
                ND6 = false;
                transform.GetChild(1).GetComponent<CastingUIAssistant>().ND6 = true;
                real.transform.GetChild(5).gameObject.SetActive(true);
                real.transform.GetChild(8).gameObject.SetActive(true);
                real.transform.GetChild(9).gameObject.SetActive(false);
            }

            if (ND5 && Time.timeSinceLevelLoad >= timer + 5f)
            {
                ND5 = false;
                transform.GetChild(0).GetComponent<FonduNoirManager>().ND2 = true;
                transform.GetChild(1).GetComponent<CastingUIAssistant>().ND7 = true;
                real.transform.GetChild(6).gameObject.SetActive(true);
            }
        }


    }
}
