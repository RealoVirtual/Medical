using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimaTcap7 : MonoBehaviour {
	//public Animator ToujeoB;
	//public GameObject ParticulaT;
	public GameObject FlechaToujeo;
	public GameObject FlechaBlanca;

	private void OnTriggerEnter(){
		//if (Input.GetButton ("GripPress") && GetComponent<Rigidbody> ())
	{	//ParticulaT.AddComponent<Rigidbody>() ;
		//ToujeoB.enabled = false;
		FlechaToujeo.SetActive (false);
		FlechaBlanca.SetActive (true);
		print ("Tomada");

	}
}
}