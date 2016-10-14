using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class leverForceTextController : MonoBehaviour {


    public bool forceAssigned = false;
    public float force;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

       if (forceAssigned)
        {
            gameObject.GetComponent<Text>().text = "Force: " + force;
        }
        else
        {
            gameObject.GetComponent<Text>().text = "Cannon ball force";
        }
    } 

}
