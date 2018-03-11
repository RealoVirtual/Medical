using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VozOffCap7 : MonoBehaviour {

	AudioSource myAudio;
	// Use this for initialization
	void Start () {

		myAudio = GetComponent<AudioSource>();
		myAudio.PlayDelayed(5F);

	}

	// Update is called once per frame
	void Update () {

	}
}
