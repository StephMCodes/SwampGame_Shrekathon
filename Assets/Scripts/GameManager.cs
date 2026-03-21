using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static int onionCount = 0;
    public static bool gameOver = false;
    [SerializeField] GameObject endingCanvas;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
           Cursor.lockState = CursorLockMode.Locked;

    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver)
        {
           endingCanvas.SetActive(true);
           Cursor.visible = true;
           Cursor.lockState = CursorLockMode.None;
        }
    }
}
