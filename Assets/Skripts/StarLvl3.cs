using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarLvl3 : MonoBehaviour
{
    public int n = 0;
    public GameObject starYellow;
    public GameObject starYellow1;
    public GameObject starYellow2;

    void Start()
    {
        if (PlayerPrefs.GetFloat("Lvl3rec") < 120f)
        {
            n = 3;
        }
        else
        if (PlayerPrefs.GetFloat("Lvl3rec") < 150f)
        {
            n = 2;
        }
        else
        if (PlayerPrefs.GetFloat("Lvl3rec") < 200f)
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

    void Update()
    {

    }
}
