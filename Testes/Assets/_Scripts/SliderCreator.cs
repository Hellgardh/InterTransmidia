using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderCreator : MonoBehaviour {

	public Slider mainSlider1;
	public Slider mainSlider2;
	public AudioSource volumeAudio;

	public void VolumeController(){
		mainSlider1.value = volumeAudio.volume;

	}

	void Start () {
		mainSlider1.maxValue = 1;
		mainSlider2.maxValue = 1;
	}

}
