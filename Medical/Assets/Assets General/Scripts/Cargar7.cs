using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cargar7 : MonoBehaviour {

	private float tiempofadein78 = 0f;
	private bool cambiocap788 = true;
	private bool cambiocap789 = true;
	public GameObject Cap7x;
	public GameObject Cap6x;
	public GameObject BottonReaccion;
	// Use this for initialization
	void Start () {


	}

	// Update is called once per frame
	void Update () {
		tiempofadein78 -= Time.deltaTime;
		if (tiempofadein78 <= 0 && cambiocap788) {
			Cap7x.SetActive (true);
			cambiocap788 = false;
			BottonReaccion.SetActive (true);
		}
		if (tiempofadein78 <= 0 && cambiocap789) {
			Cap6x.SetActive (false);
			cambiocap789 = false;
		}
	}
}