using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class luzeffect : MonoBehaviour {

	private float Tiempoefecto = 6f;
	private bool wave1 = true;
	private bool wave2 = true;
	private bool wave3 = true;
	private bool wave4 = true;
	private bool wave5 = true;
	private bool wave6 = true;
	public GameObject EfectoDeLuz;
	// Use this for initialization
	void Start () {


	}

	// Update is called once per frame
	void Update () {
		Tiempoefecto -= Time.deltaTime;
		if (Tiempoefecto <= 6 && wave1) {
			EfectoDeLuz.SetActive (true);
			wave1 = false;
		}
		if (Tiempoefecto <= 5 && wave2) {
			EfectoDeLuz.SetActive (false);
			wave2 = false;
		}
		if (Tiempoefecto <= 4 && wave3) {
			EfectoDeLuz.SetActive (true);
			wave3 = false;
		}
		if (Tiempoefecto <= 3 && wave4) {
			EfectoDeLuz.SetActive (false);
			wave4 = false;
		}
		if (Tiempoefecto <= 2 && wave5) {
			EfectoDeLuz.SetActive (true);
			wave5= false;
		}
		if (Tiempoefecto <= 1 && wave6) {
			EfectoDeLuz.SetActive (false);
			wave6= false;
		}
	}
}