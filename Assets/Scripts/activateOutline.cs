using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateOutline : MonoBehaviour
{
    public GameObject targetToOutline;

    private float smoothOutline = 0f;
    private float smoothDesactiveOutline = 6f;

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
            activeSmoothOutline = true;
            desactiveSmoothOutline = false;
            
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            activeSmoothOutline = false;
            desactiveSmoothOutline = true;
            Debug.Log("oui");
        }
    }
    
    void SmoothOutline()
    {
        smoothOutline = Mathf.Lerp(smoothOutline, 6f, Time.deltaTime);
    }
    
    void Update()
    {

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
