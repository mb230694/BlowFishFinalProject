using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class CannonController : MonoBehaviour
{
    public float rotationSpeed = 1;
    public float BlastPower = 5;
    public GameObject Cannonball;
    public Transform ShotPoint;
    public GameObject ExplosionCannon;

    public float maxVerticalRotation = 30f; // Maximum vertical rotation in degrees
    public float maxHorizontalRotation = 45f; // Maximum vertical rotation in degrees
    public float currentVerticalRotation = 0.0f;
    public float currentHorizontalRotation = 0.0f;

    public float initalHorizontalPos;

    private void Update()
    {
        float horizontalRotation = Input.GetAxis("Mouse X"); // Y-axis controls horizontal rotation
        float verticalRotation = -Input.GetAxis("Mouse Y"); // X-axis controls vertical rotation (inverted)

        /// Accumulate the vertical rotation
        currentVerticalRotation += verticalRotation * rotationSpeed;

        /// Accumulate the horizontal rotation
        currentHorizontalRotation += horizontalRotation * rotationSpeed;

        // Limit the accumulated vertical rotation
        currentVerticalRotation = Mathf.Clamp(currentVerticalRotation, -maxVerticalRotation, maxVerticalRotation);



        // Limit the accumulated horizontal rotation
        currentHorizontalRotation = Mathf.Clamp(currentHorizontalRotation, initalHorizontalPos - maxHorizontalRotation, initalHorizontalPos+ maxHorizontalRotation);

        // Apply rotation to Y and Z axes
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x,currentHorizontalRotation,currentVerticalRotation);

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject createdCannonball = Instantiate(Cannonball, ShotPoint.position, ShotPoint.rotation);
            createdCannonball.GetComponent<Rigidbody>().velocity = ShotPoint.transform.up * BlastPower;

            Destroy(Instantiate(ExplosionCannon, ShotPoint.position + new Vector3(4,-1,0), ShotPoint.rotation),1);
            
        }
    }
}
