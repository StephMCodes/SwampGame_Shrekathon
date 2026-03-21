using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;


public class Interactable : MonoBehaviour
{
    private bool isInRange = false;
    protected virtual ButtonControl InteractButton => Keyboard.current.eKey;

    void Update()
    {
        if (isInRange && InteractButton != null && InteractButton.wasPressedThisFrame)
        {
            Interact();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
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
