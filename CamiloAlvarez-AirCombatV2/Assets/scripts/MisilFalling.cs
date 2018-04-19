using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MisilFalling : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision collision){
		// Eliminamos el piso
		Destroy(collision.collider.gameObject);

	}
}
