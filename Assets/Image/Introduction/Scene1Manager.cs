using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene1Manager : MonoBehaviour
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
        if (gameObject.name == "Scene1")
            time += 25f;
        else if (gameObject.name == "Scene2")
            time += 5f;
        else if (gameObject.name == "Scene3")
            time += 31f;
        else if (gameObject.name == "Scene4")
            time += 49f;
        else if (gameObject.name == "Scene5")
            time += 53f;
    }

    void Update()
    {
        if (Time.timeSinceLevelLoad >= time && ND1)
        {
            ND1 = false;
        }

        if (Time.timeSinceLevelLoad >= time)
        {
            gameObject.SetActive(false);
        }
    }
}
