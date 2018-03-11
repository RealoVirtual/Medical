using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cronometro : MonoBehaviour {

	private float Cronometro1 = 150;
	private bool Crono = true;

	void Update () {
		Cronometro1 -= Time.deltaTime;
		Cronometro1.ToString("0");
		if (Cronometro1 >= 0 ) 
		{
			Debug.Log( Cronometro1.ToString(""));
		}
	}
}