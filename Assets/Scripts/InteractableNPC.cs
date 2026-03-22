using UnityEngine;

public class NPC : Interactable
{
    [SerializeField] private DialogueUI dialogueSys;
    [SerializeField] private DialogueObject convo;
    [SerializeField] private string item;
    //[SerializeField] private GameManager gameManager;
    private bool hasSpoken = false;
    //[SerializeField] private Animator anim;

    public bool isRat=false;


    private void Update()
    {
        if (DialogueUI.inDialogue == true)
        {
            //anim.SetBool("x", true);
        }
        else
        {
            //anim.SetBool("x", false);

        }
    }

    public override void Interact()
    {
        base.Interact(); // Calls the base log message (optional)
        Debug.Log("Talking to the NPC!");
        if (!hasSpoken)
        {
            if (isRat) dialogueSys.SetIsRat(true);

            dialogueSys.ShowDialogue(convo);
            hasSpoken = true;
            //gameManager.GrantItem(item);
        }
        
    }
}
