using UnityEngine;
using System.Collections;

public class SwitchScript : MonoBehaviour {

	// Use this for initialization

public GameObject CameraRig;
public GameObject CameraRigKyle;

	void Update()
		{
			if(Input.GetKeyDown("Application_Menu"))
			{
			if(CameraRig.activeSelf == true)
				{
					CameraRig.SetActive(false);
					CameraRigKyle.SetActive(true);
				}
			else if(CameraRig.activeSelf == false)
				{
				CameraRig.SetActive(true);
				CameraRigKyle.SetActive(false);
				}
			}

		}
	}
	
	// Update is called once per frame