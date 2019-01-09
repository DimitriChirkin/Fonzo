using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMenu : MonoBehaviour {
    public GameObject StartMenu;
    public GameObject GameLvl;
    public GameObject ExitShure;
    public GameObject Stars;
    public GameObject Stars1;
    public GameObject Stars2;
    public GameObject Stars3;

    public GameObject Lvl1Starsyellow1;
    public GameObject Lvl1Starsyellow2;
    public GameObject Lvl1Starsyellow3;
    public GameObject Lvl2Starsyellow1;
    public GameObject Lvl2Starsyellow2;
    public GameObject Lvl2Starsyellow3;
    public GameObject Lvl3Starsyellow1;
    public GameObject Lvl3Starsyellow2;
    public GameObject Lvl3Starsyellow3;
    public GameObject Lvl4Starsyellow1;
    public GameObject Lvl4Starsyellow2;
    public GameObject Lvl4Starsyellow3;

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
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void ShowLvlMenu() 
    {
        StartMenu.SetActive(false);
        GameLvl.SetActive(true);
        Stars.SetActive(true);
        Stars1.SetActive(true);
        Stars2.SetActive(true);
        Stars3.SetActive(true);
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
    public void ShowMenu()
    {
        StartMenu.SetActive(true);
        GameLvl.SetActive(false);
        Stars.SetActive(false);
        Stars1.SetActive(false);
        Stars2.SetActive(false);
        Stars3.SetActive(false);
        ExitShure.SetActive(false);

        Lvl1Starsblack1.SetActive(false);
        Lvl1Starsblack2.SetActive(false);
        Lvl1Starsblack3.SetActive(false);
        Lvl2Starsblack1.SetActive(false);
        Lvl2Starsblack2.SetActive(false);
        Lvl2Starsblack3.SetActive(false);
        Lvl3Starsblack1.SetActive(false);
        Lvl3Starsblack2.SetActive(false);
        Lvl3Starsblack3.SetActive(false);
        Lvl4Starsblack1.SetActive(false);
        Lvl4Starsblack2.SetActive(false);
        Lvl4Starsblack3.SetActive(false);
    }
    public void ExiteGame()
    {
        Application.Quit();
    }
    public void ShowExit()
    {
        StartMenu.SetActive(false);
        ExitShure.SetActive(true);
    }
    public void StartLvl1()
    {
        PlayerPrefs.SetFloat("Loading", 1f);
        Application.LoadLevel("Loading");
        
    }
    public void StartLvl2()
    {
        PlayerPrefs.SetFloat("Loading", 2f);
        Application.LoadLevel("Loading");
    }
    public void StartLvl3()
    {
        PlayerPrefs.SetFloat("Loading", 3f);
        Application.LoadLevel("Loading");
    }
    public void StartLvl4()
    {
        PlayerPrefs.SetFloat("Loading", 4f);
        Application.LoadLevel("Loading");
    }
    public void Reset()

    {


        PlayerPrefs.DeleteAll();
        PlayerPrefs.SetFloat("Lvl1rec", 100000f);
        PlayerPrefs.SetFloat("Lvl2rec", 100000f);
        PlayerPrefs.SetFloat("Lvl3rec", 100000f);
        PlayerPrefs.SetFloat("Lvl4rec", 100000f);
        Stars.SetActive(false);
        Stars1.SetActive(false);
        Stars2.SetActive(false);
        Stars3.SetActive(false);
        Lvl1Starsyellow1.SetActive(false);
        Lvl1Starsyellow2.SetActive(false);
        Lvl1Starsyellow3.SetActive(false);
        Lvl2Starsyellow1.SetActive(false);
        Lvl2Starsyellow2.SetActive(false);
        Lvl2Starsyellow3.SetActive(false);
        Lvl3Starsyellow1.SetActive(false);
        Lvl3Starsyellow2.SetActive(false);
        Lvl3Starsyellow3.SetActive(false);
        Lvl4Starsyellow1.SetActive(false);
        Lvl4Starsyellow2.SetActive(false);
        Lvl4Starsyellow3.SetActive(false);

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
}
