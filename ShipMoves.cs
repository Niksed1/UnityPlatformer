using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShipMoves : MonoBehaviour {

    public float movingSpeed;
    public CharacterController PlayerControls;
    private Vector3 moveDirection;

    public GameObject BulletObj;
    public GameObject BulletStart01;
    public GameObject BulletStart;

    //wait between shooting vars
    private float timeBetween;
    
    public static bool isDead;

    //public float gravityCharacter;

    private bool isRespawning;

    // Use this for initialization
    void Start ()
    {
        PlayerControls = GetComponent<CharacterController>();
        movingSpeed = 20f;
        timeBetween = 0f;
        isDead = false;
        
    }

	// Update is called once per frame
	void Update () {

        //Vector3 setDirection = new Vector3 (x,  y,  z).normalized;

        ShipMove();
        FireBullets();

    

    }

    void ShipMove()
    {
        //moving
        moveDirection = new Vector3(Input.GetAxisRaw("Horizontal") * movingSpeed, moveDirection.y, moveDirection.z);
        PlayerControls.Move(moveDirection * Time.deltaTime);
       
    }

    void FireBullets()
    {
        if (Input.GetButton("Fire1") && Time.time >= timeBetween)
        {
            // instantiate/spawn bullets optimize
            GameObject bullet1 = (GameObject)Instantiate(BulletObj);
            bullet1.transform.position = BulletStart.transform.position;
            GameObject bullet2 = (GameObject)Instantiate(BulletObj);
            bullet2.transform.position = BulletStart01.transform.position;

            //delay for shooting
            timeBetween = Time.time + 0.2f;

        }
    }
    // if the bullet or the enemy collides with the ship DEA
   void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "DamageEnemy")
        {
            isDead = true;
            Destroy(gameObject);
        }
    }

    
   
   

}