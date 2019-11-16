using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoves : MonoBehaviour {

    public float movingSpeed;
    public CharacterController enemyFalls;
    private Vector3 moveDirection;


    // Use this for initialization
    void Start ()
    {
        enemyFalls = GetComponent<CharacterController>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        EnemyMove();
	}

    void EnemyMove()
    {

        Vector3 position = transform.position; // get position

        position = new Vector3(position.x, position.y - movingSpeed * Time.deltaTime, 0f); //position.z

        transform.position = position;  // set position

        Camera camera = GetComponent<Camera>();
        Vector3 min = Camera.main.ViewportToWorldPoint(Vector3.zero);

        if (transform.position.y < min.y)
        {
            Destroy(gameObject); //destroys enemy if it goes off bounds on the bottom
        }

    }

    
}
