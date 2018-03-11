using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AniCap1 : MonoBehaviour 
{
	private float Mov2 = 11f;
	private bool Escena23 = true;
	public Animator Esce1;
	void Start () {
	}
	void Update () {
		Mov2 -= Time.deltaTime;
		Mov2.ToString("f0");
		if (Mov2 <= 0 && Escena23) 
		{
			Esce1.enabled = true;
			Escena23 = false;
		}
	}
}