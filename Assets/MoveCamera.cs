using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{

    private float mouseSensitivity = 3.0f;
    public CharacterController controller;
    private float RotY = 0;
    private float RotX = 0;
    private Vector3 translate = new Vector3(0,0,0);
    void Update()
    {   
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        RotX += mouseY;
        RotY += mouseX;
        transform.localEulerAngles = new Vector3(-RotX * 3, RotY * 3, 0);

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * 12f * Time.deltaTime);
      
      
        
        
    }
}
