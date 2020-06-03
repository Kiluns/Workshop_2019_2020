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
    private bool ND11;
    private bool ND12;
    private bool ND13;

    public GameObject va01;
    public GameObject va02;
    public GameObject va03;
    public GameObject va04;
    public GameObject va05;
    public GameObject va06;


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
        ND11 = true;
        ND12 = true;
        ND13 = true;
    }

    public void Update()
    {
        if (ND1 && Time.timeSinceLevelLoad >= timerr + 6f)
        {
            ND1 = false;
            va01.SetActive(true);
            textWritter.AddWriter(messageText, "« Heu, oui, Nathan Chevallier, c’est ça ! Je tenais à vous remercier pour cette opportunité, c’est un rêve de gosse pour moi alors euh, ehm… »", 0.07f);
        }

        if (ND9 && Time.timeSinceLevelLoad >= timerr + 17.8f)
        {
            ND9 = false;
            textWritter.AddWriter(messageText, "« Voilà... je ne sais pas trop ce que vous voulez que je fasse ? Euh, je peux, euh, à peu près tout faire, enfin je pense, ehm... euh, on, on commence ? »", 0.06f);
        }

        if (ND2 && Time.timeSinceLevelLoad >= timerr + 35.5f) //Scene 2
        {
            ND2 = false;
            va02.SetActive(true);
            textWritter.AddWriter(messageText, "« Euh… Nathan Chevallier, 28 ans »", 0.1f);
        }

        if (ND3 && Time.timeSinceLevelLoad >= timerr + 49f) //Scene 3
        {
            ND3 = false;
            va03.SetActive(true);
            textWritter.AddWriter(messageText, "« E-elle m’a trahie ! Elle a osé me faire, euh, me faire ça, à moi ! Je vais la tuer, je… heu, je vais vraiment la tuer ! »", 0.06f);
        }

        if (ND4 && Time.timeSinceLevelLoad >= timerr + 58f)
        {
            ND4 = false;
            textWritter.AddWriter(messageText, "« Excusez-moi, c’est compliqué pour moi, je ne pourrais jamais faire une telle chose * rire nerveux * euh, je veux dire, j’ai une petite amie parfaite, donc, euh… C'est pas possible pour moi, c'est pas imaginable ! »", 0.055f);
        }

        if (ND10 && Time.timeSinceLevelLoad >= timerr + 71f)
        {
            ND10 = false;
            textWritter.AddWriter(messageText, "« Je euh, je suis trop doux ! Enfin pas forcément doux mais... Enfin vous voyez ce que je veux dire... C'est c'est compliqué... »", 0.055f);
        }

        if (ND5 && Time.timeSinceLevelLoad >= timerr + 84.5f) //Scene 4
        {
            ND5 = false;
            va04.SetActive(true);
            textWritter.AddWriter(messageText, "« Vous voyez, on est vraiment fait, comment dire, l’un pour l’autre ? Bon, elle a déménagé récemment, pour son travail… Elle est très dévouée à sa carrière, elle est vraiment formidable je sais pas trop comment... »", 0.077f);
        }

        if (ND11 && Time.timeSinceLevelLoad >= timerr + 102f) 
        {
            ND11 = false;
            textWritter.AddWriter(messageText, "« Comment la décrire, c'est une personnalité euh... Pleine de vie ! C'est c'est c'est, elle est vivante, elle est joyeuse, elle est époustouflante, elle est créative, elle a tout pour plaire, elle a... d'ailleurs je comprend même pas comment elle a pu me choisir moi... »", 0.06f);
        }

        if (ND12 && Time.timeSinceLevelLoad >= timerr + 119f) 
        {
            ND12 = false;
            textWritter.AddWriter(messageText, "« En réalité enfin, quand on me voit... Je réussis pas grand choses, j'ai beaucoup * rire nerveux* beaucoup joué aux dés mais ça ne suffit pas, elle est capable de tout, de tout faire, elle est... Elle est... Elle est merveilleuse... »", 0.055f);
        }

        if (ND6 && Time.timeSinceLevelLoad >= timerr + 139f) //Scene 5
        {
            ND6 = false;
            va05.SetActive(true);
            textWritter.AddWriter(messageText, "« Ouais, vraiment c'est trop chiant, mes vieux me réclament, euh, har-harcèlent pour de l’argent, c’est vraiment, plutôt heu, je veux dire ( oups pardon, je reprends là ) … C’est pas croyable ! »", 0.065f);
        }

        if (ND7 && Time.timeSinceLevelLoad >= timerr + 152.7f)
        {
            ND7 = false;
            textWritter.AddWriter(messageText, "« Je... * silence * J'ai oublié * rire nerveux *, vraiment désolé, c’est que, c’est plutôt l’inverse de mon côté, mes parents subviennent plus ou moins à mes besoins le temps que, euh, que ma carrière se lance… »", 0.065f);
        }

        if (ND13 && Time.timeSinceLevelLoad >= timerr + 167.5f)
        {
            ND13 = false;
            textWritter.AddWriter(messageText, "« C'est pas facile, je... Il faut qu'on me laisse une chance, euh... Je suis sûr que... J'ai peut-être pas un bon niveau mais pour l'instant je demande qu'à m'améliorer ? Je, je ne demande qu'à apprendre euh ça ça ça va venir ! Et euh... On reprend ? »", 0.07f);
        }

        if (ND8 && Time.timeSinceLevelLoad >= timerr + 195f)
        {
            ND8 = false;
            va06.SetActive(true);
            textWritter.AddWriter(messageText, "«* soupir * Pas une seule réponse positive jusqu’à maintenant…»", 0.05f);
        }
    
    }
}