using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RA2 : MonoBehaviour {

	//Variables y parametros del script \bool variable verdadero o falso \float variable de tiempo en numero enteros
	private float TRA2 = 197f;
	private bool Titulo1 = true;
	private bool intro11 = true;
	private bool intro22 = true;
	private bool intro33 = true;
	private bool paso1 = true;
	private bool paso2 = true;
	private bool paso3 = true;
	private bool paso4 = true;
	private bool paso5 = true;
	private bool paso6 = true;
	private bool basu6 = true;
	private bool paso65 = true;
	private bool apruebade =true;
	private bool creditos = true;
	private bool menura2 = true;
	public AudioSource Tituloau;
	public AudioSource Intro1au;
	public AudioSource Intro2au;
	public AudioSource Intro3au;
	public AudioSource Intro4au;
	public AudioSource Intro5au;
	//public AudioSource Intro6au;
	public AudioSource PASO1;
	public AudioSource PASO21;
	public AudioSource PASO22;
	public AudioSource PASO31;
	public AudioSource PASO32;
	public AudioSource PASO41;
	public AudioSource PASO42;
	public AudioSource PASO43;
	public AudioSource PASO61;
	// Objectos Logicos a los cuales afectara el Script
	public GameObject Titulo;
	public GameObject Intro1;
	public GameObject Intro2;
	public GameObject Intro3;
	public GameObject Paso1;
	public GameObject Paso2;
	public GameObject Paso3;
	public GameObject Paso4;
	public GameObject Paso5;
	public GameObject Paso6;
	public GameObject Paso6titulo;
	public GameObject basurero;
	public GameObject Paso6text;
	public GameObject CreditosRa2;
	public GameObject LapizT;
	public GameObject Zooms;
	public GameObject Cam;
	public string Escena_menu2;
	public Animator LapizToujeoP;

	// La funcion update es llamada cada vez que ocurre un cambio

	void start (){
		LapizT.GetComponent<Animator> ();
	}
	void Update () {
		if (TRA2 <= 197 && Titulo1) {
			Titulo.SetActive (true);
			Tituloau.PlayDelayed(2.0F);
			//200 - 5s de duracion
			Titulo1 = false;
			print ("Introresp");
		}
		if (TRA2 <= 190 && intro11) {
			Intro1.SetActive (true);
			Intro1au.PlayDelayed(1.0F);
			Intro2au.PlayDelayed(4.0F);
			Intro3au.PlayDelayed(10.0F);
			Titulo.SetActive (false);
			//120 seg - 17s de duracion
			intro11 = false;
			print ("Introresp");
		}
		if (TRA2 <= 175 && intro22) {
			Intro1.SetActive (false);
			Intro2.SetActive (true);
			Intro4au.PlayDelayed(2.0F);
			//120 seg - 17s de duracion
			intro22 = false;
			print ("Introresp");
		}
		if (TRA2 <= 165 && intro33) {
			Intro2.SetActive (false);
			Intro3.SetActive (true);
			Intro5au.PlayDelayed(2.0F);
			//120 seg - 17s de duracion
			intro33 = false;
			print ("Introresp");
		}
		if (TRA2 <= 153 && apruebade) {
			LapizT.SetActive (true);
			LapizToujeoP.Play("none");
			Intro3.SetActive (false);
			apruebade = false;
			Zooms.SetActive (true);
			print ("Paso1responde");
		}

		TRA2 -= Time.deltaTime;
		if (TRA2 <= 150 && paso1) {
			Paso1.SetActive (true);
			//120 seg - 17s de duracion
			Cam.SetActive (true);
			LapizToujeoP.Play("destapar_lapiz_cap1");
			PASO1.PlayDelayed(8.0F);
			LapizT.SetActive (true);
			paso1 = false;
			print ("Paso1responde");
		}
		if (TRA2 <= 133 && paso2) {
			//103 - 18s de duraccion
			Paso2.SetActive (true);
			LapizToujeoP.Play("colocar_aguja_cap2");
			PASO21.PlayDelayed(5.0F);
			PASO22.PlayDelayed(11.0F);
			paso2 = false;
			Paso1.SetActive (false);
			print ("Paso2responde");
		}
		if (TRA2 <= 115 && paso3) {
			//85 - 37s DE DURACION
			LapizToujeoP.Play("none");
			Paso3.SetActive (true);
			PASO31.PlayDelayed(10F);
			PASO32.PlayDelayed(24.0F);
			paso3 = false;
			Paso2.SetActive (false);
			print ("Paso3responde");
		}
		if (TRA2 <= 78 && paso4) {
			//48 - 38s de duracion
			Paso4.SetActive (true);
			LapizToujeoP.Play("GiroDeDosis_cap4");
			PASO41.PlayDelayed(4F);
			PASO42.PlayDelayed(15F);
			PASO43.PlayDelayed(24F);
			paso4 = false;
			Paso3.SetActive (false);
			print ("Paso4responde");
		}
		if (TRA2 <= 40 && paso5) {
			Paso5.SetActive (true);
			paso5 = false;
			Paso4.SetActive (false);
			LapizT.SetActive (false);
			print ("Paso5responde");
		}
		if (TRA2 <= 30 && paso6) {
			// 20 seg duracion
			Paso5.SetActive (false);
			Paso6.SetActive (true);
			Cam.SetActive (false);
			LapizToujeoP.Play("cap6_sacar-aguja");
			PASO61.PlayDelayed(5F);
			LapizT.SetActive (true);
			paso6 = false;
			print ("Paso6responde");
		}
		if (TRA2 <= 19 && basu6) {
			//basu//
			basurero.SetActive (true);
			basu6 = false;
		}

		if (TRA2 <= 12 && paso65) {
			//basu//
		basurero.SetActive (false);
		LapizT.SetActive (false);
		Paso6text.SetActive (true);
		Paso6titulo.SetActive (false);
			paso65 = false;
		}

			
		if (TRA2 <= 5 && creditos) {
			//LapizT.SetActive (false);
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