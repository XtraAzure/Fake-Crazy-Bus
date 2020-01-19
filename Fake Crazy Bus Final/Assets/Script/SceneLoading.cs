using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoading : MonoBehaviour
{

    private float delay = 3f;
    private string MainGame = "MainGame";
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Time.timeScale);
        StartCoroutine(LoadLevelAfterDelay(delay));
    }

    IEnumerator LoadLevelAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(MainGame);
    }
}
