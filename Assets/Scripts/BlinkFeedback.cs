using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkFeedback : MonoBehaviour
{
    [HideInInspector]
    public bool isActive;

    private float a;
    private float b = 0f;
    private float c = 1f;
    private bool isOn;

    public float coolDownTimeOn = 5f;
    public float coolDownTimeOff = 1f;
    private float nextIterationTime;

    void Start()
    {
        isActive = false;
        isOn = false;
        gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0f);
    }

    void Update()
    {
        Debug.Log(isActive);
        if (Time.time >= nextIterationTime && isActive)
        {
            if (isOn)
            {
                isOn = false;
                nextIterationTime = Time.time + coolDownTimeOn;
            }
            else if (!isOn)
            {
                isOn = true;
                nextIterationTime = Time.time + coolDownTimeOff;
            }
        }

        if (isOn)
        {
            a = Mathf.Lerp(a, b, 40 * Time.deltaTime);
        }
        else if (!isOn)
        {
            a = Mathf.Lerp(a, c, 1f * Time.deltaTime);
        }

        if (!isActive)
        {
            nextIterationTime = 0f;
            if (!isOn)
                isOn = true;
        }

        gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, a);
    }
}
