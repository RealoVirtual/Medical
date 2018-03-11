using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fadein78 : MonoBehaviour {


	private float tiempofadein78 = 14f;
	private bool Tfadecap788 = true;
	public GameObject FadeOut788;
	// Use this for initialization
	void Start () {


	}

	// Update is called once per frame
	void Update () {
		tiempofadein78 -= Time.deltaTime;
		if (tiempofadein78 <= 0 && Tfadecap788) {
			FadeOut788.SetActive (true);
			Tfadecap788 = false;
		}
	}
}