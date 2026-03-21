using UnityEngine;

public class ObjectiveUIListHandler : MonoBehaviour
{
    public  ObjectiveUI pumpkinPub;
    public  ObjectiveUI ratPub;
    public  ObjectiveUI wandPub;

    private static ObjectiveUI pumpkin;
    private static ObjectiveUI rat;
    private static ObjectiveUI wand;

    private void Awake()
    {
        pumpkin = pumpkinPub;
        rat = ratPub;
        wand = wandPub;

    }


    public static void setPumkin(bool toggleState)
    {
        pumpkin.setToggle(toggleState);
    }

    public static void setRat(bool toggleState)
    {
        rat.setToggle(toggleState);
    }

    public static void setWand(bool toggleState)
    {
        wand.setToggle(toggleState);
    }

}
