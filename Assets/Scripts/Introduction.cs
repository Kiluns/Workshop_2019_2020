using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Introduction : MonoBehaviour
{
    public Image scene1;
    public Image scene2;
    public Image scene3;
    public Image scene4;
    public Image scene5;
    public Image scene6;
    public Image scene7;
    public Image scene8;
    public Image scene9;

    public int compteur = 1;

    bool fo1 = false;
    bool fo2 = false;
    bool fo3 = false;
    bool fo4 = false;
    bool fo5 = false;
    bool fo6 = false;
    bool fo7 = false;
    bool fo8 = false;
    bool fo9 = false;

    public void Start()
    {
        scene1.canvasRenderer.SetAlpha(1f);
        scene2.canvasRenderer.SetAlpha(1f);
        scene3.canvasRenderer.SetAlpha(1f);
        scene4.canvasRenderer.SetAlpha(1f);
        scene5.canvasRenderer.SetAlpha(1f);
        scene6.canvasRenderer.SetAlpha(1f);
        scene7.canvasRenderer.SetAlpha(1f);
        scene8.canvasRenderer.SetAlpha(1f);
    }
    public void Update()
    {
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
    }
    public void Button()
    {
        switch (compteur)
        {
            case 1 :
                compteur++;
                fo1 = true;
                break;

            case 2 :
                compteur++;
                fo2 = true;

                break;
            case 3 :
                compteur++;
                fo3 = true;
                break;
            case 4:
                compteur++;
                fo4 = true;
                break;
            case 5:
                compteur++;
                fo5 = true;
                break;
            case 6:
                compteur++;
                fo6= true;
                break;
            case 7:
                compteur++;
                fo7 = true;
                break;
            case 8:
                compteur++;
                fo8 = true;
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
        scene1.CrossFadeAlpha(-1f, 2, false);
        
    }
    void fadeout2()
    {
        scene2.CrossFadeAlpha(-1f, 2, false);

    }
    void fadeout3()
    {
        scene3.CrossFadeAlpha(-1f, 2, false);

    }
    void fadeout4()
    {
        scene4.CrossFadeAlpha(-1f, 2, false);

    }
    void fadeout5()
    {
        scene5.CrossFadeAlpha(-1f, 2, false);

    }
    void fadeout6()
    {
        scene6.CrossFadeAlpha(-1f, 2, false);

    }
    void fadeout7()
    {
        scene7.CrossFadeAlpha(-1f, 2, false);

    }
    void fadeout8()
    {
        scene8.CrossFadeAlpha(-1f, 2, false);

    }
}
