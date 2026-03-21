using UnityEngine;
using UnityEngine.UI;

public class ObjectiveUI : MonoBehaviour
{
    private Toggle toggle;
    
    void Start()
    {
        toggle = GetComponent<Toggle>();
    }

    public void setToggle(bool toggleState)
    {
        if (toggle != null)
        {
            toggle.isOn = toggleState;
        }
    }
}
