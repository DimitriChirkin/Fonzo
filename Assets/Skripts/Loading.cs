using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loading : MonoBehaviour {
    public float timer;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;
    // Use this for initialization
    void Start () {
        if (PlayerPrefs.GetFloat("Loading") == 1)
        {
            text1.SetActive(true);
        }
        if (PlayerPrefs.GetFloat("Loading") == 2)
        {
            text2.SetActive(true);
        }

        if (PlayerPrefs.GetFloat("Loading") == 3)
        {
            text3.SetActive(true);
          
        }
        if (PlayerPrefs.GetFloat("Loading") == 4)
        {
            text4.SetActive(true);
        }
        }
	
	// Update is called once per frame
	void Update () {
        if (timer < 5.0f)
        {
            timer += Time.deltaTime;
        }
        else
            if (PlayerPrefs.GetFloat("Loading") == 1)
        {
            text1.SetActive(true);
            Application.LoadLevel("Lvl1");
        }

        else
                    if (PlayerPrefs.GetFloat("Loading") == 2)
        {
            text2.SetActive(true);
            Application.LoadLevel("Lvl2");
        }
        else

                            if (PlayerPrefs.GetFloat("Loading") == 3)
        {
            text3.SetActive(true);
            Application.LoadLevel("Lvl3");
        }

        else
                                    if (PlayerPrefs.GetFloat("Loading") == 4)
        {
            text4.SetActive(true);
            Application.LoadLevel("Lvl4");
        }
    }

}


