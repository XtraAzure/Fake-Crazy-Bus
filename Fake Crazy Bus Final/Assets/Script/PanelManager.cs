using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelManager : MonoBehaviour
{
    [SerializeField]
    private GameObject pressAPanel;

    private void Update()
    {
        if (Input.anyKey)
        {
            DisablePanel();

        }
    }

    private void DisablePanel()
    {
        pressAPanel.SetActive(false);
        SceneManager.LoadScene("Menu");
    }
}
