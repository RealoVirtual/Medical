using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioCreditos : MonoBehaviour {

	public GameObject Encadena;

	private void Start()
	{
		StartCoroutine(ActivationRoutine());
	}

	private IEnumerator ActivationRoutine()
	{        
		//Wait for 14 secs.
		yield return new WaitForSeconds(19);

		//Turn My game object that is set to false(off) to True(on).
		Encadena.SetActive(true);

		//Turn the Game Oject back off after 1 sec.
		yield return new WaitForSeconds(9);

		//Game object will turn off
		Encadena.SetActive(false);
	}
}