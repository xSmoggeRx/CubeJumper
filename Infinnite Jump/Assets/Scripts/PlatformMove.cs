using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour {
    public float min = 2f;
    public float max = 3f;
    public float recorrido = 3;
    public float velocidad = 8;
    bool empiezaizq = true;

    GameObject derrota;
    // Use this for initialization
    void Start()
    {
        derrota = GameObject.Find("Derrota");
        min = -4.69f;
        max = 4.57f;
        if (transform.position.x < 0)
        {
            empiezaizq = true;
        }
        else
        {
            empiezaizq = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (empiezaizq)
        {
            transform.position = new Vector3(Mathf.PingPong(Time.time * velocidad, max - min) + min, transform.position.y, transform.position.z);
        }
        else
        {
            transform.position = new Vector3(-Mathf.PingPong(Time.time * velocidad, max - min) + max, transform.position.y, transform.position.z);
        }
        //mueve de derecha a izq

        if (transform.position.y <derrota.transform.position.y)
        {
            Destroy(this.gameObject);
        }


    }

}
