﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModeScore : MonoBehaviour {

    public int ModeSelection;
    public GameObject RaceUI;
    public GameObject ScoreUI;
    public GameObject AICar;
    public static int CurrentScore;
    public int InternalScore;
    public GameObject ScoreValue;
    public GameObject ScoreObjects;
    public GameObject PositionDisplay;


	void Start () {
        ModeSelection = ModeSelect.RaceMode;

        if(ModeSelection == 1)
        {
            RaceUI.SetActive(false);
            ScoreUI.SetActive(true);
            AICar.SetActive(false);
            PositionDisplay.SetActive(false);
            ScoreObjects.SetActive(true);
            //add in timer to stop them from just driving slow to get all points
        }
	}

    void Update()
    {
        InternalScore = CurrentScore;
        ScoreValue.GetComponent<Text>().text = "" + InternalScore;
    }


}
