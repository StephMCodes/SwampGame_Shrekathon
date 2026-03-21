using UnityEngine;

public class UIHandler : MonoBehaviour
{
    //UI for pop up Press E to interact
    public GameObject uh;
    private static GameObject UIPressE;
    void Start()
    {
        UIPressE = uh;
        UIPressE.SetActive(false);
    }

    public static void SetUIPressE(bool isActive)
    {
        if (UIPressE != null)
        {
            UIPressE.SetActive(isActive);
        }
    }

}
