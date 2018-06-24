using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class MaxScore : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent <Text> ().text = PlayerPrefs.GetInt ("record").ToString();
	}
	
}
