using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetireScriptEcran : MonoBehaviour
{
    public GameObject script;
    private Animator scriptAnim;

    private void Start()
    {
        scriptAnim = script.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        scriptAnim.SetTrigger("Retire");
    }
}
