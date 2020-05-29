using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FonduNoirManager : MonoBehaviour
{
    Animator animator;
    private bool ND1;
    private bool ND2;
    private bool ND3;
    private bool ND4;

    private float timer;


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
    }

    void Update()
    {
        if(ND1 && timer + 2f <= Time.timeSinceLevelLoad)
        {
            ND1 = false;
            animator.SetTrigger("FadeOut");
        }
    }
}
