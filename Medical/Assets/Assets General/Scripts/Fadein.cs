using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fadein : MonoBehaviour {

	private float tiempofadein99 = 0f;
	private bool Tfadecap93 = true;
	public GameObject FadeIn;
	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {
		tiempofadein99 -= Time.deltaTime;
		tiempofadein99.ToString("f0");
		if (tiempofadein99 <= 0 && Tfadecap93) {
			FadeIn.SetActive (true);
			Tfadecap93 = false;
	}
}
}
