using UnityEngine;

public class UIHandler : MonoBehaviour
{
    //UI for pop up Press E to interact
    public GameObject UIPressEPublic;
    private static GameObject UIPressE;


    void Start()
    {
        UIPressE = UIPressEPublic;
        UIPressE.SetActive(false);
    }

    public static void SetUIPressE(bool isActive)
    {
        if (UIPressE != null)
        {
            UIPressE.SetActive(isActive);
        }
    }

    //Update objective counters
    public void updateObjectiveCounters() {

        if (ObjectiveManager.getObjectiveStatus("Pumpkin")) 
        {
         //Add the checkmark to thing
         //Object
        }


    }

}
