using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoMisil : MonoBehaviour {


	public Transform Avion;
	public Rigidbody disparo;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		 

		if (Input.GetKeyDown (KeyCode.Space)) 
		{
//			Instantiate (Resources.Load ("Prefabs/Misil"), Avion.position);

		}
	}
}
