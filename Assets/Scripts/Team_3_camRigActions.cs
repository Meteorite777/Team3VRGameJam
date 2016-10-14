using UnityEngine;
using System.Collections;
using VRTK;
public class Team_3_camRigActions : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void moveRig(Vector3 newPos)
    {
        Debug.Log("moving to:" + newPos);
       // this.transform.position = newPos;
       
    }

}
