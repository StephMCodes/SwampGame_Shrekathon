using UnityEngine;
using System.Collections;

public class RPShand : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite rockSprite;
    public Sprite paperSprite;
    public Sprite scissorsSprite;

    void Start() 
    { 
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }


    public void Play(WORDENUM play, bool isLeftHand) 
    {
        //Animate hand then switch sprite to the correct one, then animate hand again to show the new sprite
        AnimateHand(isLeftHand);
        SetSprite(play);

    }


    public void SetSprite(WORDENUM sprite) 
    { 
    if(sprite == WORDENUM.Rock)
        {
            spriteRenderer.sprite = rockSprite;
        }
        else if (sprite == WORDENUM.Paper)
        {
            spriteRenderer.sprite = paperSprite;
        }
        else if (sprite == WORDENUM.Scissors)
        {
            spriteRenderer.sprite = scissorsSprite;
        }

    }

    public IEnumerator AnimateHand(bool isLeftHand)
    {
        int direction = isLeftHand ? 1 : -1; // Rotate in opposite directions for left and right hands


        float[] angles = { -30f, 30f, -30f, 30f, -30f, 30f };
        float duration = 0.15f; // Duration for each rotation
        for (int i = 0; i < angles.Length; i++)
        {
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
