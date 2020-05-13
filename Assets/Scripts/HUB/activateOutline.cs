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

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        activeSmoothOutline = false;
        desactiveSmoothOutline = false;
        targetToOutline.GetComponent<Outline>().enabled = false;
    }
    
    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isTriggered = true;
            activeSmoothOutline = true;
            desactiveSmoothOutline = false;
            other.transform.GetChild(1).gameObject.GetComponent<BlinkFeedback>().isActive = true;
            //other.transform.GetChild(1).gameObject.GetComponent<BlinkFeedback>().isJustActivated += 1;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isTriggered = false;
            activeSmoothOutline = false;
            desactiveSmoothOutline = true;
            other.transform.GetChild(1).gameObject.GetComponent<BlinkFeedback>().isActive = false;
            //other.transform.GetChild(1).gameObject.GetComponent<BlinkFeedback>().isJustActivated += 1;
        }
    }
    
    void SmoothOutline()
    {
        smoothOutline = Mathf.Lerp(smoothOutline, 6f, Time.deltaTime);
    }
    
    void Update()
    {

        if(isTriggered && Input.GetKeyDown(KeyCode.E))
        {
            if (this.name == "TriggerCanape")
            {
                Player.GetComponent<HUBPlayer>().isWalkEnable = false;
                ZeroManager.GetComponent<UnInteractionManager>().isCanape = false;
                IllusManager.GetComponent<IlluInteraction>().myIllu = 4;
                IllusManager.GetComponent<IlluInteraction>().isInteracting = true;
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
                ZeroManager.GetComponent<UnInteractionManager>().isTelephone = false;

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
