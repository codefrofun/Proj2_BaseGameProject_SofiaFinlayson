using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    public GameManagerScript gameManager;

    public GameObject mainMenuUI;
    public GameObject gameplayUI;
    public GameObject pauseUI;
    public GameObject creditUI;

    public void EnableMainMenu()
    {
        DisableAll();
        mainMenuUI.SetActive(true);
    }

    public void EnableGameplay()
    {
        DisableAll();
        gameplayUI.SetActive(true);
    }
    public void EnablePause()
    {
        DisableAll();
        pauseUI.SetActive(true);
    }

    public void EnableCredits()
    {
        DisableAll();
        creditUI.SetActive(true);
    }

    public void DisableAll()
    {
        mainMenuUI.SetActive(false);
        gameplayUI.SetActive(false);
        pauseUI.SetActive(false);
        creditUI.SetActive(false);
    }
}
