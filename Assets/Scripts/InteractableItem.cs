using UnityEngine;


public class InteractableItem : Interactable
{

    public string itemName = ""; // Name of the item

    public override void Interact()
    {
        //When user pressed E to interact, they get item
        ObjectiveManager.setObjectiveStatus(itemName,true); // Set the objective to true when the item is interacted with

    }
}
