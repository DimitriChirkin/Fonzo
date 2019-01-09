using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarLvl4 : MonoBehaviour
{
    public int n = 0;
    public GameObject starYellow11;
    public GameObject starYellow1111;
    public GameObject starYellow211;

    void Start()
    {
        if (PlayerPrefs.GetFloat("Lvl4rec") < 200f)
        {
            n = 3;
        }
        else
        if (PlayerPrefs.GetFloat("Lvl4rec") < 300f)
        {
            n = 2;
        }
        else
        if (PlayerPrefs.GetFloat("Lvl4rec") < 500f)
        {
            n = 1;
        }
        ShowStarsLvl4();

    }
    public void ShowStarsLvl4()
    {
        if (n == 3)
        {
            starYellow11.SetActive(true);
            starYellow1111.SetActive(true);
            starYellow211.SetActive(true);
        }
        else
        if (n == 2)
        {
            starYellow11.SetActive(true);
            starYellow1111.SetActive(true);
        }
        else
        if (n == 1)
        {
            starYellow211.SetActive(true);
        }

    }

    void Update()
    {

    }
}
