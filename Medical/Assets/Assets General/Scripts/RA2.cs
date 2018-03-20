using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RA2 : MonoBehaviour {

	//Variables y parametros del script \bool variable verdadero o falso \float variable de tiempo en numero enteros
	private float TRA2 = 70f;
	private bool paso1 = true;
	private bool paso2 = true;
	private bool paso3 = true;
	private bool paso4 = true;
	private bool paso5 = true;
	private bool paso6 = true;
	private bool creditos = true;
	private bool menura2 = true;
	public AudioSource PASO1;
	public AudioSource PASO21;
	public AudioSource PASO22;

	// Objectos Logicos a los cuales afectara el Script
	public GameObject Paso1;
	public GameObject Paso2;
	public GameObject Paso3;
	public GameObject Paso4;
	public GameObject Paso5;
	public GameObject Paso6;
	public GameObject CreditosRa2;
	public GameObject LapizT;
	public string Escena_menu2;

	// La funcion update es llamada cada vez que ocurre un cambio
	void Update () {
		TRA2 -= Time.deltaTime;
		if (TRA2 <= 70 && paso1) {
			Paso1.SetActive (true);
			//PASO1 = GetComponent<AudioSource>();
			PASO1.PlayDelayed(8.0F);
			LapizT.SetActive (true);
			paso1 = false;
			print ("Paso1responde");
		}
		if (TRA2 <= 53 && paso2) {
			Paso2.SetActive (true);
			PASO21.PlayDelayed(5.0F);
			PASO22.PlayDelayed(11.0F);
			paso2 = false;
			Paso1.SetActive (false);
			print ("Paso2responde");
		}
		if (TRA2 <= 30 && paso3) {
			Paso3.SetActive (true);
			paso3 = false;
			Paso2.SetActive (false);
			print ("Paso3responde");
		}
		if (TRA2 <= 30 && paso4) {
			Paso4.SetActive (true);
			paso4 = false;
			Paso3.SetActive (false);
			print ("Paso4responde");
		}
		if (TRA2 <= 30 && paso5) {
			Paso5.SetActive (true);
			paso5 = false;
			Paso4.SetActive (false);
			LapizT.SetActive (false);
			print ("Paso5responde");
		}
		if (TRA2 <= 20 && paso6) {
			Paso6.SetActive (true);
			LapizT.SetActive (true);
			paso6 = false;
			Paso5.SetActive (false);
			print ("Paso6responde");
		}
		if (TRA2 <= 10 && creditos) {
			LapizT.SetActive (false);
			CreditosRa2.SetActive (true);
			creditos = false;
			Paso6.SetActive (false);
			print ("Creditosresponde");
		}
		if (TRA2 <= 0 && menura2) {
			menura2 = false;
			Application.LoadLevel (Escena_menu2);
			print ("VueltaMenu");
		}
	}
}