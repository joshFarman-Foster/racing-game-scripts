using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class CountDown : MonoBehaviour {

    public GameObject Countdown;
    public AudioSource getReady;
    public AudioSource GoAudio;
    public AudioSource LevelMusic;

    public GameObject LapTimer;
   
    public GameObject CarUserControls;
    public GameObject AiUserControls;

	
	void Start () {
        StartCoroutine(CountStart());
        CarUserControls.GetComponent<CarUserControl>().enabled = false;
        AiUserControls.GetComponent<CarAIControl>().enabled = false;

	}
	
    IEnumerator CountStart()
    {
        

        yield return new WaitForSeconds(0.5f);
        Countdown.GetComponent<Text>().text = "3";
        getReady.Play();
        Countdown.SetActive(true);
        yield return new WaitForSeconds(1);
        Countdown.SetActive(false);
        Countdown.GetComponent<Text>().text = "2";
        getReady.Play();
        Countdown.SetActive(true);
        yield return new WaitForSeconds(1);
        Countdown.SetActive(false);
        Countdown.GetComponent<Text>().text = "1";
        getReady.Play();
        Countdown.SetActive(true);
        yield return new WaitForSeconds(1);
        Countdown.SetActive(false);
        GoAudio.Play();
        LevelMusic.Play();
        LapTimer.SetActive(true);
        
        CarUserControls.GetComponent<CarUserControl>().enabled = true;
        AiUserControls.GetComponent<CarAIControl>().enabled = true;

    }
	
}
