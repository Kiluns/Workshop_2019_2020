using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Miroir : MonoBehaviour
{
    private Animator miroirAnim;
    private AudioSource miroirSFX;

    private void Start()
    {
        miroirAnim = gameObject.GetComponent<Animator>();
        miroirSFX = gameObject.GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        miroirAnim.SetTrigger("Chute");
        miroirSFX.Play(0);
    }
}
