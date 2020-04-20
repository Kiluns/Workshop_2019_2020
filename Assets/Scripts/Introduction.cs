using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Introduction : MonoBehaviour
{
    public GameObject scene1;
    public GameObject scene2;
    public GameObject scene3;
    public GameObject scene4;
    public GameObject scene5;
    public GameObject scene6;
    public GameObject scene7;
    public GameObject scene8;
    public GameObject scene9;
    

    public GameObject bouton1;
    public GameObject bouton2;
    public GameObject bouton3;
    public GameObject bouton4;
    public GameObject bouton5;
    public GameObject bouton6;
    public GameObject bouton7;
    public GameObject bouton8;
    public GameObject bouton9;
    
    public void Scene1()
    {
        
        Destroy(scene1.gameObject);
        Destroy(bouton1.gameObject);
    }
    public void Scene2()
    {
        Destroy(scene2.gameObject);
        Destroy(bouton2.gameObject);
    }
    public void Scene3()
    {
        Destroy(scene3.gameObject);
        Destroy(bouton3.gameObject);
    }
    public void Scene4()
    {
        Destroy(scene4.gameObject);
        Destroy(bouton4.gameObject);
    }
    public void Scene5()
    {
        Destroy(scene5.gameObject);
        Destroy(bouton5.gameObject);
    }
    public void Scene6()
    {
        Destroy(scene6.gameObject);
        Destroy(bouton6.gameObject);
    }
    public void Scene7()
    {
        Destroy(scene7.gameObject);
        Destroy(bouton7.gameObject);
    }
    public void Scene8()
    {
        Destroy(scene8.gameObject);
        Destroy(bouton8.gameObject);
    }
    public void Scene9()
    {
        Debug.Log("destroy");
        Destroy(scene9.gameObject);
        Destroy(bouton9.gameObject);
        SceneManager.LoadScene(1);
    }
    
}
