using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tIME : MonoBehaviour {

    public int i;
    public GameObject time;
   
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {

                
             
                PlayerPrefs.SetFloat("Timer", PlayerPrefs.GetFloat("Timer") - i);
                PlayerPrefs.Save();
                Debug.Log("Save");

                time.SetActive(false);

               

        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
