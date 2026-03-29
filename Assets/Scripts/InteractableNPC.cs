using UnityEngine;

public class NPC : Interactable
{
    [SerializeField] private DialogueUI dialogueSys;
    [SerializeField] private DialogueObject convo;
    [SerializeField] private string item;
    [SerializeField] private GameManager gameManager;
    [SerializeField] private string animationString = null;
    private Animator animator;
    private bool hasSpoken = false;

    public bool isRat = false;

    private void Start()
    {
        animator = GetComponent<Animator>();
        if(animator == null ) animator = GetComponentInChildren<Animator>();
    }

    public override void Interact()
    {
        //set to null if we dont, set to animation string if we got one
        if(animationString != null && animator != null)
        dialogueSys.setAnimationStringAndAnimator(animationString, animator); 

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
