using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BotonPausa : MonoBehaviour {

	public bool pausado;
	public Transform MyPauseButton;
	public Time timescales;

	// Use this for initialization

	void Start () {	
	}
	
	// Update is called once per frame
	void Update () {

	}
	//Poner en pausa
		public void Pausar (){
				Time.timeScale = 0.000001f;
				pausado = true;
				MyPauseButton.GetComponentInChildren<Text> ().text = "Resumir";
				Button btn = MyPauseButton.GetComponent<Button> ();
				AudioListener.pause = true;
				//Debug.Log(" yes nigga");
				btn.onClick.AddListener (Resumir);
			}
		public void Resumir (){
				Time.timeScale = 1f;
				pausado = false;
				MyPauseButton.GetComponentInChildren<Text> ().text = "Pausar";
				Button btn = MyPauseButton.GetComponent<Button> ();
				AudioListener.pause = false;
				//Debug.Log(" no nigga");
				btn.onClick.AddListener (Pausar);
		}
		}