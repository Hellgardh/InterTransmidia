using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botoes : MonoBehaviour {

	private bool apertou = false;
	
	/*void Awake(){
		AudioSource audio = GetComponent<AudioSource> ();
		audio.Play (44100);
	}*/
	

	void Update () {
		
	}
		

	public void Iniciar(){

		SceneManager.LoadScene ("Main");
		apertou = true;
		/*if (apertou == true) {
			audio.Play (44100);
		}*/
	}
	public void Creditos(){

		SceneManager.LoadScene ("Créditos");
		apertou = true;
		/*if (apertou == true) {
			audio.Play (44100);
		}*/

	}

	public void Options(){

		SceneManager.LoadScene ("Options");
		apertou = true;
		/*if (apertou == true) {
			audio.Play (44100);
		}*/

	}
		
	public void Voltar(){
		
		SceneManager.LoadScene ("Menu");
		apertou = true;
		/*if (apertou == true) {
			audio.Play (44100);
		}*/
	}
}
