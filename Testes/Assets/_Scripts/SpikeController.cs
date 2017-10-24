using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeController : MonoBehaviour {

	public float Cooldown = 3;
	private float CooldownTimer;
	public GameObject Espinhos;


	void Start () {
		

	}


	void Update () {
		CooldownTimer += Time.deltaTime;

		if(CooldownTimer >= Cooldown){
			CooldownTimer = 0;



			if (Espinhos.activeInHierarchy) {
				Espinhos.SetActive (false);
			} else if (!Espinhos.activeInHierarchy) {
				Espinhos.SetActive (true);
			}
			
		}
	}
}
