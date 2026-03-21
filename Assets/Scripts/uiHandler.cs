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

        updateObjectiveCounters();
    }

    public static void SetUIPressE(bool isActive)
    {
        if (UIPressE != null)
        {
            UIPressE.SetActive(isActive);
        }
    }

    //Update objective counters
    public static void updateObjectiveCounters() {

        bool pump = ObjectiveManager.getObjectiveStatus(WORDENUM.Pumpkin);
        bool wand = ObjectiveManager.getObjectiveStatus(WORDENUM.Wand);
        bool rat = ObjectiveManager.getObjectiveStatus(WORDENUM.Rat);

        Debug.Log("Pumpkin: " + pump + " Wand: " + wand + " Rat: " + rat);

        ObjectiveUIListHandler.setPumkin(pump);
        ObjectiveUIListHandler.setWand(wand);
        ObjectiveUIListHandler.setRat(rat);
        

    }

}
