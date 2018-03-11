using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fadera78 : MonoBehaviour {


	private float tiempofadeout78 = 10f;
	private bool Tfadecap78 = true;
	public GameObject FadeOut78;
	// Use this for initialization
	void Start () {


	}

	// Update is called once per frame
	void Update () {
		tiempofadeout78 -= Time.deltaTime;
		if (tiempofadeout78 <= 0 && Tfadecap78) {
			FadeOut78.SetActive (true);
			Tfadecap78 = false;
		}
	}
}