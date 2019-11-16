using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoots : MonoBehaviour {

    float movingSpeed;
    private Vector3 _direction;
    private bool canShoot;

    private void Awake()
    {
        movingSpeed = 10f;
        canShoot = false;
    }
    // Double initialization 
    void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        Shoot();
	}

    public void SetDirection(Vector3 direction) // set bullet's direction
    {
        _direction = direction.normalized;
        canShoot = true;
    }

    void Shoot ()
    {
        if (canShoot)
        {
            Vector3 position= transform.position; //get the current position

            position += _direction * movingSpeed * Time.deltaTime; //get the new position

            transform.position = position; //set the new position

            Vector3 min = Camera.main.ViewportToWorldPoint(Vector3.zero); //left
            Vector3 max = Camera.main.ViewportToWorldPoint(Vector3.one); //right

            if ((transform.position.y > max.y) || (transform.position.y < min.y ) ||
                (transform.position.x > max.x ) || (transform.position.x < min.x))
               
            {
                Destroy(gameObject);
            }

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if( other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
