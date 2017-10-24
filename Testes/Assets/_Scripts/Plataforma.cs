using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour {

	public GameObject[] locais;
	public bool comecarInvertido;
	public bool reiniciar;
	private bool inverter = false;
	public int destinoInicial = 0;
	public float velocidade = 10;
	private int localAtual = 0;


	// Use this for initialization
	void Start () {
		if (destinoInicial < locais.Length) {
			localAtual = destinoInicial;
		} else {
			localAtual = 0;
		}

		if (comecarInvertido == true) {
			inverter = !inverter;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (inverter == false) {
			if (Vector3.Distance (transform.position, locais[localAtual].transform.position) < 0.1f) {
				if (localAtual < locais.Length-1) {
					localAtual++;
				} else {
					if (reiniciar == true) {
						localAtual = 0;
					} else {
						inverter = true;
					}
				}
			} transform.position = Vector3.MoveTowards (transform.position, locais[localAtual].transform.position, velocidade * Time.deltaTime);
		} else {
			if (inverter == true) {
				if (Vector3.Distance (transform.position, locais [localAtual].transform.position) < 0.1f) {
					if (localAtual > 0) {
						localAtual--;
					} else {

						if (reiniciar == true) {
							localAtual = locais.Length-1;
						} else {
							inverter = false;
						}
					}

				}transform.position = Vector3.MoveTowards (transform.position, locais[localAtual].transform.position, velocidade * Time.deltaTime);
			}
		}
	}
}
