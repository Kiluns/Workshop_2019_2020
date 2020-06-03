using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateOutline : MonoBehaviour
{
    public GameObject targetToOutline;
    public GameObject ZeroManager;
    public GameObject IllusManager;
    public GameObject Player;

    private float smoothOutline = 0f;
    private float smoothDesactiveOutline = 6f;

    private bool isTriggered;
    private bool activeSmoothOutline;
    private bool desactiveSmoothOutline;

    private bool ND1;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        activeSmoothOutline = false;
        desactiveSmoothOutline = false;
        targetToOutline.GetComponent<Outline>().enabled = false;
        ND1 = true;
    }
    
    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (this.name == "TriggerCanape")
            {
                if(ZeroManager.GetComponent<UnInteractionManager>().mySoiree == 0)
                    GameObject.FindGameObjectWithTag("Realisateur").GetComponent<HubTextAssistant>().ND2 = true;
            }
            if (this.name == "TriggerMiroir")
            {
                if (ZeroManager.GetComponent<UnInteractionManager>().mySoiree == 0)
                    GameObject.FindGameObjectWithTag("Realisateur").GetComponent<HubTextAssistant>().ND3 = true;
                if (ZeroManager.GetComponent<UnInteractionManager>().mySoiree == 1)
                    GameObject.FindGameObjectWithTag("Realisateur").GetComponent<HubTextAssistant>().ND14 = true;
            }
            if (this.name == "TriggerFrigo")
            {
                if (ZeroManager.GetComponent<UnInteractionManager>().mySoiree == 0)
                    GameObject.FindGameObjectWithTag("Realisateur").GetComponent<HubTextAssistant>().ND4 = true;
            }
            if (this.name == "TriggerTele")
            {
                if (ZeroManager.GetComponent<UnInteractionManager>().mySoiree == 0)
                    GameObject.FindGameObjectWithTag("Realisateur").GetComponent<HubTextAssistant>().ND5 = true;
            }
            if (this.name == "TriggerCadres")
            {
                if (ZeroManager.GetComponent<UnInteractionManager>().mySoiree == 0)
                    GameObject.FindGameObjectWithTag("Realisateur").GetComponent<HubTextAssistant>().ND11 = true;
            }
            if (this.name == "TriggerFenetre")
            {
                if (ZeroManager.GetComponent<UnInteractionManager>().mySoiree == 0)
                    GameObject.FindGameObjectWithTag("Realisateur").GetComponent<HubTextAssistant>().ND12 = true;
                if (ZeroManager.GetComponent<UnInteractionManager>().mySoiree == 1)
                    GameObject.FindGameObjectWithTag("Realisateur").GetComponent<HubTextAssistant>().ND15 = true;
            }


            isTriggered = true;
            activeSmoothOutline = true;
            desactiveSmoothOutline = false;
            other.transform.GetChild(1).gameObject.GetComponent<BlinkFeedback>().isActive = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        GameObject.FindGameObjectWithTag("Realisateur").GetComponent<HubTextAssistant>().ND1 = true;

        if (other.CompareTag("Player"))
        {
            isTriggered = false;
            activeSmoothOutline = false;
            desactiveSmoothOutline = true;
            other.transform.GetChild(1).gameObject.GetComponent<BlinkFeedback>().isActive = false;
        }
    }
    
    void Update()
    {
        if (ND1 && ZeroManager.GetComponent<UnInteractionManager>().mySoiree == 2)
        {
            ND1 = false;
            if (this.name == "TriggerCanape")
                gameObject.SetActive(false);
            if (this.name == "TriggerMiroir")
                gameObject.SetActive(false);
            if (this.name == "TriggerFrigo")
                gameObject.SetActive(false);
            if (this.name == "TriggerTele")
                gameObject.SetActive(false);
            if (this.name == "TriggerCadres")
                gameObject.SetActive(false);
            Player.GetComponent<HUBPlayer>().transform.GetChild(1).GetComponent<BlinkFeedback>().isActive = false;
        }

        if (isTriggered && Input.GetKeyDown(KeyCode.E))
        {
            if (ZeroManager.GetComponent<UnInteractionManager>().mySoiree == 2)
            {
                if (this.name == "TriggerFenetre")
                {
                    ZeroManager.GetComponent<UnInteractionManager>().isFenetre = false;
                    IllusManager.GetComponent<IlluInteraction>().myIllu = 7;
                    IllusManager.GetComponent<IlluInteraction>().troisiemeSoir = true;
                    IllusManager.GetComponent<IlluInteraction>().isInteracting = true;
                }

                if (this.name == "TriggerTelephone")
                {
                    GameObject.FindGameObjectWithTag("Realisateur").GetComponent<HubTextAssistant>().ND22 = true;
                }
            }

            if (ZeroManager.GetComponent<UnInteractionManager>().mySoiree == 1)
            {
                if (this.name == "TriggerCanape")
                {
                    if (ZeroManager.GetComponent<UnInteractionManager>().isTelephone == true)
                    {
                        GameObject.FindGameObjectWithTag("Realisateur").GetComponent<HubTextAssistant>().ND16 = true;
                    }
                    else
                    {
                        Player.GetComponent<HUBPlayer>().isWalkEnable = false;
                        ZeroManager.GetComponent<UnInteractionManager>().isCanape = false;
                        IllusManager.GetComponent<IlluInteraction>().myIllu = 4;
                        IllusManager.GetComponent<IlluInteraction>().isInteracting = true;
                    }

                }

                if (this.name == "TriggerFrigo")
                {
                    Player.GetComponent<HUBPlayer>().isWalkEnable = false;
                    ZeroManager.GetComponent<UnInteractionManager>().isFrigo = false;
                    IllusManager.GetComponent<IlluInteraction>().myIllu = 1;
                    IllusManager.GetComponent<IlluInteraction>().isInteracting = true;
                }

                if (this.name == "TriggerTele")
                    ZeroManager.GetComponent<UnInteractionManager>().isTV = false;

                if (this.name == "TriggerTelephone")
                {
                    ZeroManager.GetComponent<UnInteractionManager>().isTelephone = false;
                    GameObject.FindGameObjectWithTag("Realisateur").GetComponent<HubTextAssistant>().ND17 = true;
                }

                if (this.name == "TriggerMiroir")
                {
                    Player.GetComponent<HUBPlayer>().isWalkEnable = false;
                    ZeroManager.GetComponent<UnInteractionManager>().isMiroir = false;
                    IllusManager.GetComponent<IlluInteraction>().myIllu = 6;
                    IllusManager.GetComponent<IlluInteraction>().isInteracting = true;
                }

                if (this.name == "TriggerFenetre")
                {
                    Player.GetComponent<HUBPlayer>().isWalkEnable = false;
                    ZeroManager.GetComponent<UnInteractionManager>().isFenetre = false;
                    IllusManager.GetComponent<IlluInteraction>().myIllu = 7;
                    IllusManager.GetComponent<IlluInteraction>().deuxiemeSoir = true;
                    IllusManager.GetComponent<IlluInteraction>().isInteracting = true;
                }

                if (this.name == "TriggerCadres")
                {
                    Player.GetComponent<HUBPlayer>().isWalkEnable = false;
                    ZeroManager.GetComponent<UnInteractionManager>().isCadres = false;
                    IllusManager.GetComponent<IlluInteraction>().myIllu = 5;
                    IllusManager.GetComponent<IlluInteraction>().isInteracting = true;
                }
            }

            if (ZeroManager.GetComponent<UnInteractionManager>().mySoiree == 0)
            {
                if (this.name == "TriggerCanape")
                {
                    if (ZeroManager.GetComponent<UnInteractionManager>().isTelephone == true)
                    {
                        GameObject.FindGameObjectWithTag("Realisateur").GetComponent<HubTextAssistant>().ND7 = true;
                    }
                    else
                    {
                        Player.GetComponent<HUBPlayer>().isWalkEnable = false;
                        ZeroManager.GetComponent<UnInteractionManager>().isCanape = false;
                        IllusManager.GetComponent<IlluInteraction>().myIllu = 4;
                        IllusManager.GetComponent<IlluInteraction>().isInteracting = true;
                    }
                }

                if (this.name == "TriggerFrigo")
                {
                    Player.GetComponent<HUBPlayer>().isWalkEnable = false;
                    ZeroManager.GetComponent<UnInteractionManager>().isFrigo = false;
                    IllusManager.GetComponent<IlluInteraction>().myIllu = 1;
                    IllusManager.GetComponent<IlluInteraction>().isInteracting = true;
                }

                if (this.name == "TriggerTele")
                    ZeroManager.GetComponent<UnInteractionManager>().isTV = false;

                if (this.name == "TriggerTelephone")
                {
                    ZeroManager.GetComponent<UnInteractionManager>().isTelephone = false;
                    GameObject.FindGameObjectWithTag("Realisateur").GetComponent<HubTextAssistant>().ND8 = true;
                }

                if (this.name == "TriggerMiroir")
                {
                    Player.GetComponent<HUBPlayer>().isWalkEnable = false;
                    ZeroManager.GetComponent<UnInteractionManager>().isMiroir = false;
                    IllusManager.GetComponent<IlluInteraction>().myIllu = 6;
                    IllusManager.GetComponent<IlluInteraction>().isInteracting = true;
                }

                if (this.name == "TriggerFenetre")
                {
                    Player.GetComponent<HUBPlayer>().isWalkEnable = false;
                    ZeroManager.GetComponent<UnInteractionManager>().isFenetre = false;
                    IllusManager.GetComponent<IlluInteraction>().myIllu = 7;
                    IllusManager.GetComponent<IlluInteraction>().isInteracting = true;
                }

                if (this.name == "TriggerCadres")
                {
                    Player.GetComponent<HUBPlayer>().isWalkEnable = false;
                    ZeroManager.GetComponent<UnInteractionManager>().isCadres = false;
                    IllusManager.GetComponent<IlluInteraction>().myIllu = 5;
                    IllusManager.GetComponent<IlluInteraction>().isInteracting = true;
                }
            }
            

        }

        if (activeSmoothOutline)
        {
            desactiveSmoothOutline = false;
            targetToOutline.GetComponent<Outline>().enabled = true;
            targetToOutline.GetComponent<Outline>().OutlineWidth = smoothOutline;
            smoothOutline = Mathf.Lerp(smoothOutline, 8f, Time.deltaTime * 8f);
            smoothDesactiveOutline = 8f;
        }

        if (desactiveSmoothOutline)
        {
            activeSmoothOutline = false;
            targetToOutline.GetComponent<Outline>().OutlineWidth = smoothDesactiveOutline;
            smoothDesactiveOutline = Mathf.Lerp(smoothDesactiveOutline, 0f, Time.deltaTime * 8f);
            smoothOutline = 0f;
            //targetToOutline.GetComponent<Outline>().enabled = false;
        }


    }
    
}
