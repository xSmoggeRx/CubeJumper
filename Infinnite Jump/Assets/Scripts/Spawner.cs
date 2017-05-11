using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    public  GameObject platform;
    private int cont = 2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public  void Instanciar(string name)
    {
        GameObject a =Instantiate(platform, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
        a.name = name;
    }
}
