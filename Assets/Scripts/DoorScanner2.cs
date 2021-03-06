using UnityEngine;
using System.Collections;

public class DoorScanner2 : MonoBehaviour {

 
         

    public GameObject idCard; // The ID Card to be used as a 'key' for the scanner to unlock the door.
	public GameObject door; // The door object the HingeJoint component is attached to that is to be enabled/disabled ('locked').
	private HingeJoint hinge; // The actual HingeJoint component of the door.
	private JointLimits limits;
	
    public bool doorLocked = true;
    private GameObject origDoorParent; //get the original parent of the door incase we need to move the door DURING RUNTIME 
    
	// If the ID card is placed on the scanner, it will enable the Hinge Joint of the door and allow the player to push it open.
	// Use this for initialization
	void Start () {
		//scannerLight = this.GetComponent<Light> ();
		//scannerLight.color = Color.red;

		hinge = door.GetComponent<HingeJoint> ();
		limits = hinge.limits;
        LockDoor();

        //fix for door warping when a child of another object. 
        origDoorParent = door.transform.parent.gameObject; //set the original parent of the door just incase we need to move the door DURING RUNTIME
        door.transform.parent = null; // to fix the strange warping of the child object (becuse of nested scale) simply unparent once the prefab is instatiated.  


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
		
        GetComponent<Renderer>().material.color = Color.green;
    }

	void LockDoor(){
		
		doorLocked = true;
		Debug.Log("The Door was locked.");

		limits.min = 0;
		limits.max = 0;
		hinge.useLimits = true;
		
        GetComponent<Renderer>().material.color = Color.red;
    }

}
