using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fadein999 : MonoBehaviour {

	private float tiempofadein999 = 3f;
	private bool Tfadecap96 = true;
	public GameObject FadeIn9999;
	// Use this for initialization
	void Start () {


	}

	// Update is called once per frame
	void Update () {
		tiempofadein999 -= Time.deltaTime;
		tiempofadein999.ToString("f0");
		if (tiempofadein999 <= 0 && Tfadecap96) {
			FadeIn9999.SetActive (true);
			Tfadecap96 = false;
		}
	}
}