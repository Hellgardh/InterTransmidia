using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TiroController : MonoBehaviour {



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Destroy (gameObject, 0.5f);
	}

	void OnTriggerEnter(Collider col){
		if (col.gameObject.CompareTag ("Player")){
			
			Destroy (gameObject);
			SceneManager.LoadScene ("GameOver");

		}

		Destroy (gameObject);
	}
}
