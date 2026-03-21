using UnityEngine;

public class AxeHandler : MonoBehaviour
{
    public GameObject model;

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
