using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarAudio6 : MonoBehaviour {
	public GameObject Musica6
;
	private void OnTriggerEnter()
	{
		//tiempofadeout99 -= Time.deltaTime;
		//tiempofadeout99.ToString("f0");
		//if (tiempofadeout99 <= 0) {
		Musica6.SetActive (true);
		//}
	}
}
