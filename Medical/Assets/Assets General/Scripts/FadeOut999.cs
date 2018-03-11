using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOut999 : MonoBehaviour {


	private float tiempofadeout999 = 3f;
	private bool Tfadecap97 = true;
	public GameObject FadeOut9999;

	void Update () {
		tiempofadeout999 -= Time.deltaTime;
		tiempofadeout999.ToString("f0");
		if (tiempofadeout999 <= 0 && Tfadecap97) {
			FadeOut9999.SetActive (true);
			Tfadecap97 = false;
		}
	}
}

