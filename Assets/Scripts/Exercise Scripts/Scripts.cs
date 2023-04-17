using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scripts : MonoBehaviour
{
    public float moveSpeed = .1f;
    public GameObject target;
    
    Vector3 originalScale;
    Vector3 doubleScale;
    bool enLarged;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Main Camera");

        originalScale = transform.localScale;
        doubleScale = originalScale * 2;
        enLarged = false;
           
    }

    // Update is called once per frame
    void Update()
    {
        float xAxis = Input.GetAxis("Horizontal") * moveSpeed;
        float zAxis = Input.GetAxis("Vertical") * moveSpeed;
        transform.Translate(xAxis, 0f, zAxis);

        
        float yCamera = Input.GetAxis("Mouse Y");
        float xCamera = Input.GetAxis("Mouse X");
        transform.Rotate(yCamera, xCamera, 0f);

        if (Input.GetKeyDown(KeyCode.M))
        {
            if (enLarged)
            {
                enLarged = false;
                transform.localScale = originalScale;
            }
                
            else 
            {
                enLarged = true;
                transform.localScale = doubleScale;
            }
                   
        }
       
    }
}
