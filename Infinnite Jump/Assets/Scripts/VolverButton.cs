using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VolverButton : MonoBehaviour {
   public  Button btn;
	// Use this for initialization
	void Start () {
        
        btn.onClick.AddListener(Volver);
	}
	
	// Update is called once per frame
	void Volver() {
        SceneManager.LoadScene("MainMenu");
	}
}
