using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipShoots : MonoBehaviour {

    public float movingSpeed;
    private Vector3 moveDirection;

    // Use this for initialization
    void Start ()
    {
        movingSpeed = 20f;
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 moveDirection = transform.position; //get

        moveDirection = new Vector3(moveDirection.x, moveDirection.y + movingSpeed * Time.deltaTime, 0f); //update
        transform.position = moveDirection; //set

        Vector3 maxMargin = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, 1)); //camera.nearClipPlane

       if(transform.position.y > maxMargin.y)
        {
            Destroy(gameObject);
        } 
    }
}