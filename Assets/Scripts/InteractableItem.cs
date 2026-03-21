using UnityEngine;


public class InteractableItem : Interactable
{

    public WORDENUM heldItem;

    public override void Interact()
    {
        //When user pressed E to interact, they get item
        ObjectiveManager.setObjectiveStatus(heldItem, true); // Set the objective to true when the item is interacted with

    }
}
