using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grafico2 : MonoBehaviour {

	//public GameObject Jugador;
	//public Animator animacion9;
	//public RuntimeAnimatorController controles9y10;
	public GameObject Grafico3;
	public GameObject Grafico4;
	private float TiempoG1 = 10f;
	private bool TiempoG11 = true ;
	// Use this for initialization
	void Start () {
		//Animator animator = Jugador.gameObject.GetComponent<Animator>();
		//animator.runtimeAnimatorController = Resources.Load("path_to_your_controller") as RuntimeAnimatorController;
		//animator.runtimeAnimatorController = Resources.Load("FPSController.controller") as RuntimeAnimatorController;

		//animacion9.enabled = true;
		//animacion9.runtimeAnimatorController = controles9y10 as RuntimeAnimatorController;
		//print ("Cambio");

	}

	// Update is called once per frame
	void Update () {
		TiempoG1 -= Time.deltaTime;
		if (TiempoG1 <= 0 && TiempoG11) {
			Grafico4.SetActive (true);
			Grafico3.SetActive (false);
			TiempoG11 = false;
			print ("TerminoGraf2");
		}
	}
}