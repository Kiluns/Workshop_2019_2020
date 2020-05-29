using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class IntroductionDeuxiemePartie : MonoBehaviour
{
    private GameObject player;
    private float speed = 30f;

    bool up = false;
    bool down = false;
    

    void Awake()
    {
        Cursor.lockState = CursorLockMode.None;
        GameObject.FindGameObjectWithTag("Player").transform.GetChild(0).GetComponent<CastingPlayerLook>().isEnable = false;
    }

    public void Signature()
    {
        transform.GetChild(0).GetComponent<Animator>().SetTrigger("Signature");
        GetComponentInParent<CastingManager>().isSigne = true;
    }

    void LateUpdate()
    {
        if (transform.position.y >= -300f && Input.mouseScrollDelta.y > 0)
        {
            transform.position -= transform.up * speed;
            Debug.Log("oui");
        }
        if (transform.position.y <= 1450f && Input.mouseScrollDelta.y < 0)
        {
            transform.position += transform.up * speed;
        }
    }

    void Update()
    {
        Debug.Log(transform.position.y);
    }

}