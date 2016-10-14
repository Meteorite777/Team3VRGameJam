using UnityEngine;
using System.Collections;

public class DavesHMDActions : MonoBehaviour {

    public GameObject camRigEye; //the camera rig for the player. 
    public GameObject camRig; //the player object representing dave.. 
    private bool hmdOnDave = false;
    public Transform littleDavesStartPos;
    
    // if dave places the HMD on his head he scales down to the LittleDave
	// Use this for initialization
	void Start () {
      
    }
	


	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject==camRigEye && hmdOnDave==false)
        {
            hmdOnDave = true;

            

            Debug.Log("The HMD was put on Daves head, moving from:" + camRig.transform.position + " to " + littleDavesStartPos.transform.position);

            camRig.GetComponent<Team_3_camRigActions>().moveRig(littleDavesStartPos.transform.position);


            ChangeDavesScale(0.15f);

            this.enabled = false;
        }
		} else if (col.gameObject == camRigEye && hmdOnDave == true) {
			hmdOnDave = false;
			
			
			
			Debug.Log ("The HMD was removed from little Daves head, moving from:" + camRig.transform.position + " to " + littleDavesStartPos.transform.position);
			
			camRig.GetComponent<Team_3_camRigActions> ().moveRig (littleDavesStartPos.transform.position);
			
			
			ChangeDavesScale (1.00f);
			
			this.enabled = false;
		}
    }

    void ChangeDavesScale(float newScale)
    {
        Debug.Log("chaning cam rig scale:" + newScale);
        camRig.transform.localScale = new Vector3(newScale, newScale, newScale);
    }

}
