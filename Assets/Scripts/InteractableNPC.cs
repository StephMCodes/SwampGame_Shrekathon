using UnityEngine;

public class NPC : Interactable
{
    [SerializeField] private DialogueUI dialogueSys;
    [SerializeField] private DialogueObject convo;
    [SerializeField] private string item;
    [SerializeField] private GameManager gameManager;
    private bool hasSpoken = false;

    public bool isRat = false;

    public override void Interact()
    {

        if(isRat) {dialogueSys.SetIsRat(true); } else { dialogueSys.SetIsRat(false); }

        base.Interact(); // Calls the base log message (optional)
        Debug.Log("Talking to the NPC!");
        if (!hasSpoken)
        {
            
            dialogueSys.ShowDialogue(convo);
            hasSpoken = true;
            //gameManager.GrantItem(item);
        }
        
    }
}
