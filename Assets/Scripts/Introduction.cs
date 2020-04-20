using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Introduction : MonoBehaviour
{
    [HideInInspector]
    public Image scene1;
    [HideInInspector]
    public Image scene2;
    [HideInInspector]
    public Image scene3;
    [HideInInspector]
    public Image scene4;
    [HideInInspector]
    public Image scene5;
    [HideInInspector]
    public Image scene6;
    [HideInInspector]
    public Image scene7;
    [HideInInspector]
    public Image scene8;
    [HideInInspector]
    public Image scene9;

    int compteur = 1;
    public float tempsDuFondu = 2f;
    float timer=0;
    public float tempsDeImage =10f;

    bool fo1 = false;
    bool fo2 = false;
    bool fo3 = false;
    bool fo4 = false;
    bool fo5 = false;
    bool fo6 = false;
    bool fo7 = false;
    bool fo8 = false;
    

    public void Start()
    {
        timer = tempsDeImage;
        scene1.canvasRenderer.SetAlpha(1f);
        scene2.canvasRenderer.SetAlpha(-1f);
        scene3.canvasRenderer.SetAlpha(-1f);
        scene4.canvasRenderer.SetAlpha(-1f);
        scene5.canvasRenderer.SetAlpha(-1f);
        scene6.canvasRenderer.SetAlpha(-1f);
        scene7.canvasRenderer.SetAlpha(-1f);
        scene8.canvasRenderer.SetAlpha(-1f);
        scene9.canvasRenderer.SetAlpha(-1f);
    }
    public void Update()
    {
        timer -= Time.deltaTime;
        if (fo1)
            fadeout1();
        if (fo2)
            fadeout2();
        if (fo3)
            fadeout3();
        if (fo4)
            fadeout4();
        if (fo5)
            fadeout5();
        if (fo6)
            fadeout6();
        if (fo7)
            fadeout7();
        if (fo8)
            fadeout8();

        if(compteur==1 &&  timer <=0)
        {
            compteur++;
            fo1 = true;
            timer = tempsDeImage;
        }
        if (compteur == 2 && timer <= 0)
        {
            compteur++;
            fo2 = true;
            timer = tempsDeImage;
        }
        if (compteur == 3 && timer <= 0)
        {
            compteur++;
            fo3 = true;
            timer = tempsDeImage;
        }
        if (compteur == 4 && timer <= 0)
        {
            compteur++;
            fo4 = true;
            timer = tempsDeImage;
        }
        if (compteur == 5 && timer <= 0)
        {
            compteur++;
            fo5 = true;
            timer = tempsDeImage;
        }
        if (compteur == 6 && timer <= 0)
        {
            compteur++;
            fo6 = true;
            timer = tempsDeImage;
        }
        if (compteur == 7 && timer <= 0)
        {
            compteur++;
            fo7 = true;
            timer = tempsDeImage;
        }
        if (compteur == 8 && timer <= 0)
        {
            compteur++;
            fo8 = true;
            timer = tempsDeImage;
        }
        
    }
    public void Button()
    {
        switch (compteur)
        {
            case 1 :
                compteur++;
                fo1 = true;
                timer = tempsDeImage;
                break;

            case 2 :
                compteur++;
                fo2 = true;
                timer = tempsDeImage;
                break;
            case 3 :
                compteur++;
                fo3 = true;
                timer = tempsDeImage;
                break;
            case 4:
                compteur++;
                fo4 = true;
                timer = tempsDeImage;
                break;
            case 5:
                compteur++;
                fo5 = true;
                timer = tempsDeImage;
                break;
            case 6:
                compteur++;
                fo6= true;
                timer = tempsDeImage;
                break;
            case 7:
                compteur++;
                fo7 = true;
                timer = tempsDeImage;
                break;
            case 8:
                compteur++;
                fo8 = true;
                timer = tempsDeImage;
                break;
            case 9:
                compteur++;
                Destroy(scene9.gameObject);
                SceneManager.LoadScene(1);
                break;
        }
    }

  void fadeout1()
    {
        scene1.CrossFadeAlpha(-1f, tempsDuFondu, false);
        scene2.CrossFadeAlpha(1f, tempsDuFondu, false);

    }
    void fadeout2()
    {
        scene2.CrossFadeAlpha(-1f, tempsDuFondu, false);
        scene3.CrossFadeAlpha(1f, tempsDuFondu, false);

    }
    void fadeout3()
    {
        scene3.CrossFadeAlpha(-1f, tempsDuFondu, false);
        scene4.CrossFadeAlpha(1f, tempsDuFondu, false);
    }
    void fadeout4()
    {
        scene4.CrossFadeAlpha(-1f, tempsDuFondu, false);
        scene5.CrossFadeAlpha(1f, tempsDuFondu, false);

    }
    void fadeout5()
    {
        scene5.CrossFadeAlpha(-1f, tempsDuFondu, false);
        scene6.CrossFadeAlpha(1f, tempsDuFondu, false);

    }
    void fadeout6()
    {
        scene6.CrossFadeAlpha(-1f, tempsDuFondu, false);
        scene7.CrossFadeAlpha(1f, tempsDuFondu, false);

    }
    void fadeout7()
    {
        scene7.CrossFadeAlpha(-1f, tempsDuFondu, false);
        scene8.CrossFadeAlpha(1f, tempsDuFondu, false);

    }
    void fadeout8()
    {
        scene8.CrossFadeAlpha(-1f, tempsDuFondu, false);
        scene9.CrossFadeAlpha(1f, tempsDuFondu, false);

    }
    
}
