using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Cambio_de_escena : MonoBehaviour {
	public string Escena_a_cargar;
	private float timer = 12f;
	private bool Menu = true;
	//private Text timerSeconds;


	// Use this for initialization
	void Start () 
	{
		//timerSeconds = GetComponent<Text> ();
	}

	// Update is called once per frame
	void Update () 
	{
		timer -= Time.deltaTime;
		//timerSeconds.text = timer.ToString("f0");
		if (timer <= 0 && Menu) 
		{
			Application.LoadLevel (Escena_a_cargar);
			Menu = false;
		}

	}
}﻿