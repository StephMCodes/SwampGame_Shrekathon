using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;


public class Interactable : MonoBehaviour
{
    private bool isInRange = false;
    public WORDENUM interactionButton = WORDENUM.None;
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
        if (other.CompareTag("Player") && (this.enabled == true))
        {
            isInRange = true;

            SetInteractableUIActive(true);


        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") && (this.enabled == true))
        {
            isInRange = false;
            SetInteractableUIActive(false);
        }
    }

    public virtual void Interact()
    {
        Debug.Log("Interacting with base interactable object.");
    }

    protected void SetInteractableUIActive(bool isActive)
    {
        if (interactionButton == WORDENUM.EToInteract)
        {
            UIforInterablesController.SetInteractableEActive(isActive);
        }
        else if (interactionButton == WORDENUM.LmbToInteract)
        {
            UIforInterablesController.SetInteractableLMBActive(isActive);
        }
    }
}
