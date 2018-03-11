using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class scriptTimer : MonoBehaviour {

    public Text contador;
    //public Text fin;
    private float tiempo = 5f;
	//Use this for initialization
	void Start () {
        contador.text = " " + tiempo;
		//fin.enabled = true;	
	}
	
	// Update is called once per frame
	void Update () {
        tiempo -= Time.deltaTime;
        contador.text = " " + tiempo.ToString("f0");

        if(tiempo <= 0)
        {
            contador.text = "0";
        }
	
	}
}
