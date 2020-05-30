using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastingManager : MonoBehaviour
{
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

    void Start()
    {
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
    }

    

    public void Update()
    {
        if (ND1 && Time.timeSinceLevelLoad >= timerr + 6f)
        {
            ND1 = false;
            transform.GetChild(1).GetComponent<CastingUIAssistant>().ND1 = true;
        }

        if (ND2 && Time.timeSinceLevelLoad >= timerr + 10f)
        {
            ND2 = false;
            transform.GetChild(1).GetComponent<CastingUIAssistant>().ND2 = true;
        }

        if (ND3 && Time.timeSinceLevelLoad >= timerr + 18f)
        {
            ND3 = false;
            transform.GetChild(1).GetComponent<CastingUIAssistant>().ND3 = true;
        }

        if (ND4 && Time.timeSinceLevelLoad >= timerr + 22f)
        {
            ND4 = false;
            transform.GetChild(1).GetComponent<CastingUIAssistant>().ND4 = true;
        }

        if(ND7 && Time.timeSinceLevelLoad >= timerr + 60f)
        {
            ND7 = false;
            transform.GetChild(2).gameObject.SetActive(true);
        }

        if (ND5 && Time.timeSinceLevelLoad >= timerr + 60f)
        {
            ND5 = false;
            transform.GetChild(1).GetComponent<CastingUIAssistant>().ND5 = true;
        }

        if (ND6 && Time.timeSinceLevelLoad >= timerr + 120f)
        {
            ND6 = false;
            transform.GetChild(1).GetComponent<CastingUIAssistant>().ND6 = true;
        }

        if (isSigne)
        {
            if (ND8)
            {
                timer = Time.timeSinceLevelLoad;
                timer += 2f;
                ND8 = false;
            }

            if (timer <= Time.time)
            {
                isSigne = false;
                Cursor.lockState = CursorLockMode.Locked;
                GameObject.FindGameObjectWithTag("Player").transform.GetChild(0).GetComponent<CastingPlayerLook>().isEnable = true;
                transform.GetChild(2).gameObject.SetActive(false);
            }
        }
    }
}
