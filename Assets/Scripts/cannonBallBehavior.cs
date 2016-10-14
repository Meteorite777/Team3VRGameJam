using UnityEngine;
using System.Collections;

public class cannonBallBehavior : MonoBehaviour {
    

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.layer != 8)
        {
            Debug.Log("collision");
            Destroy(col.gameObject);
        }
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
