using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjecteurSansInteractions : MonoBehaviour
{
    private Animator projecteurAnim;
    private AudioSource projectionSound;

    // Start is called before the first frame update
    void Start()
    {
        projecteurAnim = gameObject.GetComponent<Animator>();
        projectionSound = gameObject.GetComponent<AudioSource>();
        projecteurAnim.SetTrigger("Activation");
    }
}
