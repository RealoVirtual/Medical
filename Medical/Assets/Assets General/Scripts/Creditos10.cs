using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creditos10 : MonoBehaviour {

	private float Creditos = 3f;
	private bool Creditos1 = true;
	private bool Creditos2 = true;
	//private bool Difuminado67 = true;
	public GameObject Logo;
	public GameObject Texto;
	// Use this for initialization
	void Start () {


	}

	// Update is called once per frame
	void Update () {
		Creditos -= Time.deltaTime;
		if (Creditos <= 1 && Creditos1) {
			Logo.SetActive (false);
			Creditos1 = false;
		}
		if (Creditos <= 0 && Creditos2) {
			Texto.SetActive (true);
			Creditos2 = false;
		}
	}
}