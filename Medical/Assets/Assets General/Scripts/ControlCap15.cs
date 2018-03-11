using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCap15 : MonoBehaviour {

	public GameObject ControlpadLeft;
	public GameObject ControlpadRight;
	//private float Capitulo7D = 3f;
	private bool Escena15 = true;

	//public VRTK.VRTK_TouchpadControl Control ;
	void Start () {
		if (Escena15) 
		{	ControlpadLeft.GetComponent<VRTK.VRTK_TouchpadControl>().enabled = false;
			ControlpadRight.GetComponent<VRTK.VRTK_TouchpadControl>().enabled = false;
			//Capitulo6S.SetActive (false);
			Escena15 = false;
	}

}
}
