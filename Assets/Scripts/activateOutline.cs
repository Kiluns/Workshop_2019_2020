using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateOutline : MonoBehaviour
{
    public GameObject targetToOutline;
    public GameObject ZeroManager;

    private float smoothOutline = 0f;
    private float smoothDesactiveOutline = 6f;

    private bool isTriggered;
    private bool activeSmoothOutline;
    private bool desactiveSmoothOutline;

    void Start()
    {
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

        if(isTriggered && Input.GetKeyDown(KeyCode.Space))
        {
            if (this.name == "TriggerCanape")
                ZeroManager.GetComponent<UnInteractionManager>().isCanape = false;
            if (this.name == "TriggerFrigo")
                ZeroManager.GetComponent<UnInteractionManager>().isFrigo = false;
            if (this.name == "TriggerTele")
                ZeroManager.GetComponent<UnInteractionManager>().isTV = false;
            if (this.name == "TriggerTelephone")
                ZeroManager.GetComponent<UnInteractionManager>().isTelephone = false;
            if (this.name == "TriggerMiroir")
                ZeroManager.GetComponent<UnInteractionManager>().isMiroir = false;
            if (this.name == "TriggerFenetre")
                ZeroManager.GetComponent<UnInteractionManager>().isFenetre = false;
            if (this.name == "TriggerCadres")
                ZeroManager.GetComponent<UnInteractionManager>().isCadres = false;

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
