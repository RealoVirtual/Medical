using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaderCap9 : MonoBehaviour {
	private EASYFader easyFader;
	private bool Tfadecap78 = true;
	private bool Tfadecap79 = true;
	private bool Tfadecap91 = true;
	private bool Tfadecap92 = true;
	private bool Tfadecap991 = true;
	private bool Tfadecap992 = true;
	private bool Tfadecap101 = true;
	private bool Tfadecap102 = true;
	public GameObject FadeOut78;
	public GameObject FadeIn78;
	public GameObject FadeOut9;
	public GameObject FadeIn9;
	public GameObject FadeOut999;
	public GameObject FadeIn999;
	public GameObject FadeOut10;
	public GameObject FadeIn10;

	//Use this for initialization
	void Start () {
		easyFader = MonoBehaviour.FindObjectOfType<EASYFader>();
		// Set the EASY Fader events
		easyFader.OnFadeInComplete( this.OnFadeInComplete );
		easyFader.OnFadeOutComplete( this.OnFadeOutComplete );
	}
	public void OnClickFadeIn() {
		easyFader.DoFadeIn();
	}
	public void OnClickFadeOut() {
		easyFader.DoFadeOut();
	}
	public void OnFadeInComplete() {
		Debug.Log( "EASFader Event => Fade-In Completed!" );
	}

	public void OnFadeOutComplete() {
		Debug.Log( "EASFader Event => Fade-Out Completed!" );
	}

	// Update is called once per frame
	void Update () {
		if (Tfadecap91 && FadeOut9.activeInHierarchy) {
			easyFader.DoFadeOut ();
			Tfadecap91 = false;
		}
		if (Tfadecap92 && FadeIn9.activeInHierarchy) {
			easyFader.DoFadeIn ();
			Tfadecap92 = false;

		}
		if (Tfadecap991 && FadeOut999.activeInHierarchy) {
			easyFader.DoFadeOut ();
			print ( "Si responde" );
			Tfadecap991 = false;
		}
		if (Tfadecap992 && FadeIn999.activeInHierarchy) {
			easyFader.DoFadeIn ();
			print ( "Cambio de capitulo" );
			Tfadecap992 = false;

		}
		if (Tfadecap101 && FadeOut10.activeInHierarchy) {
			easyFader.DoFadeOut ();
			print ( "Si responde10" );
			Tfadecap101 = false;
		}
		if (Tfadecap102 && FadeIn10.activeInHierarchy) {
			easyFader.DoFadeIn ();
			print ( "Cambio de capitulo10" );
			Tfadecap102 = false;

		}
		if (Tfadecap78 && FadeOut78.activeInHierarchy) {
			easyFader.DoFadeOut ();
			print ( "Si responde7" );
			Tfadecap78 = false;
		}
		if (Tfadecap79 && FadeIn78.activeInHierarchy) {
			easyFader.DoFadeIn ();
			print ( "Cambio de capitulo7" );
			Tfadecap79 = false;

		}

	}

}