﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssetsCap1 : MonoBehaviour {
	public GameObject objectToActivate;

	private void Start()
	{
		StartCoroutine(ActivationRoutine());
	}

	private IEnumerator ActivationRoutine()
	{        
		//Wait for 14 secs.
		yield return new WaitForSeconds(23);

		//Turn My game object that is set to false(off) to True(on).
		objectToActivate.SetActive(true);

		//Turn the Game Oject back off after 1 sec.
		yield return new WaitForSeconds(23);

		//Game object will turn off
		objectToActivate.SetActive(false);
	}
}