using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveButtom : MonoBehaviour {

    public GameObject player;


    void Update()
    {
       
            transform.position = new Vector3(player.transform.position.x+420, player.transform.position.y+250, player.transform.position.z);

    }
}
