//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class AudioCap2 : MonoBehaviour {

	AudioSource myAudio;
	// Use this for initialization
	void Start () {

		myAudio = GetComponent<AudioSource>();
		myAudio.PlayDelayed(25.9F);

	}

	// Update is called once per frame
	void Update () {

	}
}
