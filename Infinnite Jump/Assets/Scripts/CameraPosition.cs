using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPosition : MonoBehaviour {
    public GameObject player;
    public GameObject spawner1;
    public GameObject spawner2;
    int cont = 1;
    int namecont = 2;
	// Use this for initialization
	void Start () {
        Spawner sp1 = spawner1.GetComponent<Spawner>();
        Spawner sp2 = spawner2.GetComponent<Spawner>();
        sp1.Instanciar(namecont+"");
        namecont++;
        sp2.Instanciar(namecont+"");
        namecont++;
    }
	
	// Update is called once per frame
	void Update () {
        if (player.transform.position.y>transform.position.y)
        {
            
            transform.position = new Vector3(transform.position.x, player.transform.position.y, transform.position.z);
           
        }
        if (transform.position.y> 6*cont)
        {
            
            Spawner sp1 = spawner1.GetComponent<Spawner>();
            Spawner sp2 = spawner2.GetComponent<Spawner>();
            sp1.Instanciar(namecont+"");
            namecont++;
            sp2.Instanciar(namecont+"");
            namecont++;
            cont++;
        }

    }
}
