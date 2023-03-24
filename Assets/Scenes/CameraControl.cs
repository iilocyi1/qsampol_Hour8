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
        float camRotation = Input.GetAxis("Mouse Y") * rotateSpeed;
        mainCamera.transform.Rotate(camRotation, 0f, 0f);

        float camRotation = Input.GetAxis("Mouse X") * rotateSpeed;
        mainCamera.transform.Rotate(of, camRotation, 0f);
        
    }
}
