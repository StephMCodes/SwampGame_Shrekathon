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
        if(ObjectiveManager.getObjectiveStatus(WORDENUM.Weapon) == false)
        {
            Debug.Log("You need a weapon to kill the pumpkin!");
            return;
        }
        //Run death function in pumpkin
        pumpkinAI.Die();
        //Call UI to remove axe
        UIHandler.DisplayAxe(false);

        UIforInterablesController.SetInteractableLMBActive(false);



    }



}
