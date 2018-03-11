using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LugarCap999 : MonoBehaviour {

	//public GameObject Jugador;
	//public Animator animacion9;
	public RuntimeAnimatorController controles9y10;
	public GameObject Capitulo7;
	public GameObject Capitulo9;
	private float Tiempo7S = 0f;
	private bool Tiempo7ss = true ;
	// Use this for initialization
	void Start () {
		//Animator animator = Jugador.gameObject.GetComponent<Animator>();
		//animator.runtimeAnimatorController = Resources.Load("path_to_your_controller") as RuntimeAnimatorController;
		//animator.runtimeAnimatorController = Resources.Load("FPSController.controller") as RuntimeAnimatorController;
		Capitulo9.SetActive (true);
		//animacion9.enabled = true;
		//animacion9.runtimeAnimatorController = controles9y10 as RuntimeAnimatorController;
		print ("Cambio");

	}

	// Update is called once per frame
	void Update () {
		Tiempo7S -= Time.deltaTime;
		if (Tiempo7S <= 0 && Tiempo7ss) {
			Capitulo7.SetActive (false);
			Tiempo7ss = false;
			print ("TerminoCAP7");
		}
}
}