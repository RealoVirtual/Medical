using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionCap2 : MonoBehaviour 
{
private float Mov2 = 54f;
private bool Escena23 = true;
	public Animator Esce;
	Vector3 Capitulo66;
	public GameObject PlayerVR;
	public GameObject ControlpadLeft;
	public GameObject ControlpadRight;
	//Vector3 rotacion;
void Start () {
		Capitulo66 = new Vector3 (174,19.259f,-37);
		//rotacion = new Vector3 (0, 0, 0);
}
void Update () {
	Mov2 -= Time.deltaTime;
	Mov2.ToString("f0");
		if (Mov2 <= 0 && Escena23) 
	{
			Esce.enabled = false;
			PlayerVR.transform.position=Capitulo66;
			PlayerVR.transform.Rotate (0, 0, 0);
			ControlpadLeft.GetComponent<VRTK.VRTK_TouchpadControl>().enabled = enabled;
			ControlpadRight.GetComponent<VRTK.VRTK_TouchpadControl>().enabled = enabled;
			print ("Cap6rightnigga");
			Escena23 = false;
			//print ("Cap6rightnigga");
	}
}
}