using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateTiro : MonoBehaviour {

	public Rigidbody tiro;
	private bool atirou;
	private float tempo;
	private float recarga;


	// Use this for initialization
	void Start () {
		atirou = false;
		Rigidbody rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		tempo += Time.deltaTime;
		RecargaTiro ();
			if (tempo >= recarga ) {
				tempo = 0;
				atirou = true;
				Atirar1 ();
			} else {
				atirou = false;
			}

		}


	void Atirar1(){
		Rigidbody rb;
		rb = Instantiate (tiro, new Vector3 (-44.089f,1.971f,-23.805f ), Quaternion.identity);
		rb.velocity = transform.TransformDirection (Vector3.right * 15);

	}

	public void RecargaTiro(){
		recarga = 2.5f;
		}
}
