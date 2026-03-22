using UnityEngine;


public class RPSgame : MonoBehaviour
{

    private int playerTries = 0;
    public RPShand leftHand;
    public RPShand rightHand;
    public GameObject parentRootref;
    private static GameObject parentRoot;

    public DialogueUI dialogueUI;
    public DialogueObject winning1Dialogue;
    public DialogueObject winning2Dialogue;
    public DialogueObject winning3Dialogue;
    public DialogueObject lossingDialogue;

    public GameObject otherUI1;
    public GameObject otherUI2;
    private static GameObject otherUI1Static;
    private static GameObject otherUI2Static;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            PlayRock();
        }
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            PlayPaper();
        }
        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            PlayScissors();
        }
    }

    public void Start() 
    {

        parentRoot = parentRootref;
        parentRoot.SetActive(false);

        otherUI1Static = otherUI1;
        otherUI2Static = otherUI2;


    }

    [ContextMenu("Start Game")]
    public static void StartGame()
    {
        if (ObjectiveManager.getObjectiveStatus(WORDENUM.Rat)) return;

        Debug.Log("Starting RPS game!");

        parentRoot.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        otherUI1Static.SetActive(false);
        otherUI2Static.SetActive(false);

        // Ensure all buttons under parentRoot are interactable
        foreach (var button in parentRoot.GetComponentsInChildren<UnityEngine.UI.Button>(true))
        {
            button.interactable = true;
        }
    }

    [ContextMenu("End Game")]
    public void EndGame() 
    {
        Debug.Log("Ending RPS game!");

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        parentRoot.SetActive(false);

        otherUI1Static.SetActive(true);
        otherUI2Static.SetActive(true);

    }



    //SO like this is the whole game, but if we want to cheat then...
    private void PlayGame(WORDENUM playerChoice)
    {


        if (!leftHand.GetMidANimation() || !rightHand.GetMidANimation()) { }

        WORDENUM[] choices = { WORDENUM.Rock, WORDENUM.Paper, WORDENUM.Scissors };
        WORDENUM computerChoice = choices[Random.Range(0, choices.Length)];

        Debug.Log("?");

        //Cheat for the first two not in favor of player
        if(playerTries < 2)
        {
            if (playerChoice == WORDENUM.Rock) computerChoice = WORDENUM.Paper;
            else if (playerChoice == WORDENUM.Paper) computerChoice = WORDENUM.Scissors;
            else if (playerChoice == WORDENUM.Scissors) computerChoice = WORDENUM.Rock;
        }

        leftHand.Play(playerChoice, true);
        rightHand.Play(computerChoice, false);

        Debug.Log("Player choice: " + playerChoice);
        Debug.Log("Computer choice: " + computerChoice);
        if (playerChoice == computerChoice)
        {
            Debug.Log("It's a tie!");
        }
        else if ((playerChoice == WORDENUM.Rock && computerChoice == WORDENUM.Scissors) ||
                 (playerChoice == WORDENUM.Paper && computerChoice == WORDENUM.Rock) ||
                 (playerChoice == WORDENUM.Scissors && computerChoice == WORDENUM.Paper))
        {
            Debug.Log("Player wins!");
            ObjectiveManager.setObjectiveStatus(WORDENUM.Rat, true);

            //Dialogue Win : There's a first for everything, we'll help you when the time comes, Boss.
            dialogueUI.ShowDialogue(lossingDialogue);
            EndGame();
        }
        else
        {
            Debug.Log("Computer wins!");
            //Dialogue Loss one : They call me the king for a reason
            if(playerTries == 0) {
      //          dialogueUI.ShowDialogue(winning1Dialogue);
            }

            //Dialogue Loss two : That's two, we could be here all day
            if (playerTries == 1) {
        //        dialogueUI.ShowDialogue(winning2Dialogue);
            }

            //Dialogue Lost three plus : Really? I'm not even cheating anymore!
            if (playerTries >= 2) {
        //        dialogueUI.ShowDialogue(winning3Dialogue);
            }

        }

        playerTries++;
    }

    public void PlayRock() { PlayGame(WORDENUM.Rock); }
    public void PlayPaper() { PlayGame(WORDENUM.Paper); }
    public void PlayScissors() { PlayGame(WORDENUM.Scissors); }



}
