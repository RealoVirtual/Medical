using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vozoff5 : MonoBehaviour {

	AudioSource myAudio;
	// Use this for initialization
	void Start () {

		myAudio = GetComponent<AudioSource>();
		myAudio.PlayDelayed(16F);

	}

	// Update is called once per frame
	void Update () {

	}
}

