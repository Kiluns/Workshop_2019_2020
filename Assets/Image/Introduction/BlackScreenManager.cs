using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackScreenManager : MonoBehaviour
{
    Animator animator;
    private bool ND1;
    private bool ND2;
    private bool ND3;
    private bool ND4;

    public float timer;
    private float blackDuration = 1.5f;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Start()
    {
        ND1 = true;
        ND2 = true;
        ND3 = true;
        ND4 = true;
        timer = Time.timeSinceLevelLoad;
        animator.SetTrigger("FadeOut");
        
    }
    
    void Update()
    {
        
        if (ND1)
        {
            ND1 = false;
            animator.SetTrigger("FadeIn");
            timer += blackDuration;
        }

        if (Time.timeSinceLevelLoad >= timer && ND2)
        {
            ND2 = false;
            animator.SetTrigger("FadeOut");
        }

        if (Time.timeSinceLevelLoad >= timer + 1.5f && ND3)
        {
            ND1 = true;
            ND2 = true;
            ND3 = true;
            gameObject.SetActive(false);
        }
    }
}
