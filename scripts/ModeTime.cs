using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModeTime : MonoBehaviour {

    public int ModeSelection;
    public GameObject AICar;
    public GameObject LapDisplay;
    public GameObject PositionDisplay;

    public static bool IsTimeMode = false;


	void Start () {
        ModeSelection = ModeSelect.RaceMode;

        if(ModeSelection == 2)
        {

            IsTimeMode = true;
            AICar.SetActive(false);
            LapDisplay.SetActive(false);
            PositionDisplay.SetActive(false);
        }
	}

    


}
