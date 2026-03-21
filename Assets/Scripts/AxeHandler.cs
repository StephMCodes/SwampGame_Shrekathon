using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class AxeHandler : MonoBehaviour
{
    public GameObject model;

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

        Debug.Log("Swinging Axe!");

        //Play Animation for model
        
        
        //and sound effect for swinging axe


    }

}
