﻿using UnityEngine.UI;
using UnityEngine;

public class GameSettings : MonoBehaviour {

    public Slider slider;
    public Text valueCount;
	void Start () {
		
	}
	
	
	void Update () {
        valueCount.text = slider.value.ToString();
        AudioListener.volume = slider.value;
	}
}
