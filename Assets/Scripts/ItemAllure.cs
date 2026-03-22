using UnityEngine;
using System;

public class ItemAllure : MonoBehaviour
{


    public float rotateSpeed = 50f;

    // Adjust this to change the height of the bounce in the Unity Editor
    public float bounceStrength = 0.5f;
    // Adjust this to change the speed of the bounce
    public float bounceSpeed = 1f;


    private float originalY;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        originalY = this.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        //Rotate around Y-Axus
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);

        //Float up and down
        // Calculate the new Y position using a sine wave
        float newY = originalY + ((float)Math.Sin(Time.time * bounceSpeed) * bounceStrength);
        // Update the object's position (maintain X and Z positions)
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }

}

