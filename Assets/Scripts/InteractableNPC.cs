using UnityEngine;

public class NPC : Interactable
{
    public override void Interact()
    {
        base.Interact(); // Calls the base log message (optional)
        Debug.Log("Talking to the NPC!");
        // Add NPC dialogue logic here
    }
}
