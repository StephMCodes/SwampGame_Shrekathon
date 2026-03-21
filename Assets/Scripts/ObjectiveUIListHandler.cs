using UnityEngine;

public class ObjectiveUIListHandler : MonoBehaviour
{

    public ObjectiveUI pumpkin;
    public ObjectiveUI rat;
    public ObjectiveUI wand;


    public static void setPumkin(bool toggleState)
    {
        ObjectiveUIListHandler handler = FindObjectOfType<ObjectiveUIListHandler>();
        if (handler != null)
        {
            handler.pumpkin.setToggle(toggleState);
        }
    }
}
