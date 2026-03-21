using UnityEngine;


public class InteractableItem : Interactable
{

    public WORDENUM heldItem;
    public bool removeAfterInteraction = true; // Set to true if you want the item to be removed after interaction

    public override void Interact()
    {
        //When user pressed E to interact, they get item
        ObjectiveManager.setObjectiveStatus(heldItem, true); // Set the objective to true when the item is interacted with

        if (removeAfterInteraction) 
        {
            gameObject.SetActive(false);
            UIHandler.SetUIPressE(false);
        }
    }
}
