using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Textos11 : MonoBehaviour {

		public GameObject Referencias1;

		private void Start()
		{
			StartCoroutine(ActivationRoutine());
		}

		private IEnumerator ActivationRoutine()
		{        
			//Wait for 14 secs.
			yield return new WaitForSeconds(0f);

			//Turn My game object that is set to false(off) to True(on).
			Referencias1.SetActive(true);

			//Turn the Game Oject back off after 1 sec.
			yield return new WaitForSeconds(20);

			//Game object will turn off
			Referencias1.SetActive(false);
		}
	}