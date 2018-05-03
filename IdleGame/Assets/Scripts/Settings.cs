using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour {

    Slider music;
    Slider sound;

    // Use this for initialization
    void Start() {
        music = GameObject.Find("MusicSlider").GetComponent<Slider>();
        sound = GameObject.Find("SoundSlider").GetComponent<Slider>();
    }

    public void onClick()
    {

    }

    // Update is called once per frame
    void Update () {
		
	}
}
