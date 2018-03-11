//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class VozOff : MonoBehaviour {

	AudioSource myAudio;
	// Use this for initialization
	void Start () {

		myAudio = GetComponent<AudioSource>();
		myAudio.PlayDelayed(2.0F);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
