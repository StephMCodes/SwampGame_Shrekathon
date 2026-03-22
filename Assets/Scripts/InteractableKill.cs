using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class InteractableKill : Interactable
{
    protected override ButtonControl InteractButton => Mouse.current.leftButton;
    private PumpkinAI pumpkinAI;

    //Overide the on enter to have it bed for it's life
    void Start() 
    {
        pumpkinAI = this.GetComponent<PumpkinAI>();
       
    }


    public override void Interact()
    {
        Debug.Log("Interacted with Kill");

        //Run death function in pumpkin
        pumpkinAI.Die();
        //Call UI to remove axe
        UIHandler.DisplayAxe(false);

        
    }



}
