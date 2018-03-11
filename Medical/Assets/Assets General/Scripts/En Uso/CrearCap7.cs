using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearCap7 : MonoBehaviour {

	private float Capitulo7C = 0f;
	private bool Escena77 = true;
	public GameObject Esce7;
	//Vector3 Capitulo7;
	//public GameObject Player;
	void Start () {
		//Capitulo7 = new Vector3 (-143.286f,-18.661f,105.424f);
	}
	void Update () {
		Capitulo7C -= Time.deltaTime;
		Capitulo7C.ToString("f0");
		if (Capitulo7C <= 0 && Escena77) 
		{
			Esce7.SetActive (true);
			//Player.transform.position=Capitulo7;
			Escena77 = false;
		}
		//if (Capitulo7C <= 0 && Escena77 ==false)
		//{Player.transform.position=Capitulo7;
	//}
}
}