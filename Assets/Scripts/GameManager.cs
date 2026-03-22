using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static int onionCount = 0;
    public static bool hasRats = false;
    public static bool hasWand = false;
    public static bool hasPumpkin = false;

    public static bool gameOver = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
           Cursor.lockState = CursorLockMode.Locked;

    }

    public void GrantItem(string item)
    {
        switch(item) {
            case "onion":
                onionCount++;
                break;
            case "rats":
                hasRats = true;
                Debug.Log("Rats: " + hasRats);
                ObjectiveManager.setObjectiveStatus(WORDENUM.Rat, true);
                break;
            case "wand":
                hasWand = true;
                break;
            case "pumpkin":
                hasPumpkin = true;
                break;
            default:
                //nothing
                break;
        }
    }

    // Update is called once per frame
    //void Update()
    //{
    //    if (gameOver)
    //    {
    //       Cursor.visible = true;
    //       Cursor.lockState = CursorLockMode.None;
    //    }
    //}
}
