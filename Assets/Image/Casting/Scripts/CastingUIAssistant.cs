using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CastingUIAssistant : MonoBehaviour
{
    [SerializeField] private CastingTextWritter castingTextWritter;

    private TextMeshProUGUI messageText;

    private float timerr;

    public bool ND1;
    public bool ND2;
    public bool ND3;
    public bool ND4;
    public bool ND5;
    public bool ND6;
    public bool ND7;
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
        ND1 = false;
        ND2 = false;
        ND3 = false;
        ND4 = false;
        ND5 = false;
        ND6 = false;
        ND7 = false;
        ND8 = false;
        ND9 = false;
        ND10 = false;
    }

    public void Update()
    {
        if (ND1)
        {
            ND1 = false;
            castingTextWritter.AddWriter(messageText, "- Bonjour Nathan, je vous attendais..", 0.05f);
        }

        if (ND2)
        {
            ND2 = false;
            castingTextWritter.AddWriter(messageText, "- Alors, j'ai bien étudié votre profil et je dois bien reconnaitre que j'ai été très séduit !", 0.05f);
        }

        if (ND3)
        {
            ND3 = false;
            castingTextWritter.AddWriter(messageText, "- Vous êtes toujours partant ?", 0.05f);
        }

        if (ND4)
        {
            ND4 = false;
            castingTextWritter.AddWriter(messageText, "- Je dois bien vous avouer que vous êtes le type de profil idéal pour mon prochain film ! Alors passons les formalités d'un casting et signons immédiatement ce contrat !", 0.05f);
        }

        if (ND5)
        {
            ND5 = false;
            castingTextWritter.AddWriter(messageText, "- Merci !", 0.01f);
        }

        if (ND6)
        {
            ND6 = false;
            castingTextWritter.AddWriter(messageText, "- Ce sera parfait comme ça !", 0.05f);
        }

        if (ND7)
        {
            ND7 = false;
            castingTextWritter.AddWriter(messageText, "- Je vous attend demain à la première heure dans nos studios...", 0.05f);
        }
    }
}
