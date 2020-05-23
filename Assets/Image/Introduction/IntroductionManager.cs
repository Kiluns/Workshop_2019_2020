using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroductionManager : MonoBehaviour
{
    private float timer;

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
    private bool ND14;
    private bool ND15;
    private bool ND16;
    private bool ND17;
    private bool ND18;
    private bool ND19;
    private bool ND20;

    void Start()
    {
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
        ND14 = true;
        ND15 = true;
        ND16 = true;
        ND17 = true;
        ND18 = true;
        ND19 = true;
        ND20 = true;

        timer = Time.timeSinceLevelLoad;
    }

    void Update()
    {
        if (ND1 && Time.timeSinceLevelLoad >= timer +2.5f)
        {
            ND1 = false;
            transform.GetChild(11).gameObject.SetActive(true);
        }

        if (ND2 && Time.timeSinceLevelLoad >= timer + 4f)
        {
            ND2 = false;
            transform.GetChild(6).gameObject.SetActive(true);
        }

        if (ND3 && Time.timeSinceLevelLoad >= timer + 13f)
        {
            ND3 = false;
            transform.GetChild(11).gameObject.SetActive(true);
            transform.GetChild(11).gameObject.GetComponent<BlackScreenManager>().timer = Time.timeSinceLevelLoad;
        }

        if (ND4 && Time.timeSinceLevelLoad >= timer + 14.5f)
        {
            ND4 = false;
            transform.GetChild(2).gameObject.SetActive(true);
        }

        if (ND5 && Time.timeSinceLevelLoad >= timer + 17f)
        {
            ND5 = false;
            transform.GetChild(11).gameObject.SetActive(true);
            transform.GetChild(11).gameObject.GetComponent<BlackScreenManager>().timer = Time.timeSinceLevelLoad;
        }

        if (ND6 && Time.timeSinceLevelLoad >= timer + 18.5f)
        {
            ND6 = false;
            transform.GetChild(7).gameObject.SetActive(true);
        }

        if (ND7 && Time.timeSinceLevelLoad >= timer + 27.5f)
        {
            ND7 = false;
            transform.GetChild(11).gameObject.SetActive(true);
            transform.GetChild(11).gameObject.GetComponent<BlackScreenManager>().timer = Time.timeSinceLevelLoad;
        }

        if (ND8 && Time.timeSinceLevelLoad >= timer + 29f)
        {
            ND8 = false;
            transform.GetChild(3).gameObject.SetActive(true);
        }

        if (ND9 && Time.timeSinceLevelLoad >= timer + 31.5f)
        {
            ND9 = false;
            transform.GetChild(11).gameObject.SetActive(true);
            transform.GetChild(11).gameObject.GetComponent<BlackScreenManager>().timer = Time.timeSinceLevelLoad;
        }

        if (ND10 && Time.timeSinceLevelLoad >= timer + 33f)
        {
            ND10 = false;
            transform.GetChild(8).gameObject.SetActive(true);
        }

        if (ND11 && Time.timeSinceLevelLoad >= timer + 42f)
        {
            ND11 = false;
            transform.GetChild(11).gameObject.SetActive(true);
            transform.GetChild(11).gameObject.GetComponent<BlackScreenManager>().timer = Time.timeSinceLevelLoad;
        }

        if (ND12 && Time.timeSinceLevelLoad >= timer + 43.5f)
        {
            ND12 = false;
            transform.GetChild(4).gameObject.SetActive(true);
        }

        if (ND13 && Time.timeSinceLevelLoad >= timer + 46f)
        {
            ND13 = false;
            transform.GetChild(11).gameObject.SetActive(true);
            transform.GetChild(11).gameObject.GetComponent<BlackScreenManager>().timer = Time.timeSinceLevelLoad;
        }

        if (ND14 && Time.timeSinceLevelLoad >= timer + 47.5f)
        {
            ND14 = false;
            transform.GetChild(9).gameObject.SetActive(true);
        }

        if (ND15 && Time.timeSinceLevelLoad >= timer + 56.5f)
        {
            ND15 = false;
            transform.GetChild(11).gameObject.SetActive(true);
            transform.GetChild(11).gameObject.GetComponent<BlackScreenManager>().timer = Time.timeSinceLevelLoad;
        }

        if (ND16 && Time.timeSinceLevelLoad >= timer + 48f)
        {
            ND16 = false;
            transform.GetChild(5).gameObject.SetActive(true);
        }

        if (ND17 && Time.timeSinceLevelLoad >= timer + 60.5f)
        {
            ND17 = false;
            transform.GetChild(11).gameObject.SetActive(true);
            transform.GetChild(11).gameObject.GetComponent<BlackScreenManager>().timer = Time.timeSinceLevelLoad;
        }

        if (ND18 && Time.timeSinceLevelLoad >= timer + 62f)
        {
            ND18 = false;
            transform.GetChild(10).gameObject.SetActive(true);
        }
    }
}
