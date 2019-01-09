using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarLvl1 : MonoBehaviour {
    public int n = 0;
    public GameObject starYellow;
    public GameObject starYellow1;
    public GameObject starYellow2;

    void Start () {
        if (PlayerPrefs.GetFloat("Lvl1rec") < 50f)
        {
            n = 3;
        }
        else
        if (PlayerPrefs.GetFloat("Lvl1rec") < 100f)
        {
            n = 2;
        }
        else
        if (PlayerPrefs.GetFloat("Lvl1rec") < 150f)
        {
            n = 1;
        }
        ShowStarsLvl1();

    }
    public void ShowStarsLvl1()
    {
        if (n == 3)
        {
            starYellow.SetActive(true);
            starYellow1.SetActive(true);
            starYellow2.SetActive(true);
        }
        else
        if (n == 2)
        {
            starYellow.SetActive(true);
            starYellow1.SetActive(true);
        }
        else
        if (n == 1)
        {
            starYellow.SetActive(true);
        }

    }

    void Update () {
		
	}
}
