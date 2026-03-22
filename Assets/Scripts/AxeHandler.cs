using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class AxeHandler : MonoBehaviour
{
    public GameObject model;
    private Animator targetAnimator;
    public string triggerName;

    private void Start()
    {
        targetAnimator = model.GetComponent<Animator>();
    }

    void Update() 
    {

        if (ObjectiveManager.getObjectiveStatus(WORDENUM.Weapon))
        {
            if (Mouse.current.leftButton.wasPressedThisFrame) 
                Swing();    
        
        }

    }

    //Set model true for show and false for hide
    public void ShowModel(bool State) {

        model.SetActive(State);

    }

    public void Swing() 
    {

        //Play Animation for model
        targetAnimator.SetTrigger(triggerName);


        //and sound effect for swinging axe


    }

}
