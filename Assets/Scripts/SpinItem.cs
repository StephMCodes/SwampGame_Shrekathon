using UnityEngine;

public class SpinItem : MonoBehaviour
{
    public Vector3 rotationDirection;
    public float speed = 20f;

    void Update()
    {
        // Rotate the object around its local axes
        transform.Rotate(rotationDirection * speed * Time.deltaTime);
    }
}
