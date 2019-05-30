using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour {

    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;

    public GameObject MinuteDisplay;
    public GameObject SecondDisplay;
    public GameObject MiliDisplay;

    public GameObject LapTimeBox;

    public GameObject LapCounter;
    public int LapsDone;

    public float Rawtime;

    public GameObject RaceFinish;

    void OnTriggerEnter()
    {
        LapsDone += 1;
        if (ButtonOptions.trackNumber == 1)
        {

            Rawtime = PlayerPrefs.GetFloat("RawTimeT1");

            if (LapTimeManager.RawTime <= Rawtime || Rawtime == 0)
            {
                if (LapTimeManager.SecondCount <= 9)
                {
                    SecondDisplay.GetComponent<Text>().text = "0" + LapTimeManager.SecondCount + ".";
                }
                else
                {
                    SecondDisplay.GetComponent<Text>().text = "" + LapTimeManager.SecondCount + ".";
                }

                if (LapTimeManager.MinuteCount <= 9)
                {
                    MinuteDisplay.GetComponent<Text>().text = "0" + LapTimeManager.MinuteCount + ".";
                }
                else
                {
                    MinuteDisplay.GetComponent<Text>().text = "" + LapTimeManager.MinuteCount + ".";
                }

                MiliDisplay.GetComponent<Text>().text = "" + LapTimeManager.MiliCount;
                

                PlayerPrefs.SetInt("MinSaveT1", LapTimeManager.MinuteCount);
                PlayerPrefs.SetInt("SecSaveT1", LapTimeManager.SecondCount);
                PlayerPrefs.SetFloat("MiliSaveT1", LapTimeManager.MiliCount);
                PlayerPrefs.SetFloat("RawTimeT1", LapTimeManager.RawTime);
            }
        }
        else if(ButtonOptions.trackNumber == 2)
        {

            Rawtime = PlayerPrefs.GetFloat("RawTimeT2");

            if (LapTimeManager.RawTime <= Rawtime || Rawtime == 0)
            {
                if (LapTimeManager.SecondCount <= 9)
                {
                    SecondDisplay.GetComponent<Text>().text = "0" + LapTimeManager.SecondCount + ".";
                }
                else
                {
                    SecondDisplay.GetComponent<Text>().text = "" + LapTimeManager.SecondCount + ".";
                }

                if (LapTimeManager.MinuteCount <= 9)
                {
                    MinuteDisplay.GetComponent<Text>().text = "0" + LapTimeManager.MinuteCount + ".";
                }
                else
                {
                    MinuteDisplay.GetComponent<Text>().text = "" + LapTimeManager.MinuteCount + ".";
                }

                MiliDisplay.GetComponent<Text>().text = "" + LapTimeManager.MiliCount;
                

                PlayerPrefs.SetInt("MinSaveT2", LapTimeManager.MinuteCount);
                PlayerPrefs.SetInt("SecSaveT2", LapTimeManager.SecondCount);
                PlayerPrefs.SetFloat("MiliSaveT2", LapTimeManager.MiliCount);
                PlayerPrefs.SetFloat("RawTimeT2", LapTimeManager.RawTime);
            }
        }
        LapTimeManager.MinuteCount = 0;
        LapTimeManager.SecondCount = 0;
        LapTimeManager.MiliCount = 0;
        LapTimeManager.RawTime = 0;

        LapCounter.GetComponent<Text>().text = "" + LapsDone;

        if (LapsDone == 2)
        {
            RaceFinish.SetActive(true);

        }

        HalfLapTrig.SetActive(true);
        LapCompleteTrig.SetActive(false);

    }

}
