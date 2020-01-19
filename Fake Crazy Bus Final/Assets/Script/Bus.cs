using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bus : MonoBehaviour
{
    private float busSpeed = 5f;

    private bool playAudio = false;

    [SerializeField]
    private Sprite[] busSprite;

    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
    }

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        ChangeBusSprite();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale != 0)
        {
            BusMove();
        }
    }

    void BusMove()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * Time.deltaTime * busSpeed;
            PlayDriveSFX();
            IncreaseScore();
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * Time.deltaTime * busSpeed;
            PlayDriveSFX();
            DecreaseScore();
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            PlayHorn();
        }
    }
    void IncreaseScore()
    {
        // Increase score if bus goes right direction
        GameManager.Instance.Score++;
    }

    void DecreaseScore()
    {
        // If score is less or equal to 0, make the score doesn't go to negative
        if (GameManager.Instance.Score <= 0)
        {
            GameManager.Instance.Score = 0;
        }
        // If score is more than 0, score decreaes when it goes left direction
        else
        {
            GameManager.Instance.Score--;
        }
    }

    void PlayHorn()
    {
        FindObjectOfType<AudioManager>().Play("Horn");

    }

    void PlayDriveSFX()
    {
        playAudio = FindObjectOfType<AudioManager>().IsPlaying("Drive");
        if (playAudio == true)
        {

        }
        else
        {
            FindObjectOfType<AudioManager>().Play("Drive");
        }

    }

    void ChangeBusSprite()
    {
        switch(ButtonManager.busSelection)
        {
            case 1:
                spriteRenderer.sprite = busSprite[0];
                break;
            case 2:
                spriteRenderer.sprite = busSprite[1];
                break;
            case 3:
                spriteRenderer.sprite = busSprite[2];
                break;
            case 4:
                spriteRenderer.sprite = busSprite[3];
                break;
            default:
                Debug.Log("Error on busSelection value; set into 0");
                spriteRenderer.sprite = busSprite[0];
                break;
        }
    }
}
