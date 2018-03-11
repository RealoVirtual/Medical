using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fadein10 : MonoBehaviour {

	private float tiempofadein10 = 5f;
	private bool Tfadecap10 = true;
	private bool cap9 = true;
	public GameObject FadeIn10;
	public GameObject Escena10;
	// Use this for initialization
	void Start () {


	}

	// Update is called once per frame
	void Update () {
		tiempofadein10 -= Time.deltaTime;
		if (tiempofadein10 <= 0 && Tfadecap10) {
			FadeIn10.SetActive (true);
			Tfadecap10 = false;
			print ("funcionactm");
		}
		if (tiempofadein10 <= 3 && cap9) {
			Escena10.SetActive (true);
			cap9 = false;
			print ("funcionactm2");
		}
	}
}