using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateTiro2 : MonoBehaviour {


	public Rigidbody tiro2;
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
			Atirar2 ();
		} else {
			atirou = false;
		}

	}


	void Atirar2(){
		Rigidbody rb;
		rb = Instantiate (tiro2, new Vector3 (-62.286f,1.706f,-28.869f), Quaternion.identity);
		rb.velocity = transform.TransformDirection (Vector3.right * 15);

	}
	public void RecargaTiro(){
		recarga = 1.5f;
	}
}
