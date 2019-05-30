using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadLapTime : MonoBehaviour {

    public int MinCount;
    public int SecCount;
    public float MiliCount;

    public GameObject MinDisplay;
    public GameObject SecDisplay;
    public GameObject MiliDisplay;
	
	void Start () {
        if(ButtonOptions.trackNumber == 1)
        {
            MinCount = PlayerPrefs.GetInt("MinSaveT1");
            SecCount = PlayerPrefs.GetInt("SecSaveT1");
            MiliCount = PlayerPrefs.GetFloat("MiliSaveT1");
        }
        else if(ButtonOptions.trackNumber == 2)
        {
            MinCount = PlayerPrefs.GetInt("MinSaveT2");
            SecCount = PlayerPrefs.GetInt("SecSaveT2");
            MiliCount = PlayerPrefs.GetFloat("MiliSaveT2");
        }
        

        MinDisplay.GetComponent<Text>().text = "" + MinCount + ":";
        SecDisplay.GetComponent<Text>().text = "" + SecCount + ".";
        MiliDisplay.GetComponent<Text>().text = "" + MiliCount;

    }
	
	
}
