using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarScript : MonoBehaviour {

	public GameObject Capitulo7Enter;
	private float tiempofadeout777 = 7f;
	private bool Escena777 = true;
	void Start () {
	}
	void Update () {
		tiempofadeout777 -= Time.deltaTime;
		if (tiempofadeout777 <= 0 && Escena777) 
		{	Capitulo7Enter.SetActive (true);
			Escena777 = false;
		}
	}
}