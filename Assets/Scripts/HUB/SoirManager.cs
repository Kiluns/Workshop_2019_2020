using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoirManager : MonoBehaviour
{
    public GameObject TextAssistant;

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
            TextAssistant.GetComponent<HubTextAssistant>().mySoiree = 0;
        }
        GameObject.FindGameObjectWithTag("SceneLoadingManager").GetComponent<SceneLoading>().activationPremierSoir = false;
    }

    private void ActivationSoir02()
    {
        if (GameObject.FindGameObjectWithTag("SceneLoadingManager").GetComponent<SceneLoading>().activationSecondSoir == true)
        {
            TextAssistant.GetComponent<HubTextAssistant>().mySoiree = 1;
        }
        GameObject.FindGameObjectWithTag("SceneLoadingManager").GetComponent<SceneLoading>().activationSecondSoir = false;
    }

    private void ActivationSoir03()
    {
        if (GameObject.FindGameObjectWithTag("SceneLoadingManager").GetComponent<SceneLoading>().activationDernierSoir == true)
        {
            TextAssistant.GetComponent<HubTextAssistant>().mySoiree = 2;
        }
        GameObject.FindGameObjectWithTag("SceneLoadingManager").GetComponent<SceneLoading>().activationDernierSoir = false;
    }
}
