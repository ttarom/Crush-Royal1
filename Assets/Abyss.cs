using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abyss : MonoBehaviour {

    public float StartTime;
    public float TimeStamp;
    public Animation Animation;


    // Use this for initialization
    void Start ()
    {
       
	}
	
	// Update is called once per frame
	void Update ()
    {
	    

        StartTime = Time.time;
    }

    public void OnTriggerEnter(Collider other)

    {
        


        /*
        if (TimeStamp == (StartTime-1) && other.tag == "Player")
        {
            Debug.Log("Yes");
            other.attachedRigidbody.useGravity = false;

        }
        */
    }
}
