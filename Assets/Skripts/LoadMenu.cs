using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadMenu : MonoBehaviour {
    public GameObject StartMenu;
    public GameObject GameLvl;
    public GameObject Lvl1Starsblack1;
    public GameObject Lvl1Starsblack2;
    public GameObject Lvl1Starsblack3;
    public GameObject Lvl2Starsblack1;
    public GameObject Lvl2Starsblack2;
    public GameObject Lvl2Starsblack3;
    public GameObject Lvl3Starsblack1;
    public GameObject Lvl3Starsblack2;
    public GameObject Lvl3Starsblack3;
    public GameObject Lvl4Starsblack1;
    public GameObject Lvl4Starsblack2;
    public GameObject Lvl4Starsblack3;
    // Use this for initialization
    void Start () {
        if (PlayerPrefs.GetFloat("LoadMenu") == 1f)
        {
            StartMenu.SetActive(false);
            GameLvl.SetActive(true);
            Lvl1Starsblack1.SetActive(true);
            Lvl1Starsblack2.SetActive(true);
            Lvl1Starsblack3.SetActive(true);
            Lvl2Starsblack1.SetActive(true);
            Lvl2Starsblack2.SetActive(true);
            Lvl2Starsblack3.SetActive(true);
            Lvl3Starsblack1.SetActive(true);
            Lvl3Starsblack2.SetActive(true);
            Lvl3Starsblack3.SetActive(true);
            Lvl4Starsblack1.SetActive(true);
            Lvl4Starsblack2.SetActive(true);
            Lvl4Starsblack3.SetActive(true);
        }
        PlayerPrefs.SetFloat("LoadMenu", 0);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
