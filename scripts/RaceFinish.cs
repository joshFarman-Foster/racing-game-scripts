using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.SceneManagement;

public class RaceFinish : MonoBehaviour {

    public GameObject MyCar;
    public GameObject FinsihCam;
    public GameObject ViewModes;
    public GameObject LevelMusic;
    public GameObject CompleteTrig;
    public AudioSource FinishMusic;

    void OnTriggerEnter()
    {
        if(ModeTime.IsTimeMode == true)
        {
            //we are on race time mdoe

        }else{
            this.GetComponent<BoxCollider>().enabled = false;
            MyCar.SetActive(false);
            CompleteTrig.SetActive(false);
            CarController.m_Topspeed = 0.0f;
            MyCar.GetComponent<CarController>().enabled = false;
            MyCar.GetComponent<CarUserControl>().enabled = false;
            MyCar.SetActive(true);
            FinsihCam.SetActive(true);
            LevelMusic.SetActive(false);
            ViewModes.SetActive(false);
            FinishMusic.Play();
            GlobalCash.TotalCash += 100;
            PlayerPrefs.SetInt("SavedCash", GlobalCash.TotalCash);
            StartCoroutine(loadMenu());

        }
      

    }

    IEnumerator loadMenu()
    {
        yield return new WaitForSeconds(4);
        CarController.m_Topspeed = 140.0f;
        SceneManager.LoadScene(1);

    }
}
