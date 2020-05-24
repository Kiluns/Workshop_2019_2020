using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accroupissement : MonoBehaviour
{
    public GameObject playerCamera;

    public float valeurCameraYAccroupis = 0.3f;
    private float playerCameraYValue;

    private void Start()
    {
        playerCameraYValue = playerCamera.transform.position.y;
    }

    private void OnTriggerEnter(Collider other)
    {
        playerCamera.transform.position = new Vector3(playerCamera.transform.position.x, valeurCameraYAccroupis, playerCamera.transform.position.z);
    }

    private void OnTriggerExit(Collider other)
    {
        playerCamera.transform.position = new Vector3(playerCamera.transform.position.x, playerCameraYValue, playerCamera.transform.position.z);
    }
}
