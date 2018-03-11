using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DescargarEscena : MonoBehaviour {
	public string Escena_toujeo;
	private bool Menu2 = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if ( Menu2)
			Application.UnloadLevel (Escena_toujeo);
			Menu2= false;
	}
}
