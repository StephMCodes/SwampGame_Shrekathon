using UnityEngine;
using UnityEngine.UI;

public class ObjectiveUI : MonoBehaviour
{
    public Toggle toggle;
   

    public void setToggle(bool toggleState)
    {
        if (toggle != null)
        {
            toggle.isOn = toggleState;
        }
    }
}
