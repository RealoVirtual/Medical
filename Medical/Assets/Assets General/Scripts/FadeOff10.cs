using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOff10 : MonoBehaviour {

	private float tiempofadein10 = 20f;
	private bool Tfadecap10 = true;
	public GameObject FadeIn10;
	// Use this for initialization
	void Start () {


	}

	// Update is called once per frame
	void Update () {
		tiempofadein10 -= Time.deltaTime;
		tiempofadein10.ToString("f0");
		if (tiempofadein10 <= 0 && Tfadecap10) {
			FadeIn10.SetActive (true);
			Tfadecap10 = false;
		}
	}
}