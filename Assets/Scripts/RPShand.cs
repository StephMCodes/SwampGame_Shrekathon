using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RPShand : MonoBehaviour
{
    private Image currentImage;
    public Sprite rockSprite;
    public Sprite paperSprite;
    public Sprite scissorsSprite;

    private bool midAnimation = false;

    void Start()
    {
        // Use GetComponent instead of GetComponentInChildren if the SpriteRenderer is on the same GameObject
        currentImage = GetComponent<Image>();
        if (currentImage == null)
        {
            // Try to find in children as a fallback
            currentImage = GetComponentInChildren<Image>();
        }
        if (currentImage == null)
        {
            Debug.LogError("RPShand: No SpriteRenderer found on this GameObject or its children.");
        }
    }

    public void Play(WORDENUM choice, bool isLeftHand) 
    {
        //Animate hand then switch sprite to the correct one, then animate hand again to show the new sprite
        StartCoroutine(AnimateHand(isLeftHand));
        SetSprite(choice);

    }


    public void SetSprite(WORDENUM choice) 
    { 
        if(choice == WORDENUM.Rock)
        {
            currentImage.sprite = rockSprite;
        }
        else if (choice == WORDENUM.Paper)
        {
            currentImage.sprite = paperSprite;
        }
        else if (choice == WORDENUM.Scissors)
        {
            currentImage.sprite = scissorsSprite;
        }

    }

    public IEnumerator AnimateHand(bool isLeftHand)
    {
        int direction = isLeftHand ? 1 : -1; // Rotate in opposite directions for left and right hands

        Debug.Log("AnimateHand");

        float[] angles = { 20f, 0, 30f, 0, 40f, 0f };
        float duration = 0.40f; // Duration for each rotation
        for (int i = 0; i < angles.Length; i++)
        {
            duration += 0.05f; // Increase duration for each subsequent rotation

            float startAngle = transform.eulerAngles.z;
            float endAngle = (direction*angles[i]);
            float elapsed = 0f;
            while (elapsed < duration)
            {
                float z = Mathf.LerpAngle(startAngle, endAngle, elapsed / duration);
                transform.eulerAngles = new Vector3(0, 0, z);
                elapsed += Time.deltaTime;
                yield return null;
            }
            transform.eulerAngles = new Vector3(0, 0, endAngle);
        }
    }

}
