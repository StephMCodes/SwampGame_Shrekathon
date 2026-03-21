using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class InteractableKill : Interactable
{
    protected override ButtonControl InteractButton => Mouse.current.leftButton;
    public GameObject targetPumpkin;
    private PumpkinAI pumpkinAI;

    //Overide the on enter to have it bed for it's life
    void Start() 
    {
        pumpkinAI = targetPumpkin.GetComponent<PumpkinAI>();

    }


    public override void Interact()
    {
        //Run death function in pumpkin
        pumpkinAI.Die();
        //Call UI to remove axe
        UIHandler.DisplayAxe(false);

        //Wait a few seconds and activate an InteractableItem (pumpkin corpse) so they can pick him up

    }



}
