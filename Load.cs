using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Load : MonoBehaviour {
    public Slider slide;
    public float timer;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if((timer >= 0)&&(timer<=0.5)){
            slide.value = 10;
        }
        if ((timer >= 0.5) && (timer <= 1)){
            slide.value = 20;
        }
        if ((timer >= 1) && (timer <= 1.5)){
            slide.value = 30;
        }
        if ((timer >= 1.5) && (timer <= 2))
        {
            slide.value = 40;
        }
        if ((timer >= 2.5) && (timer <= 3))
        {
            slide.value = 50;
        }
        if ((timer >= 3.5) && (timer <= 5))
        {
            slide.value = 90;
        }
        if ((timer >= 5) && (timer <= 5.1))
        {
            slide.value = 100;
        }
        if (timer >= 5.1) 
        {
            Application.LoadLevel(2);
        }
    }
}
