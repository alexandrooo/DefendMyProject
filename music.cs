﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music : MonoBehaviour {

	// Use this for initialization
	void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
       
    }
    void OnMouseDown() {
        AudioSource audioBackground = GetComponent<AudioSource>();
        audioBackground.mute = true;
        print(audioBackground.mute);
    }

}
