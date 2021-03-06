using UnityEngine;
using System.Collections;

public class DoorScanner : MonoBehaviour {

    public GameObject idCard; // The ID Card to be used as a 'key' for the scanner to unlock the door.
	public GameObject door; // The door object the HingeJoint component is attached to that is to be enabled/disabled ('locked').
	public HingeJoint hinge; // The actual HingeJoint component of the door.
	public JointLimits limits;
	public Light scannerLight;
    private bool doorLocked = true;
    
	// If the ID card is placed on the scanner, it will enable the Hinge Joint of the door and allow the player to push it open.
	// Use this for initialization
	void Start () {
		scannerLight = this.GetComponent<Light> ();
		scannerLight.color = Color.red;

		hinge = door.GetComponent<HingeJoint> ();
		limits = hinge.limits;
		limits.min = 0;
		limits.max = 0;
		hinge.limits = limits;
		hinge.useLimits = true;

    }
	


	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject==idCard && doorLocked==true)
        {
			UnlockDoor ();
        }
		else if (col.gameObject == idCard && doorLocked == false) {
			LockDoor ();
		}
    }

	void UnlockDoor(){
		doorLocked = false;

		Debug.Log("The Door was unlocked.");

		hinge.useLimits = false;
		scannerLight.color = Color.green;
	}

	void LockDoor(){
		
		doorLocked = true;
		Debug.Log("The Door was locked.");

		limits.min = 0;
		limits.max = 0;
		hinge.useLimits = true;
		scannerLight.color = Color.red;
	}

}
