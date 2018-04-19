using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour {

	public GameObject Misil;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Space))
		{
			GameObject misil = GameObject.Instantiate (Misil as GameObject);

			//GameObject misil = GameObject.Instantiate (Resources.Load ("Prefabs/Misil") as GameObject);

			//Hago que else misil sea hijo del avion 
			misil.transform.SetParent(this.transform);

			//Muevo el misil a la posicion 
			misil.transform.localPosition = new Vector3 (0f,0f,0f);

			// Saco al misil del avion 
			misil.transform.SetParent(null);
		}


		
	}
}
