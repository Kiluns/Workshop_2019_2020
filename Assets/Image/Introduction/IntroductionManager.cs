﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

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
    private bool ND21;

    void Start()
    {
        Cursor.visible = false;
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
        ND21 = true;

        timer = Time.timeSinceLevelLoad;
    }

    void Update()
    {
        //Premier fondu au noir
        if (ND20 && Time.timeSinceLevelLoad >= timer + 0.55f)
        {
            ND20 = false;
            transform.GetChild(11).gameObject.SetActive(true);
            transform.GetChild(11).gameObject.GetComponent<BlackScreenManager>().timer = Time.timeSinceLevelLoad;
        }

        //Premier clap
        if (ND19 && Time.timeSinceLevelLoad >= timer + 2f)
        {
            ND19 = false;
            transform.GetChild(1).gameObject.SetActive(true);
        }
        //Fondu au noir
        if (ND1 && Time.timeSinceLevelLoad >= timer +4.5f)
        {
            ND1 = false;
            transform.GetChild(11).gameObject.SetActive(true);
            transform.GetChild(11).gameObject.GetComponent<BlackScreenManager>().timer = Time.timeSinceLevelLoad;
        }
        //Scene 1
        if (ND2 && Time.timeSinceLevelLoad >= timer + 6f)
        {
            ND2 = false;
            transform.GetChild(6).gameObject.SetActive(true);
        }
        //Fondu au noir
        if (ND3 && Time.timeSinceLevelLoad >= timer + 31f)
        {
            ND3 = false;
            transform.GetChild(11).gameObject.SetActive(true);
            transform.GetChild(11).gameObject.GetComponent<BlackScreenManager>().timer = Time.timeSinceLevelLoad;
            transform.GetChild(12).GetComponentInChildren<TextMeshProUGUI>().SetText("");
        }
        //Clap 2
        if (ND4 && Time.timeSinceLevelLoad >= timer + 32.5f)
        {
            ND4 = false;
            transform.GetChild(2).gameObject.SetActive(true);
        }
        //Fondu au noir
        if (ND5 && Time.timeSinceLevelLoad >= timer + 36f)
        {
            ND5 = false;
            transform.GetChild(11).gameObject.SetActive(true);
            transform.GetChild(11).gameObject.GetComponent<BlackScreenManager>().timer = Time.timeSinceLevelLoad;
        }
        //Scene 2
        if (ND6 && Time.timeSinceLevelLoad >= timer + 38.5f)
        {
            ND6 = false;
            transform.GetChild(7).gameObject.SetActive(true);
        }
        //Fondu au noir
        if (ND7 && Time.timeSinceLevelLoad >= timer + 43.5f)
        {
            ND7 = false;
            transform.GetChild(11).gameObject.SetActive(true);
            transform.GetChild(11).gameObject.GetComponent<BlackScreenManager>().timer = Time.timeSinceLevelLoad;
            transform.GetChild(12).GetComponentInChildren<TextMeshProUGUI>().SetText("");
        }
        //Clap 3
        if (ND8 && Time.timeSinceLevelLoad >= timer + 45f)
        {
            ND8 = false;
            transform.GetChild(3).gameObject.SetActive(true);
        }
        //Fondu au noir
        if (ND9 && Time.timeSinceLevelLoad >= timer + 48.5f)
        {
            ND9 = false;
            transform.GetChild(11).gameObject.SetActive(true);
            transform.GetChild(11).gameObject.GetComponent<BlackScreenManager>().timer = Time.timeSinceLevelLoad;
        }
        //Scene 3
        if (ND10 && Time.timeSinceLevelLoad >= timer + 51f)
        {
            ND10 = false;
            transform.GetChild(8).gameObject.SetActive(true);
        }
        //Fondu au noir
        if (ND11 && Time.timeSinceLevelLoad >= timer + 82f)
        {
            ND11 = false;
            transform.GetChild(11).gameObject.SetActive(true);
            transform.GetChild(11).gameObject.GetComponent<BlackScreenManager>().timer = Time.timeSinceLevelLoad;
            transform.GetChild(12).GetComponentInChildren<TextMeshProUGUI>().SetText("");
        }
        //Clap 4
        if (ND12 && Time.timeSinceLevelLoad >= timer + 83.5f)
        {
            ND12 = false;
            transform.GetChild(4).gameObject.SetActive(true);
        }
        //Fondu au noir
        if (ND13 && Time.timeSinceLevelLoad >= timer + 87f)
        {
            ND13 = false;
            transform.GetChild(11).gameObject.SetActive(true);
            transform.GetChild(11).gameObject.GetComponent<BlackScreenManager>().timer = Time.timeSinceLevelLoad;
        }
        //Scene 4
        if (ND14 && Time.timeSinceLevelLoad >= timer + 89.5f)
        {
            ND14 = false;
            transform.GetChild(9).gameObject.SetActive(true);
        }
        //Fondu au noir
        if (ND15 && Time.timeSinceLevelLoad >= timer + 138.5f)
        {
            ND15 = false;
            transform.GetChild(11).gameObject.SetActive(true);
            transform.GetChild(11).gameObject.GetComponent<BlackScreenManager>().timer = Time.timeSinceLevelLoad;
            transform.GetChild(12).GetComponentInChildren<TextMeshProUGUI>().SetText("");
        }
        //Clap 5
        if (ND16 && Time.timeSinceLevelLoad >= timer + 140f)
        {
            ND16 = false;
            transform.GetChild(5).gameObject.SetActive(true);
        }
        //Fondu au noir
        if (ND17 && Time.timeSinceLevelLoad >= timer + 143.5f)
        {
            ND17 = false;
            transform.GetChild(11).gameObject.SetActive(true);
            transform.GetChild(11).gameObject.GetComponent<BlackScreenManager>().timer = Time.timeSinceLevelLoad;
        }
        //Scene 5
        if (ND18 && Time.timeSinceLevelLoad >= timer + 146f)
        {
            ND18 = false;
            transform.GetChild(10).gameObject.SetActive(true);
        }

        if (ND21 && Time.timeSinceLevelLoad >= timer + 199f)
        {
            ND21 = false;
            transform.GetChild(11).gameObject.SetActive(true);
            transform.GetChild(11).gameObject.GetComponent<BlackScreenManager>().timer = Time.timeSinceLevelLoad;
            transform.GetChild(12).GetComponentInChildren<TextMeshProUGUI>().SetText("");
        }

        if(Time.timeSinceLevelLoad >= 209f)
        {
            GameObject.FindGameObjectWithTag("SceneLoadingManager").GetComponent<SceneLoading>().goBureau = true;
        }
    }
}
