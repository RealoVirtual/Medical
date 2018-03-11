using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Borrarcap9 : MonoBehaviour {
	public GameObject Capitulo9S;
	private float Capitulo9D = 3f;
	private bool Escena9 = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Capitulo9D -= Time.deltaTime;
		if (Capitulo9D <= 0 && Escena9) 
		{	Capitulo9S.SetActive (false);
			Escena9 = false;
		}
	}
}
