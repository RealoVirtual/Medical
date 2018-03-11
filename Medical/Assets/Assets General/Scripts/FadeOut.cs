using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOut : MonoBehaviour {


	private float tiempofadeout99 = 0f;
	private bool Tfadecap93 = true;
	public GameObject FadeOut9;

	void Update () {
		tiempofadeout99 -= Time.deltaTime;
		tiempofadeout99.ToString("f0");
		if (tiempofadeout99 <= 0 && Tfadecap93) {
			FadeOut9.SetActive (true);
			Tfadecap93 = false;
		}
	}
}

