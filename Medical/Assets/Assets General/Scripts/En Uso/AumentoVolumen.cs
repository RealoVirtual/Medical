using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AumentoVolumen : MonoBehaviour {

	private float TimeV = 20;
	private bool Crono1 = true;
	private bool Crono2 = true;
	private bool Crono3 = true;
	private bool Crono4 = true;
	private bool Crono5 = true;
	private bool Crono6 = true;
	private bool Crono7 = true;
	private bool Crono8 = true;
	private bool Crono9 = true;
	private bool Crono10 = true;
	private bool Crono11 = true;
	private bool Crono12 = true;
	private bool Crono13 = true;
	private bool Crono14 = true;
	private bool Crono15 = true;
	private bool Crono16 = true;
	private bool Crono17 = true;
	private bool Crono18 = true;
	private bool Crono19 = true;
	private bool Crono20 = true;
	AudioSource Ambiente6;

	void Update () {
		TimeV -= Time.deltaTime;
		//TimeV.ToString("14");
		if (TimeV <= 20 && Crono1) 
		{
			Ambiente6 = GetComponent<AudioSource> ();
			Ambiente6.volume = 0.01f;
			Debug.Log("itworks");
			Crono1 = false;
		}
		if (TimeV <= 19 && Crono2) 
		{
			Ambiente6 = GetComponent<AudioSource> ();
			Ambiente6.volume = 0.02f;
			Debug.Log("itworks2");
			Crono2 = false;
		}
		if (TimeV <= 18 && Crono3) 
		{
			Ambiente6 = GetComponent<AudioSource> ();
			Ambiente6.volume = 0.03f;
			Debug.Log("itworks");
			Crono3 = false;
		}
		if (TimeV <= 17 && Crono4) 
		{
			Ambiente6 = GetComponent<AudioSource> ();
			Ambiente6.volume = 0.05f;
			Debug.Log("itworks");
			Crono4 = false;
		}
		if (TimeV <= 16 && Crono5) 
		{
			Ambiente6 = GetComponent<AudioSource> ();
			Ambiente6.volume = 0.06f;
			Debug.Log("itworks");
			Crono5 = false;
		}
		if (TimeV <= 15 && Crono6) 
		{
			Ambiente6 = GetComponent<AudioSource> ();
			Ambiente6.volume = 0.07f;
			Debug.Log("itworks");
			Crono6 = false;
		}
		if (TimeV <= 14 && Crono7) 
		{
			Ambiente6 = GetComponent<AudioSource> ();
			Ambiente6.volume = 0.08f;
			Debug.Log("itworks");
			Crono7 = false;
		}
		if (TimeV <= 13 && Crono8) 
		{
			Ambiente6 = GetComponent<AudioSource> ();
			Ambiente6.volume = 0.09f;
			Debug.Log("itworks");
			Crono8 = false;
		}
		if (TimeV <= 12 && Crono9) 
		{
			Ambiente6 = GetComponent<AudioSource> ();
			Ambiente6.volume = 0.1f;
			Debug.Log("itworks");
			Crono9 = false;
		}
		if (TimeV <= 11 && Crono10) 
		{
			Ambiente6 = GetComponent<AudioSource> ();
			Ambiente6.volume = 0.11f;
			Debug.Log("itworks");
			Crono10 = false;
		}
		if (TimeV <= 10 && Crono11) 
		{
			Ambiente6 = GetComponent<AudioSource> ();
			Ambiente6.volume = 0.12f;
			Debug.Log("itworks");
			Crono11 = false;
		}
		if (TimeV <= 9 && Crono12) 
		{
			Ambiente6 = GetComponent<AudioSource> ();
			Ambiente6.volume = 0.13f;
			Debug.Log("itworks");
			Crono12 = false;
		}
		if (TimeV <= 8 && Crono13) 
		{
			Ambiente6 = GetComponent<AudioSource> ();
			Ambiente6.volume = 0.14f;
			Debug.Log("itworks");
			Crono13 = false;
		}
		if (TimeV <= 7 && Crono14) 
		{
			Ambiente6 = GetComponent<AudioSource> ();
			Ambiente6.volume = 0.15f;
			Debug.Log("itworks");
			Crono14 = false;
		}
		if (TimeV <= 6 && Crono15) 
		{
			Ambiente6 = GetComponent<AudioSource> ();
			Ambiente6.volume = 0.15f;
			Debug.Log("itworks");
			Crono15 = false;
		}
		if (TimeV <= 5 && Crono16) 
		{
			Ambiente6 = GetComponent<AudioSource> ();
			Ambiente6.volume = 0.15f;
			Debug.Log("itworks");
			Crono16 = false;
		}
		if (TimeV <= 4 && Crono17) 
		{
			Ambiente6 = GetComponent<AudioSource> ();
			Ambiente6.volume = 0.15f;
			Debug.Log("itworks");
			Crono17 = false;
		}
		if (TimeV <= 3 && Crono18) 
		{
			Ambiente6 = GetComponent<AudioSource> ();
			Ambiente6.volume = 0.15f;
			Debug.Log("itworks");
			Crono18 = false;
		}
		if (TimeV <= 2 && Crono19) 
		{
			Ambiente6 = GetComponent<AudioSource> ();
			Ambiente6.volume = 0.15f;
			Debug.Log("itworks");
			Crono19 = false;
		}
		if (TimeV <= 1 && Crono20) 
		{
			Ambiente6 = GetComponent<AudioSource> ();
			Ambiente6.volume = 0.15f;
			Debug.Log("itworks");
			Crono20 = false;
		}
	}
}