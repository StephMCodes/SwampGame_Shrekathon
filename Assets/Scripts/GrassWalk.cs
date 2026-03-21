using UnityEngine;

public class GrassWalk : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") == -1 || Input.GetAxis("Horizontal") == 1 || Input.GetAxis("Vertical") == -1 || Input.GetAxis("Vertical") == 1)
        {
            audioSource.volume = 1.0f;
            //Debug.Log("PLayer moving");
        }
        else
        {
            audioSource.volume = 0f;

        }
    }
}
