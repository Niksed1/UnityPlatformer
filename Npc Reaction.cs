using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcReply : MonoBehaviour {

    public float range = 50f;
    private Transform Character;
    private Transform NPC;
    public float movingSpeed = 5f;

    private void Awake()
    {
        NPC = this.transform;
        Character = GameObject.FindGameObjectWithTag("Character").transform;
    }
   
    void Start () {
		
	}

    void Update () {
        if (Vector3.Distance(NPC.position, Character.position)< range && Input.GetKey(KeyCode.E))
        {
            transform.Translate(Vector3.up * movingSpeed*Time.deltaTime);
        }
    }

}