using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esqueletoa7 : MonoBehaviour {
	public GameObject Cap777;
	public GameObject Capitulo6;
	private float TimeV = 14;
	private bool Escenaesqueleto = true;

	void update () {
		TimeV -= Time.deltaTime;
		if (TimeV <= 0 && Escenaesqueleto )
		{   Cap777.SetActive (true);
			Capitulo6.SetActive (false);
			print ("borradaypaso");
			Escenaesqueleto = false;
		}
	}
}
