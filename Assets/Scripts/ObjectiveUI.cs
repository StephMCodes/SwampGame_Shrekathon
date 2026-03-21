using UnityEngine;
using UnityEngine.UI;

public class ObjectiveUI : MonoBehaviour
{
    public Toggle toggle;
   

    public void setToggle(bool toggleState)
    {
        Debug.Log("Setting toggle state to: " + toggleState + " for " + gameObject.name);
        Debug.Log("Toggle component found: " + (toggle != null));
        if (toggle != null)
        {
            toggle.isOn = toggleState;
        }
    }
}
