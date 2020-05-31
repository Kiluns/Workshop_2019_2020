using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class HubTextAssistant : MonoBehaviour
{
    [SerializeField] private HubTextWritter hubTextWritter;
    private TextMeshProUGUI messageText;
    private float timerr;

    public int mySoiree = 0;

    public bool ND1;
    public bool ND2;
    public bool ND3;
    public bool ND4;
    public bool ND5;
    public bool ND6;
    public bool ND7;
    public bool ND8;
    public bool ND9;
    public bool ND10;
    public bool ND11;
    public bool ND12;
    public bool ND13;
    public bool ND14;
    public bool ND15;
    public bool ND16;
    public bool ND17;
    public bool ND18;
    public bool ND19;
    public bool ND20;



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
        ND11 = false;
        ND12 = false;
        ND13 = false;
        ND14 = false;
        ND15 = false;
        ND16 = false;
        ND17 = false;
        ND18 = false;
        ND19 = false;
        ND20 = false;
    }

    public void Update()
    {
        if(mySoiree == 0)
        {
            if (ND1)
            {
                ND1 = false;
                hubTextWritter.AddWriter(messageText, "", 0.03f);
                transform.GetComponentInChildren<TextMeshProUGUI>().text = "";
            }

            if (ND2)
            {
                ND2 = false;
                hubTextWritter.AddWriter(messageText, "« Il n'est peut être pas très beau mais je dors bien dessus. »", 0.03f);
            }

            if (ND3)
            {
                ND3 = false;
                hubTextWritter.AddWriter(messageText, "« Je me demande ce qu’il a vu en moi de parfait pour le rôle. »", 0.05f);
            }

            if (ND4)
            {
                ND4 = false;
                hubTextWritter.AddWriter(messageText, "« Ca fait combien de temps que je n'ai pas mangé quelque chose de plus cher qu’une conserve ? »", 0.04f);
            }

            if (ND5)
            {
                ND5 = false;
                hubTextWritter.AddWriter(messageText, "« Elle fonctionne mal, mais je n’ai pas les moyens de m'offrir un réparateur pour le moment. Mais bon j’ai certaines chaînes qui marchent bien alors je ne me plains pas. »", 0.05f);
            }

            if (ND6)
            {
                ND6 = false;
                hubTextWritter.AddWriter(messageText, "« Le soleil est magnifique je sens que demain va être une superbe journée au travail. »", 0.04f);
            }

            if (ND7)
            {
                ND7 = false;
                hubTextWritter.AddWriter(messageText, "« Je devrais d’abord annoncer la nouvelle au téléphone »", 0.05f);
            }

            if (ND8)
            {
                ND8 = false;
                hubTextWritter.AddWriter(messageText, "« Allô maman ? J’ai une super nouvelle ! Aujourd’hui j’ai vu un réalisateur et demain je fais ma première journée avec lui, il est un peu étrange tu dois surement le connaître.. Et toi où es-tu cette fois ? J’espère que tu profites bien et ...  * Voulez vous envoyer le message ? * »", 0.05f);
                ND9 = true;
                timerr = Time.timeSinceLevelLoad;
                GameObject.FindGameObjectWithTag("Player").GetComponent<HUBPlayer>().isWalkEnable = false;
            }

            if (ND9 && Time.timeSinceLevelLoad >= timerr + 17f)
            {
                ND9 = false;
                hubTextWritter.AddWriter(messageText, "« Allô Karen ? C’est Nathan, j’ai une grande nouvelle ! Demain je commence un tournage dont j’ai le rôle principal ! Alors rappelle moi j’ai hâte d’avoir de tes nouvelles, savoir si tout se passe bien dans ta nouvelle vie... * Voulez vous envoyer le message ? *»", 0.05f);
                timerr = Time.timeSinceLevelLoad;
                ND10 = true;
            }

            if (ND10 && Time.timeSinceLevelLoad >= timerr + 17f)
            {
                ND10 = false;
                GameObject.FindGameObjectWithTag("Player").GetComponent<HUBPlayer>().isWalkEnable = true;
                ND1 = true;
            }

            if (ND11)
            {
                ND11 = false;
                hubTextWritter.AddWriter(messageText, "« C’est ma mère elle est actuellement en vacances. Elle le mérite bien, elle travail beaucoup. C’est si gentil de sa part de me prêter un peu d’argent chaque mois. »", 0.05f);
            }

            if (ND12)
            {
                ND12 = false;
                hubTextWritter.AddWriter(messageText, "« Le ciel est magnifique je sens que demain va être une superbe journée au travail »", 0.05f);
            }
        }
        
    }
}
