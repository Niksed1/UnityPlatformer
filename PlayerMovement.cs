using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float movingSpeed;
    public CharacterController PlayerControls;

    public float jumpCharacter;
    //public bool canDoubleJump;

    private Vector3 moveDirection;
    public float gravityCharacter;

    public float fallingDown;
    //public float knockBackForce;
    //public float knockBackTime;
    //public float knockBackCounter;
    
    // private bool inJump;

    // Use this for initialization
    void Start()
    {
        PlayerControls = GetComponent<CharacterController>();
        



    }

    void FixedUpdate()
    {

        PlayerMove();

        if (transform.position.y < fallingDown)
        {
            FindObjectOfType<HealthManager>().Respawn();
        }

    }
    // Update is called once per frame
    void Update()
    {
        moveDirection.y = moveDirection.y + (Physics.gravity.y * gravityCharacter);
        PlayerControls.Move(moveDirection * Time.deltaTime);

    }

    void PlayerMove()
    {
       
        //moving
        moveDirection = new Vector3(Input.GetAxisRaw("Horizontal") * movingSpeed, moveDirection.y , Input.GetAxisRaw("Vertical") * movingSpeed);

        //jumping maybe do double jumps later 

        if (Input.GetButton("Jump"))
        {
            if (PlayerControls.isGrounded)
            {
                moveDirection.y = jumpCharacter;
                //canDoubleJump = true;
                //PlayerControls.attachedRigidbody.AddForce(Vector3.up * 5.0f, ForceMode.VelocityChange);
            }
        }

        
    }
    
    public void KnockBack(Vector3 direction)
    {
        /*
        knockBackCounter = knockBackTime;
        
        moveDirection = direction * knockBackForce;
        */
    }

    /*IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        inJump = false;
    }   //Stew said no */ 
}