using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// https://www.youtube.com/watch?v=D2hvXjQgCtM
public class BlinkingText : MonoBehaviour
{
    private Text playText;

    // Start is called before the first frame update
    void Start()
    {
        playText = GetComponent<Text>();
        StartBlinking();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Blink()
    {
        while(true)
        {
            switch(playText.color.a.ToString())
            {
                case "0":
                    playText.color = new Color(playText.color.r, playText.color.g, playText.color.b, 1);
                    //Play sound
                    yield return new WaitForSeconds(0.5f);
                    break;
                case "1":
                    playText.color = new Color(playText.color.r, playText.color.g, playText.color.b, 0);
                    // Play sound
                    yield return new WaitForSeconds(0.5f);
                    break;
            }
        }
    }
    void StartBlinking()
    {
        StopCoroutine("Blink");
        StartCoroutine("Blink");
    }

    void StopBlinking()
    {
        StopCoroutine("Blink");
    }
}
