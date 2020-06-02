using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastingPlayerLook : MonoBehaviour
{
    [SerializeField] private string mouseXInputName, mouseYInputName;
    [SerializeField] private float mouseSensitivity;

    [SerializeField] private Transform playerBody;

    public float xAxisClamp;
    public float yAxisClamp;

    private Vector3 Reset =  new Vector3(0, 180, 0);
    public bool isEnable;
    private bool ND1;

    private void Awake()
    {
        ND1 = true;
        xAxisClamp = 0.0f;
        yAxisClamp = 0.0f;
    }


    private void LockCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        isEnable = true;
    }

    private void Update()
    {
        if(ND1 && Time.timeSinceLevelLoad >= 1.5f)
        {
            ND1 = false;
            LockCursor();
        }

        if (isEnable)
        {
            CameraRotation();
        }
        else if (!isEnable)
        {
            transform.eulerAngles = Reset;
        }
    }

    private void CameraRotation()
    {
        float mouseX = Input.GetAxis(mouseXInputName) * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis(mouseYInputName) * mouseSensitivity * Time.deltaTime;

        xAxisClamp += mouseY;
        yAxisClamp += mouseX;


        if (xAxisClamp > 90.0f)
        {
            xAxisClamp = 90.0f;
            mouseY = 0.0f;
            ClampXAxisRotationToValue(270.0f);
        }
        else if (xAxisClamp < -90.0f)
        {
            xAxisClamp = -90.0f;
            mouseY = 0.0f;
            ClampXAxisRotationToValue(90.0f);
        }

        if (yAxisClamp > 60.0f)
        {
            yAxisClamp = 60.0f;
            mouseX = 0.0f;
            ClampYAxisRotationToValue(240.0f);
        }
        else if (yAxisClamp < -60.0f)
        {
            yAxisClamp = -60.0f;
            mouseX = 0.0f;
            ClampYAxisRotationToValue(120.0f);
        }

        transform.Rotate(Vector3.left * mouseY);
        playerBody.Rotate(Vector3.up * mouseX);
    }

    private void ClampXAxisRotationToValue(float value)
    {
        Vector3 eulerRotation = transform.eulerAngles;
        eulerRotation.x = value;
        transform.eulerAngles = eulerRotation;
    }

    private void ClampYAxisRotationToValue(float value)
    {
        Vector3 eulerRotation = transform.eulerAngles;
        eulerRotation.y = value;
        transform.eulerAngles = eulerRotation;
    }
}
