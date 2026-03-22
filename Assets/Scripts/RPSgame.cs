using UnityEngine;


public class RPSgame : MonoBehaviour
{

    private int playerTries = 0;
    public RPShand leftHand;
    public RPShand rightHand;
    public GameObject parentRoot;



    public void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
          //  StartGame();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
          //  EndGame();
        }
    }

    public void Start() 
    { 
        EndGame();
    }

    [ContextMenu("Start Game")]
    public void StartGame() 
    {
        parentRoot.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    [ContextMenu("End Game")]
    public void EndGame() 
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        parentRoot.SetActive(false);
    }



    //SO like this is the whole game, but if we want to cheat then...
    private void PlayGame(WORDENUM playerChoice)
    {
        if (leftHand.GetMidANimation() || rightHand.GetMidANimation()) return;

        WORDENUM[] choices = { WORDENUM.Rock, WORDENUM.Paper, WORDENUM.Scissors };
        WORDENUM computerChoice = choices[Random.Range(0, choices.Length)];

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
        }
        else
        {
            Debug.Log("Computer wins!");
        }

        playerTries++;
    }

    public void PlayRock() { PlayGame(WORDENUM.Rock); }
    public void PlayPaper() { PlayGame(WORDENUM.Paper); }
    public void PlayScissors() { PlayGame(WORDENUM.Scissors); }



}
