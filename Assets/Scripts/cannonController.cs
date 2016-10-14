using UnityEngine;
using System.Collections;

public class cannonController : MonoBehaviour {

    public float rotationLever;
    public float ballForce =100;
    public GameObject cannonBall;
    public Transform ballSpawn;
    public GameObject forceText;
    public AudioClip Cannonsound;

    public void updateForce(float actualAngle, float relativeAngle)
    {
        ballForce = relativeAngle * 100 + 1000;
        forceText.GetComponent<leverForceTextController>().force = ballForce;
        forceText.GetComponent<leverForceTextController>().forceAssigned = true;
    }


    public void updateCannonAngle(float oldPos, float newPos)
    {

        Debug.Log("old pos" + oldPos);
        Debug.Log("new pos" + newPos);
        rotationLever = oldPos;
       
    }

    public void fire()
    {
        GetComponent<AudioSource>().PlayOneShot(Cannonsound, .75F);
        
        GameObject clone = Instantiate(cannonBall, ballSpawn.position, Quaternion.identity) as GameObject;
        clone.GetComponent<Rigidbody>().AddForce(ballSpawn.forward * ballForce);
        Destroy(clone, 20f);
        Debug.Log("fire");
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
       

        gameObject.transform.rotation = Quaternion.Euler(0,-90 + (rotationLever*3),0);



      
    }

    
}
