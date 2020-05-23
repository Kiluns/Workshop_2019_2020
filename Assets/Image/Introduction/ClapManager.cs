using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClapManager : MonoBehaviour
{
    Animator animator;
    private bool ND1;
    private bool ND2;

    private float time = 0f;
    private float time1 = 0f;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Start()
    {
        ND1 = true;
        ND2 = true;
        time = Time.timeSinceLevelLoad;
        time += 1.5f;
    }

    void Update()
    {
        if(Time.timeSinceLevelLoad >= time && ND1)
        {
            ND1 = false;
            animator.SetTrigger("Clap");
            time += 2f;
        }

        if (Time.timeSinceLevelLoad >= time)
        {
            gameObject.SetActive(false);
        }
    }
}
