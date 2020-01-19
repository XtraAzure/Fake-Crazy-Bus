using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundManager : MonoBehaviour
{
    [SerializeField]
    private Sprite[] backgroundSprite;

    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        ChangeBackground();
    }

    void ChangeBackground()
    {
        switch (ButtonManager.busSelection)
        {
            case 1:
                spriteRenderer.sprite = backgroundSprite[0];
                break;
            case 2:
                spriteRenderer.sprite = backgroundSprite[1];
                break;
            case 3:
                spriteRenderer.sprite = backgroundSprite[2];
                break;
            case 4:
                spriteRenderer.sprite = backgroundSprite[3];
                break;
            default:
                Debug.Log("Error on busSelection value; set into 0");
                spriteRenderer.sprite = backgroundSprite[0];
                break;
        }
    }
}
