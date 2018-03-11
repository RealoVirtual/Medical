using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticulasNaranjas : MonoBehaviour {
	public GameObject Particula1;
	public GameObject Particula2;
	public GameObject Particula3;
	public GameObject FadeOutn999;
	private bool PartN1 = true;
	private bool PartN2 = true;
	private bool PartN3 = true;
	private bool PartN4 = true;
	private bool PartN5 = true;
	private float Tvida1 = 5f;
	private float Tvida2 = 10f;
	private float Tvida3 = 14f;
	void Update () {
		if (PartN1) 
		{
			Particula1.SetActive (true);
			PartN1 = false;
		}
		Tvida1 -= Time.deltaTime;
		Tvida1.ToString("f0");
		if (Particula1.activeInHierarchy && Tvida1 <= 0) {
			Particula1.SetActive (false);
			Particula2.SetActive (true);
			PartN2 = false;
		}
		Tvida2 -= Time.deltaTime;
		Tvida2.ToString("f0");
		if (Particula2.activeInHierarchy && Tvida2 <= 0) {
			Particula2.SetActive (false);
			Particula3.SetActive (true);
			PartN3 = false;
		}
		Tvida3 -= Time.deltaTime;
		Tvida3.ToString("f0");
		if (Particula3.activeInHierarchy && Tvida3 <= 0) {
			Particula3.SetActive (false);
			PartN4 = false;
		}
		if (PartN4 == false) {
			FadeOutn999.SetActive (true);
			PartN5 = false;
		}
	}
}