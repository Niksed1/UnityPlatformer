using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public CharacterController PlayerControls;
    public Transform target;
    public Vector3 offset;
    public bool useOffset;

    // Use this for initialization
    void Start ()
    {
        if(!useOffset)
        {
            offset = target.position - transform.position; // place the camera right where the player is
        }
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        WatchTarget();

	}

    void WatchTarget()
    {
        transform.position = target.position - offset; //set new position 

        transform.LookAt(target);
        
    }
}
