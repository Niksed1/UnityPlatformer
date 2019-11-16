using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGun : MonoBehaviour {

    public GameObject BulletObjEnemy;
    public ShipMoves theShip;

    // Use this for initialization
    void Start ()
    {
        theShip = FindObjectOfType<ShipMoves>();

        InvokeRepeating("FireBullets", 0.5f, 0.5f);
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void FireBullets()
    {
        
        //GameObject playerShip = GameObject.Find("Ship"); //locate the ship

        if (theShip != null) // if the ship exists
        {
            Vector3 spawnPos = transform.position; //initial position

            GameObject bullet = (GameObject)Instantiate(BulletObjEnemy, spawnPos, Quaternion.identity);

            

            Vector3 direction = theShip.transform.position - bullet.transform.position; //direction towards the ships

            bullet.GetComponent<EnemyShoots>().SetDirection(direction);
        }

    }
}
