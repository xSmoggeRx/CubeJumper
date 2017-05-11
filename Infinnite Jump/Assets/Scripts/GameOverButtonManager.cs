using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverButtonManager : MonoBehaviour {

    public Button buttonMainMenu;
    public Button buttonRetry;

    // Use this for initialization
    void Start()
    {
        buttonRetry.onClick.AddListener(RetryButton);
        buttonMainMenu.onClick.AddListener(MainMenuButton);
        
    }

    void RetryButton()
    {
        SceneManager.LoadScene("MainScene");
    }

    void MainMenuButton()
    {
        SceneManager.LoadScene("MainMenu");

    }
}
