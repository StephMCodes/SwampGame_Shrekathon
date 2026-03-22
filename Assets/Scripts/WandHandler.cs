using UnityEngine;

public class WandHandler : MonoBehaviour
{

    public GameObject wandIdleRef;
    private static GameObject wandIdle;

    public GameObject wandActiveRef;
    private static GameObject wandActive;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        wandIdle = wandIdleRef;
        wandActive = wandActiveRef;

        wandIdle.SetActive(true);
        wandActive.SetActive(false);
    }


    public static void OnionCountMet() 
    { 
        wandIdle.SetActive(false);
        wandActive.SetActive(true);
    }

}
