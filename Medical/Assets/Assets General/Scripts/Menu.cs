using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	public Animator animacion7;
	public GameObject botonReaccion;
	public GameObject Capitulo7func;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {

	}


	public void StartGame()
	{

		Application.LoadLevel(1);

	}

	public void Quit()
	{
		Application.Quit();
	}
	public void Restart()
	{
		Application.LoadLevel (Application.loadedLevel); 
	}
	public void Reaccion()
	{
		animacion7.enabled = true;
		Capitulo7func.SetActive (true);
		botonReaccion.SetActive (false);

	}
}