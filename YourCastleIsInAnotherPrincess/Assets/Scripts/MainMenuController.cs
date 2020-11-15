using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject creditMenu;

    public void playGame()
    {
        SceneManager.LoadScene("Mountain");
    }

    public void credits()
    {
        mainMenu.SetActive(false);
        creditMenu.SetActive(true);
    }
    
    public void back()
    {
        mainMenu.SetActive(true);
        creditMenu.SetActive(false);
    }

    public void exitGame()
    {
        Application.Quit();
    }
}
