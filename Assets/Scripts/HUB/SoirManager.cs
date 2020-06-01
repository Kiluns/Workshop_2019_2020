using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoirManager : MonoBehaviour
{
    [Header("Soir 1")]
    public GameObject Test01;
    [Header("Soir 2")]
    public GameObject Test02;
    [Header("Soir 3")]
    public GameObject Test03;

    private void Update()
    {
        ActivationSoir01();
        ActivationSoir02();
        ActivationSoir03();
    }

    private void ActivationSoir01()
    {
        if(GameObject.FindGameObjectWithTag("SceneLoadingManager").GetComponent<SceneLoading>().activationPremierSoir == true)
        {
            Test01.SetActive(true);
        }
        GameObject.FindGameObjectWithTag("SceneLoadingManager").GetComponent<SceneLoading>().activationPremierSoir = false;
    }

    private void ActivationSoir02()
    {
        if (GameObject.FindGameObjectWithTag("SceneLoadingManager").GetComponent<SceneLoading>().activationSecondSoir == true)
        {
            Test02.SetActive(true);
        }
        GameObject.FindGameObjectWithTag("SceneLoadingManager").GetComponent<SceneLoading>().activationSecondSoir = false;
    }

    private void ActivationSoir03()
    {
        if (GameObject.FindGameObjectWithTag("SceneLoadingManager").GetComponent<SceneLoading>().activationDernierSoir == true)
        {
            Test03.SetActive(true);
        }
        GameObject.FindGameObjectWithTag("SceneLoadingManager").GetComponent<SceneLoading>().activationDernierSoir = false;
    }
}
