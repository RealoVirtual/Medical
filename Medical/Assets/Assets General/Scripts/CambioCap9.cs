using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioCap9 : MonoBehaviour {

	private float Capitulo9 = 6;
	private bool Esc9 = true;
	Vector3 Capitulo4;


	void Start () {
		Capitulo4 = new Vector3 (-4,3,1);
	}
	void Update () {
		Capitulo9 -= Time.deltaTime;
		Capitulo9.ToString("f0");
		if (Capitulo9 <= 0 && Esc9) 
		{
			transform.position=Capitulo4;
			Esc9 = false;
		}
	}
}