using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capitulo7func : MonoBehaviour {
	public GameObject CambioCap9;
	public GameObject Toujeo8;
	//public GameObject Completado8;
	AudioSource Effecto;
	public GameObject luzeffect;
	public GameObject FlechaBlanca;
	public GameObject FlechaAzul;
	public Animator Luz;
	public GameObject textos7;
	private float Tiempocap7func = 18f;
	private bool tiempo77 = true;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		Tiempocap7func -= Time.deltaTime;
		if (Tiempocap7func <= 0 && tiempo77) {
		Effecto = GetComponent<AudioSource>();
		Effecto.PlayDelayed(0.0F);
		print ( "Si responde" );
		FlechaBlanca.SetActive (false);
		FlechaAzul.SetActive (true);
		luzeffect.SetActive (true);
		CambioCap9.SetActive (true);
		//	Completado8.SetActive (true);
		Luz.enabled = true;
		textos7.SetActive (true);
		tiempo77 = false;

		
	}
}
}
