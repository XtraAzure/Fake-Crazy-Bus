using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ButtonManager : MonoBehaviour
{

    public static int busSelection;

    public void GoToMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
    }

   public void GoToBusSelection()
   {
        SceneManager.LoadScene("BusSelection");
   }

   public void GoToOption()
   {
        SceneManager.LoadScene("Option");
   }

   public void GoToCredit()
   {
        Debug.Log("Hit");
        SceneManager.LoadScene("Credit");
   }

   public void GoToMainGame()
   {
        SceneManager.LoadScene("MainGame");
   }

   public void QuitGame()
   {
        Application.Quit();
   }

    public void GoToControlYellow()
    {
        busSelection = 1;
        SceneManager.LoadScene("Control");
    }

    public void GoToControlRed()
    {
        busSelection = 2;
        SceneManager.LoadScene("Control");
    }
    public void GoToControlBlue()
    {
        busSelection = 3;
        SceneManager.LoadScene("Control");
    }
    public void GoToControlGreen()
    {
        busSelection = 4;
        SceneManager.LoadScene("Control");
    }

}
