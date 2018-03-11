using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioCapitulo : MonoBehaviour {
	private EASYFader easyFader;
	private float tiempofadeout = 25f;
	private float tiempofadein = 27f;
	private float tiempofadeout2 = 32f;
	private float tiempofadein2 = 38f;
	private float tiempofadeout3 = 50f;
	private float tiempofadein3 = 54f;
	private bool Tfade = true;
	private bool Tfade2 = true;
	private bool Tfade3 = true;
	private bool Tfade4 = true;
	private bool Tfade5 = true;
	private bool Tfade6 = true;

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
	tiempofadeout -= Time.deltaTime;
	tiempofadeout.ToString("f0");
		if (tiempofadeout <= 0 && Tfade) {
		easyFader.DoFadeOut ();
			Tfade = false;
	}
	tiempofadein -= Time.deltaTime;
	tiempofadein.ToString("f0");
		if (tiempofadein <= 0 && Tfade2) {
		easyFader.DoFadeIn ();
			Tfade2 = false;

	}
		tiempofadeout2 -= Time.deltaTime;
		tiempofadeout2.ToString("f0");
			if (tiempofadeout2 <= 0 && Tfade3) {
			easyFader.DoFadeOut ();
				Tfade3 = false;
	}
	tiempofadein2 -= Time.deltaTime;
	tiempofadein2.ToString("f0");
		if (tiempofadein2 <= 0 && Tfade4) {
		easyFader.DoFadeIn ();
			Tfade4 = false;
	}
		tiempofadeout3 -= Time.deltaTime;
		tiempofadeout3.ToString("f0");
		if (tiempofadeout3 <= 0 && Tfade5) {
			easyFader.DoFadeOut ();
			Tfade5 = false;
		}
	tiempofadein3 -= Time.deltaTime;
	tiempofadein3.ToString("f0");
	if (tiempofadein3 <= 0 && Tfade6) {
			easyFader.DoFadeIn ();
			Tfade6 = false;
		}

}

}		
	
	