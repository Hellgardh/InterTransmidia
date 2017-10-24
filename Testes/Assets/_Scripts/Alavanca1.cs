using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alavanca1 : MonoBehaviour {
		
	public Rigidbody alavanca;
		
	// Use this for initialization
	void Start () {
		Rigidbody rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col){

		if (col.gameObject.CompareTag ("Player")) {

			alavanca.velocity = transform.TransformDirection (Vector3.right * 2);
		    
		}
	}
}
