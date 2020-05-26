using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class UI_Manager : MonoBehaviour
{
    [SerializeField] private TextWritter textWritter;
    private TextMeshProUGUI messageText;
    private float timerr;

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


    void Awake()
    {
        messageText = transform.GetChild(0).GetComponent<TextMeshProUGUI>();
    }

    void Start()
    {
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
            textWritter.AddWriter(messageText, "« Heu, oui, Nathan Chevallier, c’est ça ! Je tenais à vous remercier pour cette opportunité, c’est un rêve de gosse pour moi alors euh, ehm… »", 0.05f);
        }

        if (ND2 && Time.timeSinceLevelLoad >= timerr + 20.5f)
        {
            ND2 = false;
            textWritter.AddWriter(messageText, "« Euh… Nathan Chevallier, 28 ans »", 0.09f);
        }

        if (ND3 && Time.timeSinceLevelLoad >= timerr + 31f)
        {
            ND3 = false;
            textWritter.AddWriter(messageText, "« E-elle m’a trahie ! Elle a osé me faire, euh, me faire ça, à moi ! Je vais la tuer, je… heu, je vais vraiment la tuer ! »", 0.05f);
        }

        if (ND4 && Time.timeSinceLevelLoad >= timerr + 40f)
        {
            ND4 = false;
            textWritter.AddWriter(messageText, "« Excusez-moi, c’est compliqué pour moi, je pourrai jamais faire une telle chose * rire nerveux * euh, je veux dire, j’ai une petite amie parfaite, donc, euh… »", 0.04f);
        }

        if (ND5 && Time.timeSinceLevelLoad >= timerr + 53.5f)
        {
            ND5 = false;
            textWritter.AddWriter(messageText, "« Vous voyez, on est vraiment fait, comment dire, l’un pour l’autre ? Bon, elle a déménagé récemment, pour son travail… Elle est très dévouée à sa carrière, elle est vraiment formidable * rire nerveux * »", 0.05f);
        }

        if (ND6 && Time.timeSinceLevelLoad >= timerr + 71f)
        {
            ND6 = false;
            textWritter.AddWriter(messageText, "« Ouais, c’est vraiment trop chiant, mes vieux me réclament, euh, har-harcèlent pour de l’argent, c’est vraiment, plutôt heu, je veux dire ( oups pardon, je reprends là ) … C’est pas croyable ! » »", 0.04f);
        }

        if (ND7 && Time.timeSinceLevelLoad >= timerr + 80f)
        {
            ND7 = false;
            textWritter.AddWriter(messageText, "« Ah ah, vraiment désolé, c’est que, c’est plutôt l’inverse de mon côté, mes parents subviennent plus ou moins à mes besoins le temps que, euh, que ma carrière se lance… »", 0.05f);
        }

        if (ND8 && Time.timeSinceLevelLoad >= timerr + 92f)
        {
            ND8 = false;
            textWritter.AddWriter(messageText, "«* soupir * Pas une seule réponse positive jusqu’à maintenant…»", 0.05f);
        }
    }
}