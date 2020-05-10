using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSurvLookAt : MonoBehaviour
{
    private GameObject myPlayer;
    private Vector3 myOffset;
    void Start()
    {
        myPlayer = GameObject.FindGameObjectWithTag("Player");
        myOffset = new Vector3(0f, 90f, 0f);
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(myPlayer.transform);
        transform.Rotate(myOffset);
    }
}
