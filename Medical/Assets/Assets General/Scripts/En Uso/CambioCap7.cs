using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioCap7 : MonoBehaviour {

	//private bool Escena7 = true;
	//private bool Escena8 = false;
	//public GameObject ControlpadLeft;
	//public GameObject ControlpadRight;
	public GameObject Capitulo6S;
	private float Capitulo7D = 0f;
	//private bool Escena78 = true;
	private bool Escena79 = true;

	//public VRTK.VRTK_TouchpadControl Control ;
	void Start () {
		Capitulo7D -= Time.deltaTime;
		if (Capitulo7D <= 0 && Escena79) 
		{	Capitulo6S.SetActive (false);
			Escena79 = false;
		}
	}
}
