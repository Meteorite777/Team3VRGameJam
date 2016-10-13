using UnityEngine;
using System.Collections;
using VRTK;

public class Team_3_ButtonAction : MonoBehaviour {
    public GameObject doorLatch;
    // Use this for initialization
    private void Start()
    {
        GetComponent<VRTK_Button>().events.OnPush.AddListener(handlePush);
    }

    private void handlePush()
    {
        Debug.Log("Pushed");
        Destroy(doorLatch);

       
    }
}
