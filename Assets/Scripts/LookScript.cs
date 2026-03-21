using Unity.VisualScripting;
using UnityEngine;

public class LookScript : MonoBehaviour
{

    public float lookSpeed = 5.0f;

    private float rotationX = 0.0f;
    private float rotationY = 0.0f;

    void Update()
    {
        rotationX += Input.GetAxis("Mouse X") * lookSpeed;
        rotationY = Mathf.Clamp(rotationY, -90f, 90f);

        transform.localRotation = Quaternion.Euler(rotationY, rotationX, 0.0f);
    }
}