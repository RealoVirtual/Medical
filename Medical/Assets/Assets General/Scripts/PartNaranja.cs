using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartNaranja : MonoBehaviour {
	public GameObject ActivadorN;
	private bool PartN = true;

	void Update () {
		if (PartN) 
		{
			ActivadorN.SetActive (true);
			PartN = false;
		}
	}
}