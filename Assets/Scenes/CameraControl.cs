using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{

    public GameObject mainCamera;
    public float rotateSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float ycamRotation = Input.GetAxis("Mouse X") * rotateSpeed;
        float xcamRotation = -Input.GetAxis("Mouse Y") * rotateSpeed;
        mainCamera.transform.Rotate(0f, ycamRotation, 0f);
        mainCamera.transform.Rotate(xcamRotation, 0f, 0f);
    }
}
