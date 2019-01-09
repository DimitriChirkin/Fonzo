using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCam : MonoBehaviour {

    public GameObject player;
	
	
	void Update () {
    if (player.transform.position.x >149 && player.transform.position.x < 456.9)
        transform.position = new Vector3(player.transform.position.x,25f,-10f);

    }
}
