using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour {
    public Button buttonPlay;
    public Button buttonCredits;
    public Button buttonExit;

	// Use this for initialization
	void Start () {
        buttonPlay.onClick.AddListener(PlayButton);
        buttonCredits.onClick.AddListener(CreditsButton);
        buttonExit.onClick.AddListener(ExitButton);
    }
	
	void PlayButton()
    {
        SceneManager.LoadScene("MainScene");
    }

    void CreditsButton()
    {
        SceneManager.LoadScene("Credits");

    }

    void ExitButton()
    {
        Application.Quit();
    }
}
