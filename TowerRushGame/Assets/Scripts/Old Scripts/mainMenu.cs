using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{

    public GameObject Panel;
    //public GameObject MainMenuLower_Panel;

    public void OpenPanel()
    {
        if (Panel != null)
        {
            Panel.SetActive(true);
        }
    }

    public void ClosePanel()
    {
        if (Panel != null)
        {
            Panel.SetActive(false);
        }
    }

    public void ExitPanel()
    {
        if (Panel != null)
        {
            Panel.SetActive(false);
            //Debug.Log("Store Panel Closed.!!");
        }
    }

    public void ShowPauseMenu()
    {
        Panel.SetActive(true);
        Time.timeScale = 0.0f;
    }
}
