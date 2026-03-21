using UnityEngine;

public class UIHandler : MonoBehaviour
{
    //UI for pop up Press E to interact
    public GameObject UIPressEPublic;
    private static GameObject UIPressE;

    public GameObject axePrefab;
    static private AxeHandler axeHandler;

    void Start()
    {
        UIPressE = UIPressEPublic;
        UIPressE.SetActive(false);

        axeHandler = axePrefab.GetComponent<AxeHandler>();

        RefreshUI();
    }

    public static void AxeSwing() 
    {
        axeHandler.Swing();
    }

    public static void DisplayAxe(bool state)
    {
        axeHandler.ShowModel(state);
    }




    public static void SetUIPressE(bool isActive)
    {
        if (UIPressE != null)
        {
            UIPressE.SetActive(isActive);
        }
    }

    //Update objective counters
    public static void RefreshUI() {

        bool pump = ObjectiveManager.getObjectiveStatus(WORDENUM.Pumpkin);
        bool wand = ObjectiveManager.getObjectiveStatus(WORDENUM.Wand);
        bool rat = ObjectiveManager.getObjectiveStatus(WORDENUM.Rat);
        bool weapon = ObjectiveManager.getObjectiveStatus(WORDENUM.Weapon);

        Debug.Log("Pumpkin: " + pump + " Wand: " + wand + " Rat: " + rat);

        ObjectiveUIListHandler.setPumkin(pump);
        ObjectiveUIListHandler.setWand(wand);
        ObjectiveUIListHandler.setRat(rat);

        DisplayAxe(weapon);
        

    }

}
