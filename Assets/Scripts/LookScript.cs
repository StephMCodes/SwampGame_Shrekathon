using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Splines;

public class LookScript : MonoBehaviour
{

    public float lookSpeed = 5.0f;

    private float rotationX = 0.0f;
    private float rotationY = 0.0f;

    void Update()
    {
        var target = Camera.main.transform.position;
        target.y = transform.position.y;
        transform.LookAt(target);
    }
}