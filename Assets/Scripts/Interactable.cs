using UnityEngine;
using UnityEngine.InputSystem;


public class Interactable : MonoBehaviour
{
    private bool isInRange = false;
    private UIHandler uihandler;
    protected UIVirtualButton interactButton = Keyboard.current.eKey;



    void Update()
    {
        if (isInRange && Keyboard.current != null && interactButton.wasPressedThisFrame)
        {
            Interact();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Use tags for clear identification
        {
            isInRange = true;
            UIHandler.SetUIPressE(true);
            
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isInRange = false;
            UIHandler.SetUIPressE(false);
        }
    }

    public virtual void Interact()
    {
        Debug.Log("Interacting with base interactable object.");
    }
}
