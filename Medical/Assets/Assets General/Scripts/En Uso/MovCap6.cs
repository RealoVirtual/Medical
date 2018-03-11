using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovCap6 : MonoBehaviour {

	private bool Escena7 = true;
	public GameObject ScriptsVRTK;
	public Animator Player;
	public GameObject PlayerEscena6;
	//public VRTK.VRTK_TouchpadControl Control ;
	void Start () {

	}
	void Update () {
		if (Escena7 && Player.enabled == false && PlayerEscena6.activeInHierarchy) 
		{
			print ("funciona");
			ScriptsVRTK.SetActive (true);
			Escena7 = false;
		}
	}
}