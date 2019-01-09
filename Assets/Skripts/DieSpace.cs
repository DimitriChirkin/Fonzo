using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieSpace : MonoBehaviour {
    public GameObject respavn;
    public Camera camera;
    void OnTriggerEnter2D (Collider2D other) 
    {if (other.tag == "Player")
            other.transform.position = respavn.transform.position;
        camera.transform.position=new Vector3(130.9f, 24.8f,-10f);
     }
}
