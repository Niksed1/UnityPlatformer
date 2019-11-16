using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagPickUp : MonoBehaviour {

    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            //FindObjectOfType<GameManager>().FlagsCollected(1);
            GameManager.Instance.FlagsCollected(1);

            Destroy(gameObject);
        }
    }
}
