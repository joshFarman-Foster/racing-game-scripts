using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour {

    public GameObject NoramlCam;
    public GameObject FarCam;
    public GameObject FPSCam;

    public int CamMode;

	
	void Update () {
		if (Input.GetButtonDown("Viewmode"))
        {
            if(CamMode == 2)
            {
                CamMode = 0;
            }
            else
            {
                CamMode += 1;
            }

            StartCoroutine(ModeChange());
        }

	}

    IEnumerator ModeChange()
    {
        yield return new WaitForSeconds(0.01f);
        if(CamMode == 0)
        {
            NoramlCam.SetActive(true);
            FPSCam.SetActive(false);
        }

        if (CamMode == 1)
        {
            FarCam.SetActive(true);
            NoramlCam.SetActive(false);
        }

        if(CamMode == 2)
        {
            FPSCam.SetActive(true);
            FarCam.SetActive(false);
        }

    }
}
