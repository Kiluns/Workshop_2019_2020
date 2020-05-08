using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class WIPNextScene : MonoBehaviour
{
    int mySceneIndex;
    public void NextScene()
    {
        mySceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(mySceneIndex);
    }
}
