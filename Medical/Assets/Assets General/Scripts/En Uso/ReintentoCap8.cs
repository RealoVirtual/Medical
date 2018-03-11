using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReintentoCap8 : MonoBehaviour {

	private bool Intento1 = true;
	private bool Intento2 = true;
	public GameObject Resultado;
	public Animator Toujeo8;
	public GameObject Reintento;
	//public VRTK.VRTK_TouchpadControl Control ;
	void Start () {

	}
	void Update () {
		if (Intento1 && Toujeo8.enabled == false && Resultado ==false ) 
		{
			print ("Reintente nuevamente");
			Toujeo8.enabled = true;
			Intento1 = false;
		}
		if(Intento2 && Toujeo8.enabled == false && Resultado ==false ) 
		{
			print ("Limite De intentos Alcanzados");
			Reintento.SetActive (true);
			Intento2 = false;
		}
	}
}