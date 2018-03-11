using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioCapitulo_Lugar : MonoBehaviour {

	private float Escena2 = 25.4f;
	private bool Esc1 = true;
	Vector3 Capitulo2;


	void Start () {
		Capitulo2 = new Vector3 (-137,14,-12);
	}
	void Update () {
		Escena2 -= Time.deltaTime;
		Escena2.ToString("f0");
		if (Escena2 <= 0 && Esc1) 
		{
			transform.position=Capitulo2;
			Esc1 = false;
		}
	}
}