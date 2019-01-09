using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlAudio : MonoBehaviour {
    public AudioClip Butt;
    // Use this for initialization
    public void Clip()
    {
        AudioSource.PlayClipAtPoint(Butt, transform.position);   
    }
}
