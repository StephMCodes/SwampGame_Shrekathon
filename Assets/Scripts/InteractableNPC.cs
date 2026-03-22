using UnityEngine;

public class NPC : Interactable
{
    [SerializeField] private DialogueUI dialogueSys;
    [SerializeField] private DialogueObject convo;
    [SerializeField] private string item;
    [SerializeField] private GameManager gameManager;
    [SerializeField] private RPSgame rps;
    private bool hasSpoken = false;
    //[SerializeField] private Animator anim;


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
            dialogueSys.ShowDialogue(convo);
            hasSpoken = true;
            gameManager.GrantItem(item);
        }
        else
        {
            rps.gameObject.SetActive(true);
            rps.StartGame();
        }
    }
}
