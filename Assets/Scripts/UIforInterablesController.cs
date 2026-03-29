using UnityEngine;

public class UIforInterablesController : MonoBehaviour
{
    public GameObject interactableE;
    public GameObject interactableLMB;
    private static GameObject interactableEStatic;
    private static GameObject interactableLMBStatic;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        interactableEStatic = interactableE;
        interactableLMBStatic = interactableLMB;

        interactableEStatic.SetActive(false);
        interactableLMBStatic.SetActive(false);
    }

    public static void SetInteractableEActive(bool active)
    {
        if (interactableEStatic != null)
        {
            interactableEStatic.SetActive(active);
        }
    }

    public static void SetInteractableLMBActive(bool active)
    {
        if (interactableLMBStatic != null)
        {
            interactableLMBStatic.SetActive(active);
        }
    }


}
