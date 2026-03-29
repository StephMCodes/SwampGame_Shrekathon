using UnityEngine;

public class UIHandler : MonoBehaviour
{


    public GameObject axeHoldablePrefab;
    static private AxeHandler axeHandler;

    void Start()
    {

        axeHandler = axeHoldablePrefab.GetComponent<AxeHandler>();

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



    //I dont think this function is called anymore
    public static void SetUIPressE(bool isActive)
    {
            UIforInterablesController.SetInteractableEActive(isActive);   
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
