using UnityEngine;

public class UIHandler : MonoBehaviour
{
    //UI for pop up Press E to interact
    public GameObject UIPressE;
    void Start()
    {
        UIPressE.SetActive(false);
    }

    public void SetUIPressE(bool isActive)
    {
        if (UIPressE != null)
        {
            UIPressE.SetActive(isActive);
        }
    }

}
