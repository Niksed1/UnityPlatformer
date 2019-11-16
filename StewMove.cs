using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class StewMove : MonoBehaviour {

    public float moveSpeed = 10.0f;
    public float jumpForce = 10.0f;
    //public bool grounded = false;

    private Rigidbody myRigidbody;
	// Use this for initialization
	void Start () {
        myRigidbody = GetComponent<Rigidbody>();
	}

    private void Move()
    {
        myRigidbody.AddForce(new Vector3(Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime, 0.0f, Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime),ForceMode.Acceleration);
        if (Input.GetButtonDown("Jump") )
        {
            myRigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    // Update is called once per frame
    void FixedUpdate () {
        Move();

	}
}
