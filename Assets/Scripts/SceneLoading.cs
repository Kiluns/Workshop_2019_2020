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

    [HideInInspector]
    public bool activationPremierSoir = false;
    [HideInInspector]
    public bool activationSecondSoir = false;
    [HideInInspector]
    public bool activationDernierSoir = false;

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
            //Activer ce qui doit l'être le premier soir, ici on met juste un bool en true, c'est un object différent ayant celui là comme variable (on trouve celui là avec le tag) dans la bonne scene qui fera les activations
            activationPremierSoir = true;
            goPremierSoir = false;
        }
        if(goPremiereJournee)
        {
            SceneManager.LoadScene(4);
            goPremiereJournee = false;
        }
        if(goSecondSoir)
        {
            SceneManager.LoadScene(5);
            //Activer ce qui doit l'être le second soir, même logique
            activationSecondSoir = true;
            goSecondSoir = false;
        }
        if(goSecondeJournee)
        {
            SceneManager.LoadScene(6);
            goSecondeJournee = false;
        }
        if(goDernierSoir)
        {
            SceneManager.LoadScene(7);
            //Activer ce qui doit l'être le troisième soir, même logique
            activationDernierSoir = true;
            goDernierSoir = false;
        }
        if(goFin)
        {
            SceneManager.LoadScene(8);
            goFin = false;
        }
    }
}
