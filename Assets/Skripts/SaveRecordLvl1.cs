using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SaveRecordLvl1 : MonoBehaviour {
    public float Score;
    public float Record;
  


    void OnTriggerEnter2D(Collider2D col)
    {  if (col.CompareTag("Player"))
        {
            Score = PlayerPrefs.GetFloat("Timer");
            if (Record - Score > 0)
            {
                PlayerPrefs.SetFloat("Lvl1rec", Score);
                PlayerPrefs.Save();
                Debug.Log("Save");
            }

        }
        PlayerPrefs.SetFloat("Lvl1Boost", 0);
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
      

        PlayerPrefs.SetFloat("LoadMenu", 1f);
 
        Record = PlayerPrefs.GetFloat("Lvl1rec");
    }
}
