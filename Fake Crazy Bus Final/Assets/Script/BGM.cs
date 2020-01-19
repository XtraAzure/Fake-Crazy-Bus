using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        IntroBGM();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void IntroBGM()
    {
        FindObjectOfType<AudioManager>().Play("IntroBGM");
    }
}
