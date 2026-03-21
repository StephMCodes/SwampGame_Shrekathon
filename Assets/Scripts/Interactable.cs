using UnityEngine;
using UnityEngine.InputSystem;


public class Interactable : MonoBehaviour
{
    private bool isInRange = false;
    private UIHandler uihandler;

    void Update()
    {
        if (isInRange && Keyboard.current != null && Keyboard.current.eKey.wasPressedThisFrame)
        {
            Interact();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Use tags for clear identification
        {
            isInRange = true;
            uihandler.SetUIPressE(true);
            
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isInRange = false;
            uihandler.SetUIPressE(false);
        }
    }

    public virtual void Interact()
    {
        Debug.Log("Interacting with base interactable object.");
    }
}
