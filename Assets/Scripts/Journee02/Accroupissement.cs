using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accroupissement : MonoBehaviour
{
    public GameObject playerCamera;
    public GameObject playerController;

    public float valeurCameraYAccroupis = 0.3f;
    public float playercrouchSpeed = 1f;
    private float playerCameraYValue;
    private float controllerRunSpeed;
    private float controllerWalkSpeed;

    private void Start()
    {
        playerCameraYValue = playerCamera.transform.position.y;
        controllerWalkSpeed = playerController.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().m_WalkSpeed;
        controllerRunSpeed = playerController.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().m_RunSpeed;
    }

    private void OnTriggerEnter(Collider other)
    {
        playerCamera.transform.position = new Vector3(playerCamera.transform.position.x, valeurCameraYAccroupis, playerCamera.transform.position.z);
        playerController.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().m_WalkSpeed = playercrouchSpeed;
        playerController.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().m_RunSpeed = playercrouchSpeed;
    }

    private void OnTriggerExit(Collider other)
    {
        playerCamera.transform.position = new Vector3(playerCamera.transform.position.x, playerCameraYValue, playerCamera.transform.position.z);
        playerController.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().m_WalkSpeed = controllerWalkSpeed;
        playerController.GetComponent<UnityStandardAssets.Characters.FirstPerson.FirstPersonController>().m_RunSpeed = controllerRunSpeed;
    }
}
