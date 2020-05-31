using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoading : MonoBehaviour
{
    public bool goMenu = false;
    public bool goIntro = false;
    public bool goBureau = false;
    public bool goPremierSoir = false;
    public bool goPremiereJournee = false;
    public bool goSecondSoir = false;
    public bool goSecondeJournee = false;
    public bool goDernierSoir = false;
    public bool goFin = false;

    private void Awake()
    {
        GameObject[] SceneLoadingManager = GameObject.FindGameObjectsWithTag("SceneLoadingManager");
        if (SceneLoadingManager.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }

    private void Update()
    {
        ChangementScene();
    }

    private void ChangementScene()
    {
        if(goMenu)
        {
            SceneManager.LoadScene(0);
            goMenu = false;
        }
        if(goIntro)
        {
            SceneManager.LoadScene(1);
            goIntro = false;
        }
        if(goBureau)
        {
            SceneManager.LoadScene(2);
            goBureau = false;
        }
        if(goPremierSoir)
        {
            SceneManager.LoadScene(3);
            goPremierSoir = false;
        }
    }
}
