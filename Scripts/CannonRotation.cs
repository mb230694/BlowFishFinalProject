using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class CannonRotation : MonoBehaviour
//{
//    public Transform cameraTransform;
//    public float horizontalRotationSpeed = 1f;
//    public float verticalRotationSpeed = 1f;
//    public float rotationLimitHorizontal = 30f;
//    public float rotationLimitVertical = 15f;

//    private Quaternion originalCannonRotation;
//    private Quaternion originalCameraRotation;
//    private float mouseX;
//    private float mouseY;

//    // Start is called before the first frame update
//    void Start()
//    {
//        originalCannonRotation = transform.rotation;
//        originalCameraRotation = cameraTransform.localRotation;
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        mouseX += Input.GetAxis("Mouse X") * horizontalRotationSpeed;
//        mouseY -= Input.GetAxis("Mouse Y") * verticalRotationSpeed;
//        mouseX = Mathf.Clamp(mouseX, -rotationLimitHorizontal, rotationLimitHorizontal);
//        mouseY = Mathf.Clamp(mouseY, -rotationLimitVertical, rotationLimitVertical);

//        // Calculate the target rotation based on the mouse input
//        Quaternion targetCannonRotation = originalCannonRotation * Quaternion.Euler(0f, mouseX, mouseY);
//        Quaternion targetCameraRotation = originalCameraRotation * Quaternion.Euler(mouseY, 0f, 0f);

//        // Rotate the cannon and camera
//        transform.rotation = targetCannonRotation;
//        cameraTransform.localRotation = targetCameraRotation;

//    }


//}

public class CannonRotation : MonoBehaviour
{
    public Transform crosshair;
    public float horizontalRotationSpeed = 1f;
    public float verticalRotationSpeed = 1f;
    public float rotationLimitHorizontal = 30f;
    public float rotationLimitVertical = 10f;
    // public Camera Camera1;
    // public Camera Camera2;
   
    private Quaternion originalCannonRotation;
    private float mouseX;
    private float mouseY;
   
    private void Start()
    {
        originalCannonRotation = transform.rotation;
       
    }

   public void RotateCannon(float mouseX, float mouseY)
    {
        mouseX = Mathf.Clamp(mouseX, -rotationLimitHorizontal, rotationLimitHorizontal);
        mouseY = Mathf.Clamp(mouseY, -rotationLimitVertical, rotationLimitVertical);

        // Calculate the target rotation based on the mouse input and crosshair position
        Quaternion targetCannonRotation = originalCannonRotation * Quaternion.Euler(0f, mouseX, -mouseY);


        // Rotate the cannon horizontally
        transform.rotation = targetCannonRotation;
       

    }
    private void Update()
    {
        mouseX += Input.GetAxis("Mouse X") * horizontalRotationSpeed;
        mouseY -= Input.GetAxis("Mouse Y") * verticalRotationSpeed;
        //if(Camera1.enabled || Camera2.enabled)
           RotateCannon(mouseX,mouseY);
        //else
        //{
        //    // Calculate the target rotation based on the mouse input and crosshair position
        //    Quaternion targetCannonRotation = originalCannonRotation * Quaternion.Euler(0f, mouseX, -mouseY);


        //    // Rotate the cannon horizontally
        //    transform.rotation = targetCannonRotation;
        //}
    }
}