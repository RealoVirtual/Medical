using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desactiva6 : MonoBehaviour {
	public GameObject Cap666;
	public GameObject Luz6;
	private float TimeV = 2;
	private bool Escena6 = true;

	void update () {
		TimeV -= Time.deltaTime;
		if (TimeV <= 0 && Escena6 )
		{ Cap666.SetActive (false);
			Luz6.SetActive (false);
			print ("borrada");
		  Escena6 = false;
		}
	}
}
