using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioCapitulo4 : MonoBehaviour {

	private float Escena4 = 34.9f;
	private bool Esc2 = true;
	Vector3 Capitulo4;


	void Start () {
		Capitulo4 = new Vector3 (38,19,35);
	}
	void Update () {
		Escena4 -= Time.deltaTime;
		Escena4.ToString("f0");
		if (Escena4 <= 0 && Esc2) 
		{
			transform.position=Capitulo4;
			Esc2 = false;
		}
	}
}