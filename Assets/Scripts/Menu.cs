using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
    public GameObject mainMenu, creditsMenu;

    public void play()
    {
        SceneManager.LoadScene(1);
    }

    public void Credits() {
        mainMenu.SetActive(false);
        creditsMenu.SetActive(true);
    }

    public void MainMenu()
    {
        mainMenu.SetActive(true);
        creditsMenu.SetActive(false);
    }

    public void Quit() {
        Application.Quit();
    }

    public void loadMain() {
        SceneManager.LoadScene(0);
    }
}
