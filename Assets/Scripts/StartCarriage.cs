using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class StartCarriage : MonoBehaviour
{
    [SerializeField] private Animator animCarriage;
    [SerializeField] private AudioSource animAudio;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && ObjectiveManager.getObjectiveStatus(WORDENUM.Pumpkin) == true && ObjectiveManager.getObjectiveStatus(WORDENUM.Rat) == true && ObjectiveManager.getObjectiveStatus(WORDENUM.Wand) == true)
        {
            animCarriage.SetBool("beatgame", true);
            animAudio.Play();
            Invoke("QuitGame", 15);
        }
    }

    private void QuitGame()
    {
        Application.Quit();
    }

}
