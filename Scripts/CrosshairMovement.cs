using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrosshairMovement : MonoBehaviour
{
    public Camera Camera1;
    public Camera Camera2;
    //public Camera Camera3;
    //public Camera Camera4;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePosition = Input.mousePosition;

        // Convert the screen space mouse position to canvas space
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            transform.parent.GetComponent<RectTransform>(),
            mousePosition,
            null,
            out Vector2 localPoint);

        Debug.Log(localPoint.x);

        if (Camera1.enabled || Camera2.enabled)
        {
            if (localPoint.x > 203f)
                localPoint.x = 203f;
            else if (localPoint.x < -188f)
                localPoint.x = -188f;
            if (localPoint.y < 55f)
                localPoint.y = 55f;
        }
        //else if (Camera3.enabled || Camera4.enabled)
        //{
        //    if (localPoint.x < 50f)
        //        localPoint.x = 50f;
        //    else if (localPoint.x > 255f)
        //        localPoint.x = 255f;
        //    if (localPoint.y < 55f)
        //        localPoint.y = 55f;
        //}


        // Set the crosshair's position to the converted canvas space mouse position

        // transform.localPosition.x =+ localPoint.x;
        transform.localPosition = localPoint;
    }
}


