using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {
    public float timer;
    GUIStyle largeFont;

    void Start()
    {
        PlayerPrefs.SetFloat("Timer", 0);
        largeFont = new GUIStyle();

        largeFont.fontSize = 32;
    }


   

    void Update()
    {

        PlayerPrefs.SetFloat("Timer", PlayerPrefs.GetFloat("Timer") + Time.deltaTime);
        timer += Time.deltaTime;
        
    }

    void OnGUI()
    {
        GUI.Label(new Rect(Screen.width/20, Screen.height/20, Screen.width / 10, Screen.height / 10), PlayerPrefs.GetFloat("Timer").ToString("#.##"), largeFont);

    }

}
