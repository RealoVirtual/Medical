using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.ImageEffects;

public class DifuminadoCapitulo6 : MonoBehaviour {


	private float Difuminado6 = 14f;
	private bool Difuminado66 = true;
	private bool Difuminado67 = true;
	public GameObject jugador;
	// Use this for initialization
	void Start () {


	}

	// Update is called once per frame
	void Update () {
		//Difuminado6 -= Time.deltaTime;
		if (Difuminado6 <= 14 && Difuminado66) {
			//jugador.GetComponent<DepthOfFieldDeprecated>() = true;
			//jugador.GetComponent<DepthOfFieldDeprecated> ;
			//DepthOfFieldDeprecated.Dof34QualitySetting.
			Difuminado66 = false;
		}
		if (Difuminado6 <= 0 && Difuminado67) {
			//jugador.GetComponent<DepthOfFieldDeprecated>() = false;

			Difuminado67 = false;
		}
	}
}