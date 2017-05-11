using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreUpdate : MonoBehaviour {
    Text texto;
	// Use this for initialization
	void Start () {
        texto = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        texto.text = PlayerPrefs.GetInt("puntuacion")+"";
	}
}
