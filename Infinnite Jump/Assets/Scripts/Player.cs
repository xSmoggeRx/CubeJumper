using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public float fuerzaSalto;
    private bool esPosibleSaltar= true;
    private string lastPlatform="";
    public AudioClip jumpSound;
    AudioSource audio;
	// Use this for initialization
	void Start () {
        PlayerPrefs.SetInt("puntuacion",-1);
        audio = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))&& esPosibleSaltar)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0,fuerzaSalto));
            transform.parent = null;
            esPosibleSaltar = false;
            audio.PlayOneShot(jumpSound, 0.7f);

        }
        Debug.Log(PlayerPrefs.GetInt("puntuacion"));


    }
    
    void OntriggerStay2D(Collider2D coll)
    {
        esPosibleSaltar = true;
    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        esPosibleSaltar = true;
        transform.parent = coll.gameObject.transform;
        
       if (!coll.transform.parent.gameObject.name.Equals(lastPlatform))
        {
            PlayerPrefs.SetInt("puntuacion", PlayerPrefs.GetInt("puntuacion")+1);
        }
        lastPlatform = coll.transform.parent.gameObject.name;
    }

    void OnCollisionExit2D(Collision2D coll)
    {
        transform.parent = null;

    }
}
