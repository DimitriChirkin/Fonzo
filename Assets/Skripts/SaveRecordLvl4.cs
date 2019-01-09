using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SaveRecordLvl4 : MonoBehaviour
{
    public float ScoreLvl2;
    public float RecordLvl2;
    public float timerLvl2;


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            ScoreLvl2 = timerLvl2;
            if (RecordLvl2 - ScoreLvl2 > 0)
            {
                PlayerPrefs.SetFloat("Lvl4rec", ScoreLvl2);
                PlayerPrefs.Save();
                Debug.Log("Save");
            }

        }
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timerLvl2 < 99999.0f)
        {
            timerLvl2 += Time.deltaTime;
        }

        PlayerPrefs.SetFloat("LoadMenu", 1f);
        RecordLvl2 = PlayerPrefs.GetFloat("Lvl4rec");
    }
}
