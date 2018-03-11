using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAni : MonoBehaviour {
	//public GameObject Jugador;
	public Animator animacion6;
	public RuntimeAnimatorController cap67;
	//public GameObject Player;
	// Use this for initialization
	void Start () {
		//Animator animator = Jugador.gameObject.GetComponent<Animator>();
		//animator.runtimeAnimatorController = Resources.Load("path_to_your_controller") as RuntimeAnimatorController;
		//animator.runtimeAnimatorController = Resources.Load("FPSController.controller") as RuntimeAnimatorController;
		animacion6.enabled = true;
		animacion6.runtimeAnimatorController = cap67 as RuntimeAnimatorController;
		print ("it works");

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
