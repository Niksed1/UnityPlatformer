﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour {

    //public int damage = 5;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {

   
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            //Vector3 hitDirection = other.transform.position - transform.position;
            //hitDirection = hitDirection.normalized; //check normalized

            //respawn if hit any surrounding objects
            FindObjectOfType<HealthManager>().Respawn(); //FindObject is questionably slow and demanding

            
        }
    }

    void OutOfBounds()
    {
        
    }
}
