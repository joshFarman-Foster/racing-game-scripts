﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonOptions : MonoBehaviour {

    public static int trackNumber;

    //public void PlayGame()
    //{
     //   SceneManager.LoadScene(2);
    //}

    

    public void PlayGame()
    {
        SceneManager.LoadScene(2);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(1);
    }

    public void Credits()
    {
        SceneManager.LoadScene(5);
    }

    //below here are track selection buttons

    public void Track01()
    {
        trackNumber = 1;
        SceneManager.LoadScene(3);
    }
    public void Track02()
    {
        trackNumber = 2;
        SceneManager.LoadScene(4);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
