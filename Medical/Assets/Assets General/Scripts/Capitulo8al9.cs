using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capitulo8al9 : MonoBehaviour {
	public GameObject CambioCap9;
	public GameObject Toujeo8;
	//public GameObject Completado8;
	AudioSource Effecto;
	public GameObject luzeffect;
	public GameObject FlechaBlanca;
	public GameObject FlechaAzul;
	public Animator Luz;
	public GameObject textos7;

	//public GameObject ToujeoChildren;
	//Vector3 Toujeo9;
	// Update is called once per frame
	//void Update () {
	 //if(transform.childCount > 1)
	void OnTriggerEnter (Collider ToujeoCapitulo8){
		if (ToujeoCapitulo8.tag == "Spheres"){
		//if (transform.position == Toujeo9)
		//if ( ToujeoChildren.transform.position == Toujeo9)
				// we have children!
			//Destroy(Toujeo8.GetComponent<Rigidbody>());
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
	}
}
}