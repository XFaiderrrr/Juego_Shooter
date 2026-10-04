using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour{

    public float mouseSensivity = 80f;
    public Transform playerBody;
    float xRotation = 0;

    //Primer frame - lo que se llamara primero
    void Start (){
        Debug.Log("Update");
        Cursor.lockState = CursorLockMode.Locked;
    }   

    //Frame a frame - lo que se llamara siempre
    void Update (){

        float mouseX = Input.GetAxis("Mouse X")*mouseSensivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y")*mouseSensivity * Time.deltaTime;

        xRotation -= mouseY;
        
        xRotation = Mathf.Clamp(xRotation, -90f,90f);
        transform.localRotation = Quaternion.Euler(xRotation,0,0);

        playerBody.Rotate(Vector3.up*mouseX);
        

    }
    
}
